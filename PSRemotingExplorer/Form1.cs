using PSRemotingExplorer.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PSRemotingExplorer
{
    //https://stackoverflow.com/questions/37791149/c-sharp-show-file-and-folder-icons-in-listview
    public partial class Form1 : Form
    {
        private MachineManager _MachineManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void PopulateRemoteTreeView(string rootDirectory, string[] directories)
        {
            trvDirectories.Nodes.Clear();

            string rootDirectoryName = Path.GetDirectoryName($"{rootDirectory}\\");
            if (string.IsNullOrEmpty(rootDirectoryName) && Path.IsPathRooted(rootDirectory))
            {
                rootDirectoryName = rootDirectory;
            }
            var rootNode = new TreeNode(rootDirectoryName)
            {
                Tag = rootDirectory,
                StateImageIndex = 0
            };

            foreach (var directory in directories)
            {
                var directoryName = Path.GetDirectoryName($"{directory}\\");
                var childNode = new TreeNode(directoryName, 0, 0)
                {
                    Tag = directory,
                    StateImageIndex = 0
                };

                rootNode.Nodes.Add(childNode);
            }


            trvDirectories.Nodes.Add(rootNode);
        }

        private void PopulateRemoteListView(string[] files)
        {
            lvFiles.Items.Clear();
            lvFiles.Columns.Clear();
            lvFiles.View = View.Details;
            lvFiles.Columns.Add("Name", 500);

            foreach (var file in files)
            {
                var name = Path.GetFileName(file);
                lvFiles.Items.Add(new ListViewItem(name)
                {
                    Tag = file
                });
            }
        }

        private void LoadDirectories(string path)
        {
            var result = _MachineManager.RunScript("{ param($path) Get-ChildItem -Path $path -Directory | Select-Object -Expand FullName }", new[] { path });
            var items = new List<string>();
            foreach (var item in result.Cast<System.Management.Automation.PSObject>().ToArray())
            {
                items.Add(item.BaseObject.ToString());
            }
            PopulateRemoteTreeView("C:", items.ToArray());
        }

        private void LoadFiles(string path)
        {
            var result = _MachineManager.RunScript("{ param($path) Get-ChildItem -Path $path -File | Select-Object -Expand FullName }", new[] { path });
            var items = new List<string>();
            foreach (var item in result.Cast<System.Management.Automation.PSObject>().ToArray())
            {
                items.Add(item.BaseObject.ToString());
            }
            PopulateRemoteListView(items.ToArray());
        }

        private void DownloadFile(string sourcePath, string destinationPath)
        {
            _MachineManager.CopyFileFromSession(sourcePath, destinationPath);
        }

        private void UploadFile(string sourcePath, string destinationPath)
        {
            _MachineManager.CopyFileToSession(sourcePath, destinationPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            lvFiles.DragDrop += lvFiles_DragDrop;
            lvFiles.DragEnter += lvFiles_DragEnter;
        }

        private void lvFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lvFiles_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach(var file in files)
                {
                    PrepareUpload(file);
                }
            }
        }

        private void trvDirectories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var directory = e.Node.Tag.ToString();

            LoadFiles(directory);
        }

        private void lvFiles_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvFiles.FocusedItem.Bounds.Contains(e.Location))
                {
                    ctxMenuSelected.Show(Cursor.Position);
                }
            }
        }

        private void downloadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fullname = lvFiles.SelectedItems[0].Tag.ToString();
            var filename = lvFiles.SelectedItems[0].Text;
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = filename;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DownloadFile(fullname, saveFileDialog.FileName);
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var computerName = txtComputerName.Text;
            var port = int.Parse(txtPort.Text);
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            _MachineManager = new MachineManager(computerName, port, username, password.ToSecureString(), System.Management.Automation.Runspaces.AuthenticationMechanism.Basic);
            _MachineManager.EnterSession();

            LoadDirectories(@"C:\");

            lvFiles.AllowDrop = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (_MachineManager != null)
            {
                _MachineManager.ExitSession();
            }

            this.lvFiles.Items.Clear();
            this.trvDirectories.Nodes.Clear();

            lvFiles.AllowDrop = false;
        }

        private void lvFiles_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo htInfo = lvFiles.HitTest(e.Location);
                if (htInfo.Item == null)
                {
                    ctxMenuDirectory.Show(Cursor.Position);
                }
            }
        }

        private void PrepareUpload(string sourcePath)
        {
            var destinationPath = this.trvDirectories.SelectedNode.Tag.ToString();
            UploadFile(sourcePath, destinationPath);

            var directory = this.trvDirectories.SelectedNode.Tag.ToString();
            LoadFiles(directory);
        }

        private void uploadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    PrepareUpload(ofd.FileName);
                }
            }
        }

        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fullname = lvFiles.SelectedItems[0].Tag.ToString();
            _MachineManager.RemoveFileFromSession(fullname);

            var directory = this.trvDirectories.SelectedNode.Tag.ToString();
            LoadFiles(directory);
        }
    }
}
