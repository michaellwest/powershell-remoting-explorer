using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;
using PSRemotingExplorer.Extensions;

namespace PSRemotingExplorer
{
    //https://stackoverflow.com/questions/37791149/c-sharp-show-file-and-folder-icons-in-listview
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        private MachineManager _machineManager;

        public MainForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void InitializeTreeView(string rootDirectory, List<string> directories)
        {
            trvDirectories.Nodes.Clear();

            var rootDirectoryName = Path.GetDirectoryName($"{rootDirectory}\\");
            if (string.IsNullOrEmpty(rootDirectoryName) && Path.IsPathRooted(rootDirectory))
                rootDirectoryName = rootDirectory;
            var rootNode = new TreeNode(rootDirectoryName)
            {
                Tag = rootDirectory,
                StateImageIndex = 0
            };

            AddTreeNodes(rootNode, directories);

            trvDirectories.Nodes.Add(rootNode);
        }

        private void AddTreeNodes(TreeNode rootNode, List<string> directories)
        {
            foreach (var directory in directories)
            {
                var directoryName = new DirectoryInfo(directory).Name;
                var childNode = new TreeNode(directoryName, 0, 0)
                {
                    Tag = directory,
                    StateImageIndex = 0
                };

                rootNode.Nodes.Add(childNode);
            }
        }

        private void PopulateRemoteListView(string[] files)
        {
            lvFiles.Items.Clear();
            lvFiles.Columns.Clear();
            lvFiles.View = View.Details;
            lvFiles.Columns.Add("Name", 480);

            foreach (var file in files)
            {
                var name = Path.GetFileName(file);
                lvFiles.Items.Add(new ListViewItem(name)
                {
                    Tag = file
                });
            }
        }

        private List<string> LoadDirectories(string path)
        {
            var result = _machineManager.RunScript(
                "{ param($path) Get-ChildItem -Path $path -Directory | Select-Object -Expand FullName }", new[] { path });
            var items = new List<string>();
            foreach (var item in result.ToArray()) items.Add(item.BaseObject.ToString());
            return items;
        }

        private List<string> LoadFiles(string path)
        {
            var result = _machineManager.RunScript(
                "{ param($path) Get-ChildItem -Path $path -File | Select-Object -Expand FullName }", new[] { path });
            var items = new List<string>();
            foreach (var item in result.ToArray()) items.Add(item.BaseObject.ToString());
            return items;
        }

        private void RefreshFiles()
        {
            var directory = trvDirectories.SelectedNode.Tag.ToString();
            var fileItems = LoadFiles(directory);
            PopulateRemoteListView(fileItems.ToArray());
        }

        private void DownloadFile(string sourcePath, string destinationPath)
        {
            _machineManager.CopyFileFromSession(sourcePath, destinationPath);
        }

        private void ExtractFile(string filePathOnTargetMachine, string folderPathOnTargetMachine)
        {
            _machineManager.ExtractFileFromSession(filePathOnTargetMachine, folderPathOnTargetMachine);
        }

        private void UploadFile(string sourcePath, string destinationPath)
        {
            _machineManager.CopyFileToSession(sourcePath, destinationPath);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lvFiles.DragDrop += lvFiles_DragDrop;
            lvFiles.DragEnter += lvFiles_DragEnter;

            this.btnDisconnect.Enabled = false;
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
                foreach (var file in files) PrepareUpload(file);
            }
        }

        private void trvDirectories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var directory = e.Node.Tag.ToString();
            e.Node.Nodes.Clear();
            var directoryItems = LoadDirectories(directory);
            AddTreeNodes(e.Node, directoryItems);

            RefreshFiles();
        }

        private void lvFiles_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvFiles.FocusedItem.Bounds.Contains(e.Location))
                {
                    var fullname = lvFiles.SelectedItems[0].Tag.ToString();
                    var extension = Path.GetExtension(fullname);
                    ctxMenuSelected.Items["extractFileToolStripMenuItem"].Enabled = extension.Is(".zip");
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
                if (saveFileDialog.ShowDialog() == DialogResult.OK) DownloadFile(fullname, saveFileDialog.FileName);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var computerName = txtComputerName.Text;
            var port = int.Parse(txtPort.Text);
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            _machineManager = new MachineManager(computerName, port, username, password.ToSecureString(),
                AuthenticationMechanism.Basic);
            _machineManager.EnterSession();

            var directoryItems = LoadDirectories(@"C:\");
            InitializeTreeView("C:", directoryItems);

            lvFiles.AllowDrop = true;
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _machineManager?.ExitSession();

            lvFiles.Items.Clear();
            trvDirectories.Nodes.Clear();

            lvFiles.AllowDrop = false;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }

        private void lvFiles_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var htInfo = lvFiles.HitTest(e.Location);
                if (htInfo.Item == null) ctxMenuDirectory.Show(Cursor.Position);
            }
        }

        private void PrepareUpload(string sourcePath)
        {
            var destinationPath = trvDirectories.SelectedNode.Tag.ToString();
            UploadFile(sourcePath, destinationPath);

            RefreshFiles();
        }

        private void uploadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK) PrepareUpload(ofd.FileName);
            }
        }

        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fullname = lvFiles.SelectedItems[0].Tag.ToString();
            _machineManager.RemoveFileFromSession(fullname);

            RefreshFiles();
        }

        private void extractFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fullname = lvFiles.SelectedItems[0].Tag.ToString();
            if (!Path.HasExtension(fullname) || !Path.GetExtension(fullname).Is(".zip")) return;

            var folderPath = Path.GetDirectoryName(fullname);
            ExtractFile(fullname, folderPath);

            RefreshFiles();
        }

        private void lvFiles_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var fullname = lvFiles.SelectedItems[0].Tag.ToString();
                _machineManager.RemoveFileFromSession(fullname);

                RefreshFiles();
            } 
            else if (e.KeyCode == Keys.F2)
            {
                var fullname = lvFiles.SelectedItems[0].Tag.ToString();
                var newname = Path.GetFileName(fullname);
                var response = Interaction.InputBox("What is the new name?","Rename Item",newname);
                if (string.IsNullOrEmpty(response)) return;

                newname = response;
            
                _machineManager.RenameFileFromSession(fullname, newname);

                RefreshFiles();
            }
        }

        private void renameFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fullname = lvFiles.SelectedItems[0].Tag.ToString();
            var newname = Path.GetFileName(fullname);
            var response = Interaction.InputBox("What is the new name?","Rename Item",newname);
            if (string.IsNullOrEmpty(response)) return;

            newname = response;
            
            _machineManager.RenameFileFromSession(fullname, newname);

            RefreshFiles();
        }
    }
}