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
            this.lblComputerName = new MaterialSkin.Controls.MaterialLabel();
            this.txtComputerName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ctxMenuSelected = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuDirectory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uploadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPort = new MaterialSkin.Controls.MaterialLabel();
            this.renameFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMenuSelected.SuspendLayout();
            this.ctxMenuDirectory.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvDirectories
            // 
            this.trvDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvDirectories.HideSelection = false;
            this.trvDirectories.Location = new System.Drawing.Point(12, 154);
            this.trvDirectories.Name = "trvDirectories";
            this.trvDirectories.Size = new System.Drawing.Size(312, 476);
            this.trvDirectories.TabIndex = 0;
            this.trvDirectories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDirectories_AfterSelect);
            // 
            // lvFiles
            // 
            this.lvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "";
            this.txtPassword.Location = new System.Drawing.Point(179, 125);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(126, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Passw0rd";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Depth = 0;
            this.txtUsername.Hint = "";
            this.txtUsername.Location = new System.Drawing.Point(12, 125);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(161, 23);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TabStop = false;
            this.txtUsername.Text = "User03";
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // txtPort
            // 
            this.txtPort.Depth = 0;
            this.txtPort.Hint = "";
            this.txtPort.Location = new System.Drawing.Point(179, 96);
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
            this.txtPort.Text = "55985";
            this.txtPort.UseSystemPasswordChar = false;
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Depth = 0;
            this.lblComputerName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblComputerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblComputerName.Location = new System.Drawing.Point(8, 74);
            this.lblComputerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(119, 19);
            this.lblComputerName.TabIndex = 2;
            this.lblComputerName.Text = "Computer Name";
            // 
            // txtComputerName
            // 
            this.txtComputerName.Depth = 0;
            this.txtComputerName.Hint = "";
            this.txtComputerName.Location = new System.Drawing.Point(12, 96);
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
            // ctxMenuSelected
            // 
            this.ctxMenuSelected.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteFileToolStripMenuItem,
            this.renameFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.extractFileToolStripMenuItem});
            this.ctxMenuSelected.Name = "contextMenuStrip1";
            this.ctxMenuSelected.Size = new System.Drawing.Size(181, 126);
            // 
            // downloadFileToolStripMenuItem
            // 
            this.downloadFileToolStripMenuItem.Name = "downloadFileToolStripMenuItem";
            this.downloadFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.downloadFileToolStripMenuItem.Text = "Download file";
            this.downloadFileToolStripMenuItem.Click += new System.EventHandler(this.downloadFileToolStripMenuItem_Click);
            // 
            // deleteFileToolStripMenuItem
            // 
            this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
            this.deleteFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteFileToolStripMenuItem.Text = "Delete file";
            this.deleteFileToolStripMenuItem.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
            // 
            // extractFileToolStripMenuItem
            // 
            this.extractFileToolStripMenuItem.Name = "extractFileToolStripMenuItem";
            this.extractFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.extractFileToolStripMenuItem.Text = "Extract file";
            this.extractFileToolStripMenuItem.Click += new System.EventHandler(this.extractFileToolStripMenuItem_Click);
            // 
            // ctxMenuDirectory
            // 
            this.ctxMenuDirectory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadFileToolStripMenuItem});
            this.ctxMenuDirectory.Name = "ctxMenuDirectory";
            this.ctxMenuDirectory.Size = new System.Drawing.Size(134, 26);
            // 
            // uploadFileToolStripMenuItem
            // 
            this.uploadFileToolStripMenuItem.Name = "uploadFileToolStripMenuItem";
            this.uploadFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.uploadFileToolStripMenuItem.Text = "Upload File";
            this.uploadFileToolStripMenuItem.Click += new System.EventHandler(this.uploadFileToolStripMenuItem_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Depth = 0;
            this.lblPort.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPort.Location = new System.Drawing.Point(179, 74);
            this.lblPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(37, 19);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // renameFileToolStripMenuItem
            // 
            this.renameFileToolStripMenuItem.Name = "renameFileToolStripMenuItem";
            this.renameFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renameFileToolStripMenuItem.Text = "Rename file";
            this.renameFileToolStripMenuItem.Click += new System.EventHandler(this.renameFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 642);
            this.Controls.Add(this.trvDirectories);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblComputerName);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtComputerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PS Remoting Explorer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ctxMenuSelected.ResumeLayout(false);
            this.ctxMenuDirectory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView trvDirectories;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ContextMenuStrip ctxMenuSelected;
        private System.Windows.Forms.ToolStripMenuItem downloadFileToolStripMenuItem;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComputerName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPort;
        private MaterialRaisedButton btnConnect;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialRaisedButton btnDisconnect;
        private System.Windows.Forms.ContextMenuStrip ctxMenuDirectory;
        private System.Windows.Forms.ToolStripMenuItem uploadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractFileToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel lblComputerName;
        private MaterialLabel lblPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem renameFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

