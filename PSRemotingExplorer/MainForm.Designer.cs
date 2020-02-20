using MaterialSkin.Controls;

namespace PSRemotingExplorer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trvDirectories = new System.Windows.Forms.TreeView();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.btnConnection = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPort = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtComputerName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ctxFileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.extractFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxFileMenu2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uploadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.cboDrives = new System.Windows.Forms.ComboBox();
            this.rdbAuthSSO = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbAuthBasic = new MaterialSkin.Controls.MaterialRadioButton();
            this.ctxDirectoryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveConnection = new MaterialSkin.Controls.MaterialFlatButton();
            this.ctxFileMenu.SuspendLayout();
            this.ctxFileMenu2.SuspendLayout();
            this.ctxDirectoryMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvDirectories
            // 
            this.trvDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvDirectories.Font = new System.Drawing.Font("Roboto", 11F);
            this.trvDirectories.HideSelection = false;
            this.trvDirectories.Location = new System.Drawing.Point(209, 86);
            this.trvDirectories.Name = "trvDirectories";
            this.trvDirectories.Size = new System.Drawing.Size(288, 590);
            this.trvDirectories.TabIndex = 0;
            this.trvDirectories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDirectories_AfterSelect);
            this.trvDirectories.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trvDirectories_KeyUp);
            this.trvDirectories.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trvDirectories_MouseClick);
            // 
            // lvFiles
            // 
            this.lvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFiles.Font = new System.Drawing.Font("Roboto", 11F);
            this.lvFiles.HideSelection = false;
            this.lvFiles.Location = new System.Drawing.Point(499, 86);
            this.lvFiles.MultiSelect = false;
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(500, 590);
            this.lvFiles.TabIndex = 0;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvFiles_KeyUp);
            this.lvFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvFiles_MouseClick);
            this.lvFiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvFiles_MouseUp);
            // 
            // btnConnection
            // 
            this.btnConnection.AutoSize = true;
            this.btnConnection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnection.Depth = 0;
            this.btnConnection.Icon = null;
            this.btnConnection.Location = new System.Drawing.Point(12, 75);
            this.btnConnection.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Primary = true;
            this.btnConnection.Size = new System.Drawing.Size(84, 36);
            this.btnConnection.TabIndex = 8;
            this.btnConnection.Text = "Connect";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "Password";
            this.txtPassword.Location = new System.Drawing.Point(12, 187);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(189, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TabStop = false;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Depth = 0;
            this.txtUsername.Hint = "Username";
            this.txtUsername.Location = new System.Drawing.Point(12, 158);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(184, 23);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TabStop = false;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // txtPort
            // 
            this.txtPort.Depth = 0;
            this.txtPort.Hint = "Port";
            this.txtPort.Location = new System.Drawing.Point(12, 245);
            this.txtPort.MaxLength = 5;
            this.txtPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.SelectedText = "";
            this.txtPort.SelectionLength = 0;
            this.txtPort.SelectionStart = 0;
            this.txtPort.Size = new System.Drawing.Size(97, 23);
            this.txtPort.TabIndex = 6;
            this.txtPort.TabStop = false;
            this.txtPort.UseSystemPasswordChar = false;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // txtComputerName
            // 
            this.txtComputerName.Depth = 0;
            this.txtComputerName.Hint = "ComputerName";
            this.txtComputerName.Location = new System.Drawing.Point(12, 216);
            this.txtComputerName.MaxLength = 32767;
            this.txtComputerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.PasswordChar = '\0';
            this.txtComputerName.SelectedText = "";
            this.txtComputerName.SelectionLength = 0;
            this.txtComputerName.SelectionStart = 0;
            this.txtComputerName.Size = new System.Drawing.Size(161, 23);
            this.txtComputerName.TabIndex = 5;
            this.txtComputerName.TabStop = false;
            this.txtComputerName.UseSystemPasswordChar = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ctxFileMenu
            // 
            this.ctxFileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteFileToolStripMenuItem,
            this.renameFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.extractFileToolStripMenuItem});
            this.ctxFileMenu.Name = "contextMenuStrip1";
            this.ctxFileMenu.Size = new System.Drawing.Size(129, 104);
            // 
            // downloadFileToolStripMenuItem
            // 
            this.downloadFileToolStripMenuItem.Name = "downloadFileToolStripMenuItem";
            this.downloadFileToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.downloadFileToolStripMenuItem.Text = "Download";
            this.downloadFileToolStripMenuItem.Click += new System.EventHandler(this.downloadFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // deleteFileToolStripMenuItem
            // 
            this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
            this.deleteFileToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteFileToolStripMenuItem.Text = "Delete";
            this.deleteFileToolStripMenuItem.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
            // 
            // renameFileToolStripMenuItem
            // 
            this.renameFileToolStripMenuItem.Name = "renameFileToolStripMenuItem";
            this.renameFileToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.renameFileToolStripMenuItem.Text = "Rename";
            this.renameFileToolStripMenuItem.Click += new System.EventHandler(this.renameFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(125, 6);
            // 
            // extractFileToolStripMenuItem
            // 
            this.extractFileToolStripMenuItem.Name = "extractFileToolStripMenuItem";
            this.extractFileToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.extractFileToolStripMenuItem.Text = "Extract";
            this.extractFileToolStripMenuItem.Click += new System.EventHandler(this.extractFileToolStripMenuItem_Click);
            // 
            // ctxFileMenu2
            // 
            this.ctxFileMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctxFileMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadFileToolStripMenuItem});
            this.ctxFileMenu2.Name = "ctxMenuDirectory";
            this.ctxFileMenu2.Size = new System.Drawing.Size(113, 26);
            // 
            // uploadFileToolStripMenuItem
            // 
            this.uploadFileToolStripMenuItem.Name = "uploadFileToolStripMenuItem";
            this.uploadFileToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.uploadFileToolStripMenuItem.Text = "Upload";
            this.uploadFileToolStripMenuItem.Click += new System.EventHandler(this.uploadFileToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(209, 75);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(790, 5);
            this.materialProgressBar1.TabIndex = 8;
            // 
            // cboDrives
            // 
            this.cboDrives.Font = new System.Drawing.Font("Roboto", 10F);
            this.cboDrives.FormattingEnabled = true;
            this.cboDrives.Location = new System.Drawing.Point(115, 243);
            this.cboDrives.Name = "cboDrives";
            this.cboDrives.Size = new System.Drawing.Size(58, 25);
            this.cboDrives.TabIndex = 7;
            this.cboDrives.SelectedIndexChanged += new System.EventHandler(this.cboDrives_SelectedIndexChanged);
            // 
            // rdbAuthSSO
            // 
            this.rdbAuthSSO.AutoSize = true;
            this.rdbAuthSSO.Depth = 0;
            this.rdbAuthSSO.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbAuthSSO.Location = new System.Drawing.Point(12, 125);
            this.rdbAuthSSO.Margin = new System.Windows.Forms.Padding(0);
            this.rdbAuthSSO.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbAuthSSO.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbAuthSSO.Name = "rdbAuthSSO";
            this.rdbAuthSSO.Ripple = true;
            this.rdbAuthSSO.Size = new System.Drawing.Size(118, 30);
            this.rdbAuthSSO.TabIndex = 1;
            this.rdbAuthSSO.Text = "Single Sign On";
            this.rdbAuthSSO.UseVisualStyleBackColor = true;
            // 
            // rdbAuthBasic
            // 
            this.rdbAuthBasic.AutoSize = true;
            this.rdbAuthBasic.Checked = true;
            this.rdbAuthBasic.Depth = 0;
            this.rdbAuthBasic.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbAuthBasic.Location = new System.Drawing.Point(136, 125);
            this.rdbAuthBasic.Margin = new System.Windows.Forms.Padding(0);
            this.rdbAuthBasic.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbAuthBasic.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbAuthBasic.Name = "rdbAuthBasic";
            this.rdbAuthBasic.Ripple = true;
            this.rdbAuthBasic.Size = new System.Drawing.Size(63, 30);
            this.rdbAuthBasic.TabIndex = 2;
            this.rdbAuthBasic.TabStop = true;
            this.rdbAuthBasic.Text = "Basic";
            this.rdbAuthBasic.UseVisualStyleBackColor = true;
            // 
            // ctxDirectoryMenu
            // 
            this.ctxDirectoryMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctxDirectoryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDirectoryToolStripMenuItem});
            this.ctxDirectoryMenu.Name = "ctxDirectoryMenu";
            this.ctxDirectoryMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteDirectoryToolStripMenuItem
            // 
            this.deleteDirectoryToolStripMenuItem.Name = "deleteDirectoryToolStripMenuItem";
            this.deleteDirectoryToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteDirectoryToolStripMenuItem.Text = "Delete";
            this.deleteDirectoryToolStripMenuItem.Click += new System.EventHandler(this.deleteDirectoryToolStripMenuItem_Click);
            // 
            // btnSaveConnection
            // 
            this.btnSaveConnection.AutoSize = true;
            this.btnSaveConnection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveConnection.Depth = 0;
            this.btnSaveConnection.Icon = null;
            this.btnSaveConnection.Location = new System.Drawing.Point(12, 277);
            this.btnSaveConnection.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveConnection.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveConnection.Name = "btnSaveConnection";
            this.btnSaveConnection.Primary = false;
            this.btnSaveConnection.Size = new System.Drawing.Size(145, 36);
            this.btnSaveConnection.TabIndex = 9;
            this.btnSaveConnection.Text = "Save Connection";
            this.btnSaveConnection.UseVisualStyleBackColor = true;
            this.btnSaveConnection.Click += new System.EventHandler(this.btnSaveConnection_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 688);
            this.Controls.Add(this.btnSaveConnection);
            this.Controls.Add(this.rdbAuthBasic);
            this.Controls.Add(this.rdbAuthSSO);
            this.Controls.Add(this.cboDrives);
            this.Controls.Add(this.materialProgressBar1);
            this.Controls.Add(this.trvDirectories);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtComputerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PS Remoting Explorer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ctxFileMenu.ResumeLayout(false);
            this.ctxFileMenu2.ResumeLayout(false);
            this.ctxDirectoryMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView trvDirectories;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ContextMenuStrip ctxFileMenu;
        private System.Windows.Forms.ToolStripMenuItem downloadFileToolStripMenuItem;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComputerName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPort;
        private MaterialRaisedButton btnConnection;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private System.Windows.Forms.ContextMenuStrip ctxFileMenu2;
        private System.Windows.Forms.ToolStripMenuItem uploadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem renameFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialProgressBar materialProgressBar1;
        private System.Windows.Forms.ComboBox cboDrives;
        private MaterialRadioButton rdbAuthSSO;
        private MaterialRadioButton rdbAuthBasic;
        private System.Windows.Forms.ContextMenuStrip ctxDirectoryMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteDirectoryToolStripMenuItem;
        private MaterialFlatButton btnSaveConnection;
    }
}

