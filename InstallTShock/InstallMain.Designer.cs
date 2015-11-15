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
            this.lblLocalServer = new System.Windows.Forms.Label();
            this.lblServerVersion = new System.Windows.Forms.Label();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.folderBrowserDialogServerLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPane = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLocalServer = new System.Windows.Forms.Button();
            this.lblPercentComplete = new System.Windows.Forms.Label();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.btnRemoteServer = new System.Windows.Forms.Button();
            this.lblPortValue = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabServerRefresh = new System.Windows.Forms.Button();
            this.lblServerNamevalue = new System.Windows.Forms.Label();
            this.dataPluginVersions = new System.Windows.Forms.DataGridView();
            this.PluginFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PluginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pluginAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pluginDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PluginVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PluginAPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnNewBAT = new System.Windows.Forms.Button();
            this.btnLoadBAT = new System.Windows.Forms.Button();
            this.txtBATFileName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSaveBAT = new System.Windows.Forms.Button();
            this.btnModifyBAT = new System.Windows.Forms.Button();
            this.txtBAT = new System.Windows.Forms.TextBox();
            this.txtBATFolder = new System.Windows.Forms.TextBox();
            this.btnBATLookup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.lblCommandOptionsURL = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.chkLogClear = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTShockConfigPath = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtConfigFile = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtWorldPath = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWorld = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaxPlayers = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIgnoreVersion = new System.Windows.Forms.CheckBox();
            this.userLoggedIn = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.userIcon = new System.Windows.Forms.Label();
            this.saveFileDialogDownload = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.openFileDialogBAT = new System.Windows.Forms.OpenFileDialog();
            this.tabPane.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPluginVersions)).BeginInit();
            this.tabLogin.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textServerLocation
            // 
            this.textServerLocation.Location = new System.Drawing.Point(296, 43);
            this.textServerLocation.Name = "textServerLocation";
            this.textServerLocation.Size = new System.Drawing.Size(324, 20);
            this.textServerLocation.TabIndex = 0;
            // 
            // btnFindServerLocation
            // 
            this.btnFindServerLocation.Location = new System.Drawing.Point(633, 40);
            this.btnFindServerLocation.Name = "btnFindServerLocation";
            this.btnFindServerLocation.Size = new System.Drawing.Size(50, 23);
            this.btnFindServerLocation.TabIndex = 1;
            this.btnFindServerLocation.Text = "Browse";
            this.btnFindServerLocation.UseVisualStyleBackColor = true;
            this.btnFindServerLocation.Click += new System.EventHandler(this.btnFindServerLocation_Click);
            // 
            // lblLocalServer
            // 
            this.lblLocalServer.AutoSize = true;
            this.lblLocalServer.Location = new System.Drawing.Point(184, 47);
            this.lblLocalServer.Name = "lblLocalServer";
            this.lblLocalServer.Size = new System.Drawing.Size(114, 13);
            this.lblLocalServer.TabIndex = 2;
            this.lblLocalServer.Text = "Local Server Location:";
            this.lblLocalServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServerVersion
            // 
            this.lblServerVersion.Location = new System.Drawing.Point(185, 70);
            this.lblServerVersion.Name = "lblServerVersion";
            this.lblServerVersion.Size = new System.Drawing.Size(493, 13);
            this.lblServerVersion.TabIndex = 3;
            this.lblServerVersion.Text = "Server Version:";
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.Location = new System.Drawing.Point(185, 94);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(336, 13);
            this.lblCurrentVersion.TabIndex = 4;
            this.lblCurrentVersion.Text = "Current Version:";
            // 
            // tabPane
            // 
            this.tabPane.Controls.Add(this.tabPage1);
            this.tabPane.Controls.Add(this.tabLogin);
            this.tabPane.Controls.Add(this.tabPage2);
            this.tabPane.Location = new System.Drawing.Point(28, 161);
            this.tabPane.Name = "tabPane";
            this.tabPane.SelectedIndex = 0;
            this.tabPane.Size = new System.Drawing.Size(1114, 408);
            this.tabPane.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLocalServer);
            this.tabPage1.Controls.Add(this.lblPercentComplete);
            this.tabPage1.Controls.Add(this.progressBarDownload);
            this.tabPage1.Controls.Add(this.btnRemoteServer);
            this.tabPage1.Controls.Add(this.lblPortValue);
            this.tabPage1.Controls.Add(this.btnDownload);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tabServerRefresh);
            this.tabPage1.Controls.Add(this.lblServerNamevalue);
            this.tabPage1.Controls.Add(this.dataPluginVersions);
            this.tabPage1.Controls.Add(this.textServerLocation);
            this.tabPage1.Controls.Add(this.lblCurrentVersion);
            this.tabPage1.Controls.Add(this.btnFindServerLocation);
            this.tabPage1.Controls.Add(this.lblServerVersion);
            this.tabPage1.Controls.Add(this.lblLocalServer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1106, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Version Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLocalServer
            // 
            this.btnLocalServer.Location = new System.Drawing.Point(82, 41);
            this.btnLocalServer.Name = "btnLocalServer";
            this.btnLocalServer.Size = new System.Drawing.Size(86, 23);
            this.btnLocalServer.TabIndex = 48;
            this.btnLocalServer.Text = "Local Server";
            this.btnLocalServer.UseVisualStyleBackColor = true;
            this.btnLocalServer.Click += new System.EventHandler(this.btnLocalServer_Click);
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.AutoSize = true;
            this.lblPercentComplete.Location = new System.Drawing.Point(776, 94);
            this.lblPercentComplete.Name = "lblPercentComplete";
            this.lblPercentComplete.Size = new System.Drawing.Size(91, 13);
            this.lblPercentComplete.TabIndex = 46;
            this.lblPercentComplete.Text = "Percent Complete";
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(614, 89);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(155, 23);
            this.progressBarDownload.TabIndex = 45;
            // 
            // btnRemoteServer
            // 
            this.btnRemoteServer.Location = new System.Drawing.Point(82, 13);
            this.btnRemoteServer.Name = "btnRemoteServer";
            this.btnRemoteServer.Size = new System.Drawing.Size(86, 23);
            this.btnRemoteServer.TabIndex = 47;
            this.btnRemoteServer.Text = "Remote Server";
            this.btnRemoteServer.UseVisualStyleBackColor = true;
            this.btnRemoteServer.Click += new System.EventHandler(this.btnRemoteServer_Click);
            // 
            // lblPortValue
            // 
            this.lblPortValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortValue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPortValue.Location = new System.Drawing.Point(325, 16);
            this.lblPortValue.Name = "lblPortValue";
            this.lblPortValue.Size = new System.Drawing.Size(67, 20);
            this.lblPortValue.TabIndex = 24;
            this.lblPortValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(530, 89);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 44;
            this.btnDownload.Text = "Get Latest";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(51, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Latest Version Available:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(57, 70);
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
            this.tabServerRefresh.Visible = false;
            this.tabServerRefresh.Click += new System.EventHandler(this.tabServerRefresh_Click);
            // 
            // lblServerNamevalue
            // 
            this.lblServerNamevalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerNamevalue.Location = new System.Drawing.Point(174, 16);
            this.lblServerNamevalue.Name = "lblServerNamevalue";
            this.lblServerNamevalue.Size = new System.Drawing.Size(107, 20);
            this.lblServerNamevalue.TabIndex = 22;
            this.lblServerNamevalue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dataPluginVersions.Size = new System.Drawing.Size(708, 223);
            this.dataPluginVersions.TabIndex = 5;
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
            this.PluginAPI.Width = 80;
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
            this.tabLogin.Size = new System.Drawing.Size(1106, 382);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnNewBAT);
            this.tabPage2.Controls.Add(this.btnLoadBAT);
            this.tabPage2.Controls.Add(this.txtBATFileName);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.btnSaveBAT);
            this.tabPage2.Controls.Add(this.btnModifyBAT);
            this.tabPage2.Controls.Add(this.txtBAT);
            this.tabPage2.Controls.Add(this.txtBATFolder);
            this.tabPage2.Controls.Add(this.btnBATLookup);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1106, 382);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "BAT File";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnNewBAT
            // 
            this.btnNewBAT.Location = new System.Drawing.Point(236, 76);
            this.btnNewBAT.Name = "btnNewBAT";
            this.btnNewBAT.Size = new System.Drawing.Size(50, 23);
            this.btnNewBAT.TabIndex = 26;
            this.btnNewBAT.Text = "New";
            this.btnNewBAT.UseVisualStyleBackColor = true;
            this.btnNewBAT.Click += new System.EventHandler(this.btnNewBAT_Click);
            // 
            // btnLoadBAT
            // 
            this.btnLoadBAT.Location = new System.Drawing.Point(293, 75);
            this.btnLoadBAT.Name = "btnLoadBAT";
            this.btnLoadBAT.Size = new System.Drawing.Size(50, 23);
            this.btnLoadBAT.TabIndex = 25;
            this.btnLoadBAT.Text = "Load";
            this.btnLoadBAT.UseVisualStyleBackColor = true;
            this.btnLoadBAT.Click += new System.EventHandler(this.btnLoadBAT_Click);
            // 
            // txtBATFileName
            // 
            this.txtBATFileName.Location = new System.Drawing.Point(118, 77);
            this.txtBATFileName.Name = "txtBATFileName";
            this.txtBATFileName.Size = new System.Drawing.Size(112, 20);
            this.txtBATFileName.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.Location = new System.Drawing.Point(58, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "File Name:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSaveBAT
            // 
            this.btnSaveBAT.Location = new System.Drawing.Point(406, 75);
            this.btnSaveBAT.Name = "btnSaveBAT";
            this.btnSaveBAT.Size = new System.Drawing.Size(50, 23);
            this.btnSaveBAT.TabIndex = 21;
            this.btnSaveBAT.Text = "Save";
            this.btnSaveBAT.UseVisualStyleBackColor = true;
            this.btnSaveBAT.Click += new System.EventHandler(this.btnSaveBAT_Click);
            // 
            // btnModifyBAT
            // 
            this.btnModifyBAT.Location = new System.Drawing.Point(350, 75);
            this.btnModifyBAT.Name = "btnModifyBAT";
            this.btnModifyBAT.Size = new System.Drawing.Size(50, 23);
            this.btnModifyBAT.TabIndex = 7;
            this.btnModifyBAT.Text = "Modify";
            this.btnModifyBAT.UseVisualStyleBackColor = true;
            this.btnModifyBAT.Click += new System.EventHandler(this.btnModifyBAT_Click);
            // 
            // txtBAT
            // 
            this.txtBAT.Location = new System.Drawing.Point(62, 121);
            this.txtBAT.Multiline = true;
            this.txtBAT.Name = "txtBAT";
            this.txtBAT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBAT.Size = new System.Drawing.Size(399, 226);
            this.txtBAT.TabIndex = 6;
            // 
            // txtBATFolder
            // 
            this.txtBATFolder.Location = new System.Drawing.Point(118, 45);
            this.txtBATFolder.Name = "txtBATFolder";
            this.txtBATFolder.Size = new System.Drawing.Size(267, 20);
            this.txtBATFolder.TabIndex = 3;
            // 
            // btnBATLookup
            // 
            this.btnBATLookup.Location = new System.Drawing.Point(389, 42);
            this.btnBATLookup.Name = "btnBATLookup";
            this.btnBATLookup.Size = new System.Drawing.Size(50, 23);
            this.btnBATLookup.TabIndex = 4;
            this.btnBATLookup.Text = "Browse";
            this.btnBATLookup.UseVisualStyleBackColor = true;
            this.btnBATLookup.Click += new System.EventHandler(this.btnBATLookup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Command File Folder:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.lblCommandOptionsURL);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.chkLogClear);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtLogPath);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtTShockConfigPath);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtConfigFile);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtWorldPath);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtWorld);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtMaxPlayers);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDelay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chkIgnoreVersion);
            this.panel1.Location = new System.Drawing.Point(467, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 354);
            this.panel1.TabIndex = 22;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label25.Location = new System.Drawing.Point(6, 328);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(75, 13);
            this.label25.TabIndex = 52;
            this.label25.Text = "For all options:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCommandOptionsURL
            // 
            this.lblCommandOptionsURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommandOptionsURL.Location = new System.Drawing.Point(80, 328);
            this.lblCommandOptionsURL.Name = "lblCommandOptionsURL";
            this.lblCommandOptionsURL.Size = new System.Drawing.Size(426, 13);
            this.lblCommandOptionsURL.TabIndex = 51;
            this.lblCommandOptionsURL.Text = "https://tshock.atlassian.net/wiki/display/TSHOCKPLUGINS/Command Line Parameters";
            this.lblCommandOptionsURL.Click += new System.EventHandler(this.lblCommandOptionsURL_DoubleClick);
            this.lblCommandOptionsURL.DoubleClick += new System.EventHandler(this.lblCommandOptionsURL_DoubleClick);
            // 
            // label23
            // 
            this.label23.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label23.Location = new System.Drawing.Point(205, 297);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(286, 13);
            this.label23.TabIndex = 50;
            this.label23.Text = "Overwrites old log file if it exists";
            // 
            // chkLogClear
            // 
            this.chkLogClear.AutoSize = true;
            this.chkLogClear.Location = new System.Drawing.Point(79, 295);
            this.chkLogClear.Name = "chkLogClear";
            this.chkLogClear.Size = new System.Drawing.Size(71, 17);
            this.chkLogClear.TabIndex = 49;
            this.chkLogClear.Text = "Log Clear";
            this.chkLogClear.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(205, 268);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(295, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "Overrides the default log path and saves logs here";
            // 
            // txtLogPath
            // 
            this.txtLogPath.Location = new System.Drawing.Point(80, 264);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(114, 20);
            this.txtLogPath.TabIndex = 46;
            this.txtLogPath.DoubleClick += new System.EventHandler(this.txtLogPath_DoubleClick);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label22.Location = new System.Drawing.Point(31, 268);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "Log Path";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(205, 239);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(295, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "The path tshock uses to resolve configs, log files, and sqlite db";
            // 
            // txtTShockConfigPath
            // 
            this.txtTShockConfigPath.Location = new System.Drawing.Point(80, 235);
            this.txtTShockConfigPath.Name = "txtTShockConfigPath";
            this.txtTShockConfigPath.Size = new System.Drawing.Size(114, 20);
            this.txtTShockConfigPath.TabIndex = 43;
            this.txtTShockConfigPath.DoubleClick += new System.EventHandler(this.txtConfigPath_DoubleClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label19.Location = new System.Drawing.Point(3, 239);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "TShock Config";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(205, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(295, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Starts the server with a given config file";
            // 
            // txtConfigFile
            // 
            this.txtConfigFile.Location = new System.Drawing.Point(80, 206);
            this.txtConfigFile.Name = "txtConfigFile";
            this.txtConfigFile.Size = new System.Drawing.Size(114, 20);
            this.txtConfigFile.TabIndex = 40;
            this.txtConfigFile.DoubleClick += new System.EventHandler(this.txtTShockConfig_DoubleClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label17.Location = new System.Drawing.Point(44, 210);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Config";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(205, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(295, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Starts the server and changes the world path to a given path";
            // 
            // txtWorldPath
            // 
            this.txtWorldPath.Location = new System.Drawing.Point(80, 177);
            this.txtWorldPath.Name = "txtWorldPath";
            this.txtWorldPath.Size = new System.Drawing.Size(114, 20);
            this.txtWorldPath.TabIndex = 37;
            this.txtWorldPath.DoubleClick += new System.EventHandler(this.txtWorldPath_DoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Location = new System.Drawing.Point(52, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Path";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(205, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(286, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Starts the server and immediately loads a given world file";
            // 
            // txtWorld
            // 
            this.txtWorld.Location = new System.Drawing.Point(80, 148);
            this.txtWorld.Name = "txtWorld";
            this.txtWorld.Size = new System.Drawing.Size(114, 20);
            this.txtWorld.TabIndex = 34;
            this.txtWorld.DoubleClick += new System.EventHandler(this.txtWorld_DoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(46, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "World";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(205, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(286, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Starts the server with a given player count";
            // 
            // txtMaxPlayers
            // 
            this.txtMaxPlayers.Location = new System.Drawing.Point(112, 119);
            this.txtMaxPlayers.Name = "txtMaxPlayers";
            this.txtMaxPlayers.Size = new System.Drawing.Size(38, 20);
            this.txtMaxPlayers.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(42, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Max Players";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(205, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(286, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Starts the server bound to a given port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(100, 90);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(50, 20);
            this.txtPort.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(55, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Port";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(205, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Starts the server bound to a given IPv4 address";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(80, 61);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(70, 20);
            this.txtIP.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(64, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "IP";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(205, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ignores API version checks for plugins allowing for old plugins to run.";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(161, 4);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(33, 20);
            this.txtDelay.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(61, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Batch Delay (sec):\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkIgnoreVersion
            // 
            this.chkIgnoreVersion.AutoSize = true;
            this.chkIgnoreVersion.Location = new System.Drawing.Point(56, 36);
            this.chkIgnoreVersion.Name = "chkIgnoreVersion";
            this.chkIgnoreVersion.Size = new System.Drawing.Size(94, 17);
            this.chkIgnoreVersion.TabIndex = 21;
            this.chkIgnoreVersion.Text = "Ignore Version";
            this.chkIgnoreVersion.UseVisualStyleBackColor = true;
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
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(830, 607);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(200, 23);
            this.lblVersion.TabIndex = 26;
            this.lblVersion.Text = "label1";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openFileDialogBAT
            // 
            this.openFileDialogBAT.FileName = "openFileDialogBat";
            // 
            // InstallMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 634);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pictureBox1);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textServerLocation;
        private System.Windows.Forms.Button btnFindServerLocation;
        private System.Windows.Forms.Label lblLocalServer;
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
        private System.Windows.Forms.Button btnRemoteServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PluginFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PluginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pluginAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pluginDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn PluginVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PluginAPI;
        private System.Windows.Forms.Button btnLocalServer;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialogBAT;
        private System.Windows.Forms.TextBox txtBATFolder;
        private System.Windows.Forms.Button btnBATLookup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBAT;
        private System.Windows.Forms.Button btnModifyBAT;
        private System.Windows.Forms.Button btnSaveBAT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaxPlayers;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIgnoreVersion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtConfigFile;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtWorldPath;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWorld;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTShockConfigPath;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBATFileName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnLoadBAT;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox chkLogClear;
        private System.Windows.Forms.Button btnNewBAT;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblCommandOptionsURL;
    }
}

