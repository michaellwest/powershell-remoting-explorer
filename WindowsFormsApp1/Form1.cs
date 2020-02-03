using Naos.Recipes.WinRM;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //https://stackoverflow.com/questions/37791149/c-sharp-show-file-and-folder-icons-in-listview
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PopulateRemoteTreeView(string rootDirectory, string[] directories)
        {
            treeView1.Nodes.Clear();

            string rootDirectoryName = Path.GetDirectoryName($"{rootDirectory}\\");
            if(string.IsNullOrEmpty(rootDirectoryName) && Path.IsPathRooted(rootDirectory))
            {
                rootDirectoryName = rootDirectory;
            }
            var rootNode = new TreeNode(rootDirectoryName)
            {
                Tag = rootDirectory,
                StateImageIndex = 0
            };

            foreach(var directory in directories)
            {
                var directoryName = Path.GetDirectoryName($"{directory}\\");
                var childNode = new TreeNode(directoryName, 0, 0)
                {
                    Tag = directory,
                    StateImageIndex = 0
                };

                rootNode.Nodes.Add(childNode);
            }
            
            
            treeView1.Nodes.Add(rootNode);
        }

        private void PopulateRemoteListView(string[] files)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Name", 500);

            foreach(var file in files)
            {
                var name = Path.GetFileName(file);
                listView1.Items.Add(new ListViewItem(name)
                {
                    Tag = file
                }); ;
            }
        }

        private void LoadDirectories(string path)
        {
            var machineManager = new MachineManager(
                "127.0.0.1",
                "User03",
                "Passw0rd".ToSecureString(),
                autoManageTrustedHosts: true,
                port: 55985,
                authentication: System.Management.Automation.Runspaces.AuthenticationMechanism.Basic);

            var result = machineManager.RunScript("{ param($path) Get-ChildItem -Path $path -Directory | Select-Object -Expand FullName }", new[] { path });
            var items = new List<string>();
            foreach (var item in result.Cast<System.Management.Automation.PSObject>().ToArray())
            {
                items.Add(item.BaseObject.ToString());
            }
            PopulateRemoteTreeView("C:", items.ToArray());
        }

        private void LoadFiles(string path)
        {
            var machineManager = new MachineManager(
                "127.0.0.1",
                "User03",
                "Passw0rd".ToSecureString(),
                autoManageTrustedHosts: true,
                port: 55985,
                authentication: System.Management.Automation.Runspaces.AuthenticationMechanism.Basic);

            var result = machineManager.RunScript("{ param($path) Get-ChildItem -Path $path -File | Select-Object -Expand FullName }", new[] { path });
            var items = new List<string>();
            foreach (var item in result.Cast<System.Management.Automation.PSObject>().ToArray())
            {
                items.Add(item.BaseObject.ToString());
            }
            PopulateRemoteListView(items.ToArray());
        }

        private void DownloadFile(string sourcePath, string destinationPath)
        {
            var machineManager = new MachineManager(
                "127.0.0.1",
                "User03",
                "Passw0rd".ToSecureString(),
                autoManageTrustedHosts: true,
                port: 55985,
                authentication: System.Management.Automation.Runspaces.AuthenticationMechanism.Basic);

            //var bytes = machineManager.RetrieveFile(sourcePath);

            //File.WriteAllBytes(destinationPath, bytes);

            machineManager.CopyFileFromSession(sourcePath, destinationPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDirectories(@"C:\");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var directory = e.Node.Tag.ToString();

            LoadFiles(directory);
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void downloadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fullname = listView1.SelectedItems[0].Tag.ToString();
            var filename = listView1.SelectedItems[0].Text;
            using(var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = filename;
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {                    
                    DownloadFile(fullname, saveFileDialog.FileName);
                }
            }
        }
    }
}
