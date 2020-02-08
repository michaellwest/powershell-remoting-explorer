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
            this.btnDisconnect = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConnect = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.rdbDefault = new MaterialSkin.Controls.MaterialRadioButton();
            this.ctxDirectoryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.trvDirectories.Font = new System.Drawing.Font("Roboto", 10F);
            this.trvDirectories.HideSelection = false;
            this.trvDirectories.Location = new System.Drawing.Point(12, 154);
            this.trvDirectories.Name = "trvDirectories";
            this.trvDirectories.Size = new System.Drawing.Size(312, 476);
            this.trvDirectories.TabIndex = 0;
            this.trvDirectories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDirectories_AfterSelect);
            this.trvDirectories.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trvDirectories_KeyUp);
            this.trvDirectories.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trvDirectories_MouseClick);
            // 
            // lvFiles
            // 
            this.lvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFiles.Font = new System.Drawing.Font("Roboto", 10F);
            this.lvFiles.HideSelection = false;
            this.lvFiles.Location = new System.Drawing.Point(326, 154);
            this.lvFiles.MultiSelect = false;
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(500, 476);
            this.lvFiles.TabIndex = 0;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvFiles_KeyUp);
            this.lvFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvFiles_MouseClick);
            this.lvFiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvFiles_MouseUp);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.AutoSize = true;
            this.btnDisconnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDisconnect.Depth = 0;
            this.btnDisconnect.Icon = null;
            this.btnDisconnect.Location = new System.Drawing.Point(721, 74);
            this.btnDisconnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Primary = true;
            this.btnDisconnect.Size = new System.Drawing.Size(105, 36);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.AutoSize = true;
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Depth = 0;
            this.btnConnect.Icon = null;
            this.btnConnect.Location = new System.Drawing.Point(631, 74);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Primary = true;
            this.btnConnect.Size = new System.Drawing.Size(84, 36);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "";
            this.txtPassword.Location = new System.Drawing.Point(478, 103);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(147, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Passw0rd";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Depth = 0;
            this.txtUsername.Hint = "";
            this.txtUsername.Location = new System.Drawing.Point(478, 74);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(147, 23);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TabStop = false;
            this.txtUsername.Text = "User03";
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // txtPort
            // 
            this.txtPort.Depth = 0;
            this.txtPort.Hint = "";
            this.txtPort.Location = new System.Drawing.Point(176, 74);
            this.txtPort.MaxLength = 32767;
            this.txtPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.SelectedText = "";
            this.txtPort.SelectionLength = 0;
            this.txtPort.SelectionStart = 0;
            this.txtPort.Size = new System.Drawing.Size(126, 23);
            this.txtPort.TabIndex = 2;
            this.txtPort.TabStop = false;
            this.txtPort.Text = "5985";
            this.txtPort.UseSystemPasswordChar = false;
            // 
            // txtComputerName
            // 
            this.txtComputerName.Depth = 0;
            this.txtComputerName.Hint = "";
            this.txtComputerName.Location = new System.Drawing.Point(9, 74);
            this.txtComputerName.MaxLength = 32767;
            this.txtComputerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.PasswordChar = '\0';
            this.txtComputerName.SelectedText = "";
            this.txtComputerName.SelectionLength = 0;
            this.txtComputerName.SelectionStart = 0;
            this.txtComputerName.Size = new System.Drawing.Size(161, 23);
            this.txtComputerName.TabIndex = 1;
            this.txtComputerName.TabStop = false;
            this.txtComputerName.Text = "127.0.0.1";
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
            this.materialProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(326, 143);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(500, 5);
            this.materialProgressBar1.TabIndex = 8;
            // 
            // cboDrives
            // 
            this.cboDrives.Font = new System.Drawing.Font("Roboto", 10F);
            this.cboDrives.FormattingEnabled = true;
            this.cboDrives.Location = new System.Drawing.Point(9, 103);
            this.cboDrives.Name = "cboDrives";
            this.cboDrives.Size = new System.Drawing.Size(58, 25);
            this.cboDrives.TabIndex = 11;
            this.cboDrives.SelectedIndexChanged += new System.EventHandler(this.cboDrives_SelectedIndexChanged);
            // 
            // rdbAuthSSO
            // 
            this.rdbAuthSSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbAuthSSO.AutoSize = true;
            this.rdbAuthSSO.Checked = true;
            this.rdbAuthSSO.Depth = 0;
            this.rdbAuthSSO.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbAuthSSO.Location = new System.Drawing.Point(326, 73);
            this.rdbAuthSSO.Margin = new System.Windows.Forms.Padding(0);
            this.rdbAuthSSO.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbAuthSSO.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbAuthSSO.Name = "rdbAuthSSO";
            this.rdbAuthSSO.Ripple = true;
            this.rdbAuthSSO.Size = new System.Drawing.Size(118, 30);
            this.rdbAuthSSO.TabIndex = 12;
            this.rdbAuthSSO.TabStop = true;
            this.rdbAuthSSO.Text = "Single Sign On";
            this.rdbAuthSSO.UseVisualStyleBackColor = true;
            // 
            // rdbAuthBasic
            // 
            this.rdbAuthBasic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbAuthBasic.AutoSize = true;
            this.rdbAuthBasic.Depth = 0;
            this.rdbAuthBasic.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbAuthBasic.Location = new System.Drawing.Point(326, 103);
            this.rdbAuthBasic.Margin = new System.Windows.Forms.Padding(0);
            this.rdbAuthBasic.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbAuthBasic.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbAuthBasic.Name = "rdbAuthBasic";
            this.rdbAuthBasic.Ripple = true;
            this.rdbAuthBasic.Size = new System.Drawing.Size(63, 30);
            this.rdbAuthBasic.TabIndex = 14;
            this.rdbAuthBasic.TabStop = true;
            this.rdbAuthBasic.Text = "Basic";
            this.rdbAuthBasic.UseVisualStyleBackColor = true;
            // 
            // rdbDefault
            // 
            this.rdbDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDefault.AutoSize = true;
            this.rdbDefault.Depth = 0;
            this.rdbDefault.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbDefault.Location = new System.Drawing.Point(389, 103);
            this.rdbDefault.Margin = new System.Windows.Forms.Padding(0);
            this.rdbDefault.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbDefault.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbDefault.Name = "rdbDefault";
            this.rdbDefault.Ripple = true;
            this.rdbDefault.Size = new System.Drawing.Size(73, 30);
            this.rdbDefault.TabIndex = 15;
            this.rdbDefault.TabStop = true;
            this.rdbDefault.Text = "Default";
            this.rdbDefault.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 642);
            this.Controls.Add(this.rdbDefault);
            this.Controls.Add(this.rdbAuthBasic);
            this.Controls.Add(this.rdbAuthSSO);
            this.Controls.Add(this.cboDrives);
            this.Controls.Add(this.materialProgressBar1);
            this.Controls.Add(this.trvDirectories);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
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
        private MaterialRaisedButton btnConnect;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialRaisedButton btnDisconnect;
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
        private MaterialRadioButton rdbDefault;
        private System.Windows.Forms.ContextMenuStrip ctxDirectoryMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteDirectoryToolStripMenuItem;
    }
}

