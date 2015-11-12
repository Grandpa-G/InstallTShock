namespace InstallTShock
{
    partial class InstallMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallMain));
            this.textServerLocation = new System.Windows.Forms.TextBox();
            this.btnFindServerLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServerVersion = new System.Windows.Forms.Label();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.folderBrowserDialogServerLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPane = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblPercentComplete = new System.Windows.Forms.Label();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabServerRefresh = new System.Windows.Forms.Button();
            this.dataPluginVersions = new System.Windows.Forms.DataGridView();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnClearDefaults = new System.Windows.Forms.Button();
            this.btnSaveDefaults = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.userLoggedIn = new System.Windows.Forms.Label();
            this.lblPortValue = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.lblServerNamevalue = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.userIcon = new System.Windows.Forms.Label();
            this.saveFileDialogDownload = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PluginFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PluginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pluginAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pluginDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PluginVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PluginAPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPane.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPluginVersions)).BeginInit();
            this.tabLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textServerLocation
            // 
            this.textServerLocation.Location = new System.Drawing.Point(129, 216);
            this.textServerLocation.Name = "textServerLocation";
            this.textServerLocation.Size = new System.Drawing.Size(324, 20);
            this.textServerLocation.TabIndex = 0;
            // 
            // btnFindServerLocation
            // 
            this.btnFindServerLocation.Location = new System.Drawing.Point(472, 215);
            this.btnFindServerLocation.Name = "btnFindServerLocation";
            this.btnFindServerLocation.Size = new System.Drawing.Size(50, 23);
            this.btnFindServerLocation.TabIndex = 1;
            this.btnFindServerLocation.Text = "Browse";
            this.btnFindServerLocation.UseVisualStyleBackColor = true;
            this.btnFindServerLocation.Click += new System.EventHandler(this.btnFindServerLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Location:";
            // 
            // lblServerVersion
            // 
            this.lblServerVersion.Location = new System.Drawing.Point(185, 56);
            this.lblServerVersion.Name = "lblServerVersion";
            this.lblServerVersion.Size = new System.Drawing.Size(493, 13);
            this.lblServerVersion.TabIndex = 3;
            this.lblServerVersion.Text = "Server Version:";
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.Location = new System.Drawing.Point(185, 87);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(336, 13);
            this.lblCurrentVersion.TabIndex = 4;
            this.lblCurrentVersion.Text = "Current Version:";
            // 
            // tabPane
            // 
            this.tabPane.Controls.Add(this.tabPage1);
            this.tabPane.Controls.Add(this.tabLogin);
            this.tabPane.Location = new System.Drawing.Point(28, 161);
            this.tabPane.Name = "tabPane";
            this.tabPane.SelectedIndex = 0;
            this.tabPane.Size = new System.Drawing.Size(992, 408);
            this.tabPane.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblPercentComplete);
            this.tabPage1.Controls.Add(this.progressBarDownload);
            this.tabPage1.Controls.Add(this.btnDownload);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tabServerRefresh);
            this.tabPage1.Controls.Add(this.dataPluginVersions);
            this.tabPage1.Controls.Add(this.textServerLocation);
            this.tabPage1.Controls.Add(this.lblCurrentVersion);
            this.tabPage1.Controls.Add(this.btnFindServerLocation);
            this.tabPage1.Controls.Add(this.lblServerVersion);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Version Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.AutoSize = true;
            this.lblPercentComplete.Location = new System.Drawing.Point(776, 87);
            this.lblPercentComplete.Name = "lblPercentComplete";
            this.lblPercentComplete.Size = new System.Drawing.Size(91, 13);
            this.lblPercentComplete.TabIndex = 46;
            this.lblPercentComplete.Text = "Percent Complete";
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(614, 82);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(155, 23);
            this.progressBarDownload.TabIndex = 45;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(530, 82);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 44;
            this.btnDownload.Text = "Get Latest";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(51, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Latest Version Available:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(57, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = " Server Version:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabServerRefresh
            // 
            this.tabServerRefresh.Image = global::InstallTShock.Properties.Resources.refresh;
            this.tabServerRefresh.Location = new System.Drawing.Point(6, 6);
            this.tabServerRefresh.Name = "tabServerRefresh";
            this.tabServerRefresh.Size = new System.Drawing.Size(30, 30);
            this.tabServerRefresh.TabIndex = 41;
            this.tabServerRefresh.UseVisualStyleBackColor = true;
            this.tabServerRefresh.Click += new System.EventHandler(this.tabServerRefresh_Click);
            // 
            // dataPluginVersions
            // 
            this.dataPluginVersions.AllowUserToAddRows = false;
            this.dataPluginVersions.AllowUserToDeleteRows = false;
            this.dataPluginVersions.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataPluginVersions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPluginVersions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PluginFileName,
            this.PluginName,
            this.pluginAuthor,
            this.pluginDescription,
            this.PluginVersion,
            this.PluginAPI});
            this.dataPluginVersions.Location = new System.Drawing.Point(44, 133);
            this.dataPluginVersions.Name = "dataPluginVersions";
            this.dataPluginVersions.ReadOnly = true;
            this.dataPluginVersions.RowHeadersVisible = false;
            this.dataPluginVersions.Size = new System.Drawing.Size(698, 223);
            this.dataPluginVersions.TabIndex = 5;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.txtURL);
            this.tabLogin.Controls.Add(this.passwordField);
            this.tabLogin.Controls.Add(this.txtUserId);
            this.tabLogin.Controls.Add(this.btnClearDefaults);
            this.tabLogin.Controls.Add(this.btnSaveDefaults);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.label72);
            this.tabLogin.Controls.Add(this.label73);
            this.tabLogin.Controls.Add(this.label75);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(984, 382);
            this.tabLogin.TabIndex = 1;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // txtURL
            // 
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtURL.Location = new System.Drawing.Point(439, 144);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(213, 20);
            this.txtURL.TabIndex = 39;
            // 
            // passwordField
            // 
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordField.Location = new System.Drawing.Point(439, 118);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(100, 20);
            this.passwordField.TabIndex = 38;
            // 
            // txtUserId
            // 
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserId.Location = new System.Drawing.Point(439, 90);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 20);
            this.txtUserId.TabIndex = 37;
            // 
            // btnClearDefaults
            // 
            this.btnClearDefaults.Location = new System.Drawing.Point(462, 272);
            this.btnClearDefaults.Name = "btnClearDefaults";
            this.btnClearDefaults.Size = new System.Drawing.Size(111, 23);
            this.btnClearDefaults.TabIndex = 36;
            this.btnClearDefaults.Text = "Clear Defaults";
            this.btnClearDefaults.UseVisualStyleBackColor = true;
            this.btnClearDefaults.Click += new System.EventHandler(this.btnClearDefaults_Click);
            // 
            // btnSaveDefaults
            // 
            this.btnSaveDefaults.Location = new System.Drawing.Point(462, 220);
            this.btnSaveDefaults.Name = "btnSaveDefaults";
            this.btnSaveDefaults.Size = new System.Drawing.Size(111, 23);
            this.btnSaveDefaults.TabIndex = 35;
            this.btnSaveDefaults.Text = "Save Defaults";
            this.btnSaveDefaults.UseVisualStyleBackColor = true;
            this.btnSaveDefaults.Click += new System.EventHandler(this.btnSaveDefaults_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(577, 115);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 34;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label72
            // 
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label72.Location = new System.Drawing.Point(333, 141);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(100, 23);
            this.label72.TabIndex = 33;
            this.label72.Text = "Server:";
            this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label73
            // 
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label73.Location = new System.Drawing.Point(333, 114);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(100, 23);
            this.label73.TabIndex = 32;
            this.label73.Text = "Password:";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label75
            // 
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label75.Location = new System.Drawing.Point(333, 87);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(100, 23);
            this.label75.TabIndex = 31;
            this.label75.Text = "UserId:";
            this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userLoggedIn
            // 
            this.userLoggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoggedIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userLoggedIn.Location = new System.Drawing.Point(47, 143);
            this.userLoggedIn.Name = "userLoggedIn";
            this.userLoggedIn.Size = new System.Drawing.Size(545, 15);
            this.userLoggedIn.TabIndex = 21;
            this.userLoggedIn.Text = "Not Logged In.";
            this.userLoggedIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPortValue
            // 
            this.lblPortValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortValue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPortValue.Location = new System.Drawing.Point(680, 38);
            this.lblPortValue.Name = "lblPortValue";
            this.lblPortValue.Size = new System.Drawing.Size(67, 38);
            this.lblPortValue.TabIndex = 24;
            this.lblPortValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label70
            // 
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label70.Location = new System.Drawing.Point(611, 38);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(67, 38);
            this.label70.TabIndex = 23;
            this.label70.Text = "Port:";
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServerNamevalue
            // 
            this.lblServerNamevalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerNamevalue.Location = new System.Drawing.Point(266, 38);
            this.lblServerNamevalue.Name = "lblServerNamevalue";
            this.lblServerNamevalue.Size = new System.Drawing.Size(339, 38);
            this.lblServerNamevalue.TabIndex = 22;
            this.lblServerNamevalue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Install TShock";
            this.notifyIcon1.Visible = true;
            // 
            // userIcon
            // 
            this.userIcon.Image = global::InstallTShock.Properties.Resources.user;
            this.userIcon.Location = new System.Drawing.Point(30, 142);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(16, 16);
            this.userIcon.TabIndex = 20;
            this.userIcon.Visible = false;
            // 
            // saveFileDialogDownload
            // 
            this.saveFileDialogDownload.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogDownload_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InstallTShock.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::InstallTShock.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(32, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // PluginFileName
            // 
            this.PluginFileName.HeaderText = "File Name";
            this.PluginFileName.Name = "PluginFileName";
            this.PluginFileName.ReadOnly = true;
            this.PluginFileName.Visible = false;
            this.PluginFileName.Width = 120;
            // 
            // PluginName
            // 
            this.PluginName.HeaderText = "Plugin Name";
            this.PluginName.Name = "PluginName";
            this.PluginName.ReadOnly = true;
            this.PluginName.Width = 120;
            // 
            // pluginAuthor
            // 
            this.pluginAuthor.HeaderText = "Author";
            this.pluginAuthor.Name = "pluginAuthor";
            this.pluginAuthor.ReadOnly = true;
            // 
            // pluginDescription
            // 
            this.pluginDescription.HeaderText = "Description";
            this.pluginDescription.Name = "pluginDescription";
            this.pluginDescription.ReadOnly = true;
            this.pluginDescription.Width = 300;
            // 
            // PluginVersion
            // 
            this.PluginVersion.HeaderText = "Version";
            this.PluginVersion.Name = "PluginVersion";
            this.PluginVersion.ReadOnly = true;
            this.PluginVersion.Width = 90;
            // 
            // PluginAPI
            // 
            this.PluginAPI.HeaderText = "API";
            this.PluginAPI.Name = "PluginAPI";
            this.PluginAPI.ReadOnly = true;
            this.PluginAPI.Visible = false;
            this.PluginAPI.Width = 80;
            // 
            // InstallMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 634);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPortValue);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.lblServerNamevalue);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.userLoggedIn);
            this.Controls.Add(this.tabPane);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstallMain";
            this.Text = "Install TShock";
            this.tabPane.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPluginVersions)).EndInit();
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textServerLocation;
        private System.Windows.Forms.Button btnFindServerLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServerVersion;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogServerLocation;
        private System.Windows.Forms.TabControl tabPane;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataPluginVersions;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnClearDefaults;
        private System.Windows.Forms.Button btnSaveDefaults;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label userIcon;
        private System.Windows.Forms.Label userLoggedIn;
        private System.Windows.Forms.Label lblPortValue;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label lblServerNamevalue;
        private System.Windows.Forms.Button tabServerRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.Label lblPercentComplete;
        private System.Windows.Forms.SaveFileDialog saveFileDialogDownload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PluginFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PluginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pluginAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pluginDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn PluginVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PluginAPI;
    }
}

