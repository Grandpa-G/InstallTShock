using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Terraria;
using System.Net;

namespace InstallTShock
{
    public partial class InstallMain : Form
    {
        public static string configPath;
        public static Config config = new Config();
        public static String PROGRAMNAME = "Install TShock";
        public static String PROGRAMREG = "InstallTShock";
        public static bool DEBUG = false;
        public static bool DEVELOPMENT = false;

                RemoteUtils ru = new RemoteUtils();

        public InstallMain()
        {
            InitializeComponent();

            Setup();
        }

        private void Setup()
        {
            string version;


            string[] args = Environment.GetCommandLineArgs();

            foreach (string arg in args)
            {
                if (arg.Length > 0 && arg.Equals("-d"))
                {
                    DEBUG = true;
                    Console.WriteLine("Debug Mode On.");
                }
                if (arg.Length > 0 && arg.Equals("-dev"))
                {
                    DEVELOPMENT = true;
                    Console.WriteLine("Development Mode On.");
                }

            }

            getDefaults();
            bool connected = false;
            if (ru.conn != null)
                if (ru.conn.Server != null)
                    if (ru.conn.Server.Length > 0 && ru.getToken())
                    {
                        connected = true;
                        userIcon.Visible = true;
                        userLoggedIn.Text = "Logged in as " + ru.conn.UserId + ".";
                     }

            if (!connected)
            {
                DialogResult usersChoice =
               MessageBox.Show("No server has responded.", PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPane.SelectedTab = tabLogin;
            }
            
            configPath = config.ServerLocation;
            textServerLocation.Text = configPath;
            Assembly asembly = Assembly.LoadFrom(configPath + "\\ServerPlugins\\TShockAPI.dll");

             getServerVersion();

            version = UpdateManager.GetLatestServerVersion();
           lblCurrentVersion.Text = version;

//            showVersionInfo();
            getPlugins();
        }

        private void getServerVersion()
        {
            string name = "";

            int port = 0;
            string serverVersion = "";
            string terrariaVersion = "";
            string APIversion = "";
            JObject results = ru.communicateWithTShock("VersionInfoREST/getServerVersion", "");
            string status = (string)results["status"];
            if (status.Equals("500"))
            {
                DialogResult usersChoice =
               MessageBox.Show("Connection to server has been lost.", PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPane.SelectedTab = tabLogin;
            }
            if (status.Equals("200"))
            {
                name = (string)results["name"];
                port = (int)results["port"];

                serverVersion = (string)results["tshockversion"];
                terrariaVersion = (string)results["serverversion"];
                APIversion = (string)results["APIversion"];
            }

            lblServerVersion.Text = serverVersion + "   Terraria Version: " + terrariaVersion + "       API Version: " + APIversion;
            lblServerNamevalue.Text = ru.conn.Server.Split(':')[0];
            lblPortValue.Text = port.ToString();
        }

        private void getPlugins()
        {
            JArray pluginList;
            string name = "";
            string version = "";
            string description = "";
            string author = "";
            string APIversion = "";

            JObject results = ru.communicateWithTShock("VersionInfoREST/plugins", "");
            string status = (string)results["status"];
            if (status.Equals("500"))
            {
                DialogResult usersChoice =
               MessageBox.Show("Connection to server has been lost.", PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPane.SelectedTab = tabLogin;
            }
            if (status.Equals("200"))
            {
                dataPluginVersions.Rows.Clear();
                pluginList = (JArray)results["Plugins"];
                for (int i = 0; i < pluginList.Count; i++)
                {
                    JObject innerObj = (JObject)pluginList[i];
                    name = (String)innerObj["Name"];
                    description = (String)innerObj["Description"];
                    author = (String)innerObj["Author"];
                    version = (String)innerObj["Version"];
                    dataPluginVersions.Rows.Add("", name, author, description, version, APIversion);
                }
            }
        }

        private void btnFindServerLocation_Click(object sender, EventArgs e)
        {
            folderBrowserDialogServerLocation.SelectedPath = InstallMain.config.databasePath;


            // Show the dialog and get result.
            DialogResult result = folderBrowserDialogServerLocation.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                configPath = folderBrowserDialogServerLocation.SelectedPath;
                config.ServerLocation = configPath;
                textServerLocation.Text = folderBrowserDialogServerLocation.SelectedPath;
            }

            showVersionInfo();

        }

        private void showVersionInfo()
        {
            if (configPath.Length == 0)
                return;

            Assembly asembly;
 
            //Get all the dlls that are plugins
            // Put all txt files in root directory into array.
            string[] plugins = Directory.GetFiles(configPath + "\\ServerPlugins", "*.DLL");
            string excludeDLL = "bcrypt.net.dllhttpserver.dllmono.data.sqlite.dllmysql.data.dllmysql.web.dllnewtonsoft.json.dlltshockapi.dll";

            dataPluginVersions.Rows.Clear();
            string version;
            string fileName;
            string name = "";
            Version APIversion = null;
            CustomAttributeData VersionAttribute;
            foreach (string path in plugins)
            {
                 fileName = Path.GetFileName(path).ToLower();
                if (!excludeDLL.Contains(fileName))
                {
                    Type pluginType;
                    PropertyInfo authorPropertyInfo;

                    Console.Write(fileName);
                    try
                    {
                        asembly = Assembly.LoadFrom(path);
                        string pl = asembly.FullName;
                        Console.WriteLine(pl);


                        version = "";
                        IEnumerable<TypeInfo> df = asembly.DefinedTypes;// CustomAttributes.First(Attr => Attr.AttributeType.Name == "ApiVersionAttribute");

                        pluginType = asembly.GetType(df.First().ToString());

                        VersionAttribute = asembly.GetType(df.First().ToString()).CustomAttributes.First(Attr => Attr.AttributeType.Name == "ApiVersionAttribute");
                        Console.WriteLine(df.First());
                        IEnumerable<CustomAttributeData> ca = asembly.GetType(df.First().ToString()).CustomAttributes;
                        APIversion = new Version((int)VersionAttribute.ConstructorArguments[0].Value, (int)VersionAttribute.ConstructorArguments[1].Value);
                        Console.WriteLine(ca + ":" + APIversion.ToString());

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        version = "??";
                    }
                    Console.WriteLine(version);
                    dataPluginVersions.Rows.Add(name, fileName, version.ToString(), APIversion.ToString());
                }
            }
        }

        #region Settings
        private void btnLogin_Click(object sender, EventArgs e)
        {

            ru.conn.UserId = txtUserId.Text;
            ru.conn.Password = passwordField.Text;
            ru.conn.Server = txtURL.Text;

            userIcon.Visible = false;
            userLoggedIn.Text = "Not Logged In.";
            if (txtURL.Text.Length == 0)
            {
                MessageBox.Show("Invalid userid/password/server", InstallMain.PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ru.getToken())
            {
                MessageBox.Show("Invalid userid/password/server", InstallMain.PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             userLoggedIn.Text = "Logged in as " + ru.conn.UserId + ".";

        }

        private void btnSaveDefaults_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey exampleRegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(PROGRAMREG);
            exampleRegistryKey.SetValue("UserId", txtUserId.Text);
            exampleRegistryKey.SetValue("Password", passwordField.Text);
            exampleRegistryKey.SetValue("Server", txtURL.Text);
            ru.conn.UserId = (string)exampleRegistryKey.GetValue("UserId");
            ru.conn.Password = (string)exampleRegistryKey.GetValue("Password");
            ru.conn.Server = (string)exampleRegistryKey.GetValue("Server");
            exampleRegistryKey.Close();
        }
        private void getDefaults()
        {
            Microsoft.Win32.RegistryKey exampleRegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(PROGRAMREG);
            ru.conn.UserId = (string)exampleRegistryKey.GetValue("UserId");
            ru.conn.Password = (string)exampleRegistryKey.GetValue("Password");
            ru.conn.Server = (string)exampleRegistryKey.GetValue("Server");
            txtUserId.Text = ru.conn.UserId;
            passwordField.Text = ru.conn.Password;
            txtURL.Text = ru.conn.Server;

        }
        private void btnClearDefaults_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey exampleRegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(PROGRAMREG);
            exampleRegistryKey.SetValue("UserId", "");
            exampleRegistryKey.SetValue("Password", "");
            exampleRegistryKey.SetValue("Server", "");
            ru.conn.UserId = "";
            ru.conn.Password = "";
            ru.conn.Server = "";
            txtUserId.Text = ru.conn.UserId;
            passwordField.Text = ru.conn.Password;
            txtURL.Text = ru.conn.Server;
            exampleRegistryKey.Close();

        }

        #endregion

        private void tabServerRefresh_Click(object sender, EventArgs e)
        {
            getServerVersion();
            showVersionInfo();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            saveFileDialogDownload.FileName = "tshock_release.zip";
            saveFileDialogDownload.ShowDialog();

        }
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarDownload.Value = e.ProgressPercentage;
            lblPercentComplete.Text = e.ProgressPercentage.ToString() + " Percent Complete";
        }

        void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string fileLocation = saveFileDialogDownload.FileName;
            progressBarDownload.Value = 0;
            lblPercentComplete.Text = "100 Percent Complete";
            MessageBox.Show("Download Completed to " + fileLocation, InstallMain.PROGRAMNAME, MessageBoxButtons.OK);
            lblPercentComplete.Text = "0 Percent Complete";
        }

        private void saveFileDialogDownload_FileOk(object sender, CancelEventArgs e)
        {
            // Get file name.
            string fileName = Path.GetFileName(saveFileDialogDownload.FileName);
            string remoteUri = "https://github.com/NyxStudios/TShock/releases/download/v" + lblCurrentVersion.Text + "/tshock_release.zip";

            lblPercentComplete.Text = "0 Percent Complete";
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
                wc.DownloadFileAsync(new Uri(remoteUri), saveFileDialogDownload.FileName);
            }
        }

     }
}
