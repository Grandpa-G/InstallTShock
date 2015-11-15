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

        private string latestVersion = "";
        private void Setup()
        {
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

            configPath = config.ServerLocation;
            textServerLocation.Text = configPath;
            txtBATFolder.Text = configPath;
            txtBATFileName.Text = "TShock.bat";

            latestVersion = UpdateManager.GetLatestServerVersion();
            lblCurrentVersion.Text = latestVersion;

            lblVersion.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            txtDelay.Text = "5";
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
            lblServerNamevalue.Text = ru.conn.Server.Split(':')[0] + ":" + port.ToString();
            //            lblPortValue.Text = port.ToString();
        }

        private void getLocalPlugins()
        {
            if (configPath.Length == 0)
                return;

            Assembly asembly;
            string version = "";
            string fileName;
            string name = "";
            string author = "";
            string description = "";
            Version APIversion = new Version(0, 0, 0, 0);
            CustomAttributeData VersionAttribute;

            asembly = Assembly.LoadFrom(configPath + "\\TerrariaServer.exe");
            string terrariaVersion = asembly.GetName().Version.ToString();

            asembly = Assembly.LoadFrom(configPath + "\\ServerPlugins\\TShockAPI.dll");
            string serverVersion = asembly.GetName().Version.ToString();
            string s;
            Type pluginType;
            PropertyInfo numberPropertyInfo;
            try
            {
                IEnumerable<TypeInfo> df = asembly.DefinedTypes;
                System.Attribute[] attrs = System.Attribute.GetCustomAttributes(df.First(Attr => Attr.Name == "TShock"));
                VersionAttribute = asembly.GetType(df.First(Attr => Attr.Name == "TShock").ToString()).CustomAttributes.First(Attr => Attr.AttributeType.Name == "ApiVersionAttribute");
                APIversion = new Version((int)VersionAttribute.ConstructorArguments[0].Value, (int)VersionAttribute.ConstructorArguments[1].Value);
                /*
                                 s = df.First(Attr => Attr.Name == "TShock").ToString();
                                 pluginType = asembly.GetType(df.First(Attr => Attr.Name == "TShock").ToString());

                               numberPropertyInfo = pluginType.GetProperty("Author");
                               var piValue = numberPropertyInfo.GetValue(null, null);

                               string v = (string)pluginType.InvokeMember("get_Version", BindingFlags.InvokeMethod | BindingFlags.Static | BindingFlags.Public, null, null, null);

                              Console.WriteLine(s);
                              Console.WriteLine(numberPropertyInfo);
                              Console.WriteLine(piValue);
                */
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            lblServerVersion.Text = serverVersion + "   Terraria Version: " + terrariaVersion + "       API Version: " + APIversion;


            //Get all the dlls that are plugins
            // Put all txt files in root directory into array.
            string[] plugins = Directory.GetFiles(configPath + "\\ServerPlugins", "*.DLL");
            string excludeDLL = "bcrypt.net.dllhttpserver.dllmono.data.sqlite.dllmysql.data.dllmysql.web.dllnewtonsoft.json.dlltshockapi.dll";

            dataPluginVersions.Rows.Clear();
            foreach (string path in plugins)
            {
                fileName = Path.GetFileName(path);
                if (!excludeDLL.Contains(fileName.ToLower()))
                {
                    PropertyInfo authorPropertyInfo;
                    try
                    {
                        /*
                        asembly = Assembly.LoadFrom(path);
                        IEnumerable<TypeInfo> df = asembly.DefinedTypes;
                        s = df.First().ToString();
                        s = "inventoryRESTApi.SSCInventory";
                        pluginType = asembly.GetType(df.First().ToString());

                        numberPropertyInfo = pluginType.GetProperty("Description");
                        var piValue = numberPropertyInfo.GetValue(null, null);

                        string v = (string)pluginType.InvokeMember("get_Version", BindingFlags.InvokeMethod | BindingFlags.Static | BindingFlags.Public, null, null, null);

                        Console.WriteLine(s);
                        Console.WriteLine(numberPropertyInfo);
                        Console.WriteLine(piValue);
                        */
                        try
                        {
                            //                          IEnumerable<CustomAttributeData> x = asembly.GetCustomAttributesData();
                            version = asembly.GetName().Version.ToString();
                        }
                        catch
                        {
                            version = "??";
                        }
                        try
                        {
                            IEnumerable<TypeInfo> df = asembly.DefinedTypes;// CustomAttributes.First(Attr => Attr.AttributeType.Name == "ApiVersionAttribute");
                            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(df.First());
                            VersionAttribute = asembly.GetType(df.First().ToString()).CustomAttributes.First(Attr => Attr.AttributeType.Name == "ApiVersionAttribute");
                            APIversion = new Version((int)VersionAttribute.ConstructorArguments[0].Value, (int)VersionAttribute.ConstructorArguments[1].Value);
                        }
                        catch (Exception ex)
                        {
//                            Console.WriteLine(ex.StackTrace);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                    }
                    dataPluginVersions.Rows.Add(name, fileName, author, description, version, APIversion.ToString());

                }
            }
        }
        private void getRemotePlugins()
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

                getLocalPlugins();
            }
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

                    try
                    {
                        asembly = Assembly.LoadFrom(path);
                        //                        string pl = asembly.FullName;
                        //                       Console.WriteLine(pl);
                        //                       Assembly assembly = Assembly.Load(File.ReadAllBytes(path));

                        string filename = path;
                        AppDomain app2 = AppDomain.CreateDomain("Resolver");

                        AppDomain.Unload(app2);

                        version = "";
                        CustomAttributeData df = asembly.CustomAttributes.First(Attr => Attr.AttributeType.Name == "ApiVersionAttribute");

                        pluginType = asembly.GetType("TerrariaApi.Server.TerrariaPlugin");
                        object pluginInstance = Activator.CreateInstance(pluginType);
                        //                      Console.WriteLine(pluginInstance);
                        //                        VersionAttribute = asembly.GetType(df.First().ToString()).CustomAttributes.First(Attr => Attr.AttributeType.Name == "ApiVersionAttribute");
                        //                        Console.WriteLine(df.First());
                        //                        IEnumerable<CustomAttributeData> ca = asembly.GetType(df.First().ToString()).CustomAttributes;
                        //                        APIversion = new Version((int)VersionAttribute.ConstructorArguments[0].Value, (int)VersionAttribute.ConstructorArguments[1].Value);
                        //                        Console.WriteLine(ca + ":" + APIversion.ToString());

                    }
                    catch (ReflectionTypeLoadException ex)
                    {
                        foreach (Exception inner in ex.LoaderExceptions)
                        {
                            Console.WriteLine(inner.Message);
                        }

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

        private void btnRemoteServer_Click(object sender, EventArgs e)
        {
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

            textServerLocation.Visible = false;
            btnFindServerLocation.Visible = false;
            lblLocalServer.Visible = false;
            getServerVersion();

            getRemotePlugins();
        }

        private void btnLocalServer_Click(object sender, EventArgs e)
        {
            textServerLocation.Visible = true;
            btnFindServerLocation.Visible = true;
            lblLocalServer.Visible = true;
            lblServerVersion.Text = "";
            lblServerNamevalue.Text = "";

            getLocalPlugins();

        }

        private void btnBATLookup_Click(object sender, EventArgs e)
        {
            folderBrowserDialogServerLocation.SelectedPath = txtBATFolder.Text;
            // Show the dialog and get result.
            DialogResult result = folderBrowserDialogServerLocation.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtBATFolder.Text = folderBrowserDialogServerLocation.SelectedPath;
            }
        }

        private void btnModifyBAT_Click(object sender, EventArgs e)
        {
            string batFile = InstallTShock.Properties.Resources.TShock;
            string driveLetter = "";
            string delay = "";

            if (txtBATFolder.Text.Length == 0)
            {
                MessageBox.Show("No location specified.", PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtDelay.Text.Length == 0)
                delay = "";
            else
                delay = txtDelay.Text;

            if (txtBATFolder.Text.Length == 0)
                driveLetter = "C:";
            else
                driveLetter = txtBATFolder.Text.Substring(0, 2);

            string folder = txtBATFolder.Text;

            string commandLine = "";
            if (chkIgnoreVersion.Checked)
                commandLine += " -ignoreversion";
            if (txtIP.Text.Length > 0)
                commandLine += " -ip " + txtIP.Text;
            if (txtPort.Text.Length > 0)
                commandLine += " -port " + txtPort.Text;
            if (txtMaxPlayers.Text.Length > 0)
                commandLine += " -maxplayers " + txtMaxPlayers.Text;

            if (txtWorld.Text.Length > 0)
                commandLine += " -world " + txtWorld.Text;
            if (txtWorldPath.Text.Length > 0)
                commandLine += " -worldpath \"" + txtWorldPath.Text + "\"";
            if (txtConfigFile.Text.Length > 0)
                commandLine += " -config \"" + txtConfigFile.Text + "\"";

            if (txtTShockConfigPath.Text.Length > 0)
                commandLine += " -configpath \"" + txtTShockConfigPath.Text + "\"";
            if (chkLogClear.Checked)
                commandLine += " -logclear";

            bool timeoutFound = false;
            bool commandFound = false;
            string[] commandFile = txtBAT.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            txtBAT.Text = "";
            for (int i = 0; i < commandFile.Length; i++)
            {
                if (commandFile[i].ToLower().Contains("terrariaserver.exe"))
                {
                    commandFound = true;
                    string[] commandLineArgs = commandFile[i].Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                    commandFile[i] = commandLineArgs[0] + " " + commandLine;
                }

                if (commandFile[i].ToLower().Contains("timeout"))
                {
                    string[] commandLineArgs = commandFile[i].Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                    if (delay.Length > 0) {
                        timeoutFound = true;
                        commandFile[i] = commandLineArgs[0] + " /t " + delay;
                    }
                    else
                        commandFile[i] = "";
                }
                if (commandFile[i].ToLower().Contains("echo waiting"))
                {
                    string[] commandLineArgs = commandFile[i].Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                    if (delay.Length > 0)
                        commandFile[i] = "echo Waiting " + delay + " seconds - CTRL-C to get out";
                    else
                        commandFile[i] = "";
                }
                txtBAT.Text += commandFile[i] + "\r\n";
            }
            if(delay.Length > 0 && !timeoutFound)
                MessageBox.Show("No timeout command in file.", PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!commandFound)
                MessageBox.Show("No TerrariServer.exe command in file.", PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSaveBAT_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.WriteAllText(txtBATFolder.Text + "\\" + txtBATFileName.Text, txtBAT.Text);
                MessageBox.Show("Batch file saved to " + txtBATFolder.Text + "\\" + txtBATFileName.Text, PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Save failed.", PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtWorld_DoubleClick(object sender, EventArgs e)
        {
            openFileDialogBAT.InitialDirectory = txtBATFolder.Text + "\\Worlds";
            openFileDialogBAT.Filter = "wld files (*.wld)|*.wld|All files (*.*)|*.*";
            openFileDialogBAT.FileName = "Master.wld";
            // Show the dialog and get result.
            DialogResult result = openFileDialogBAT.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtWorld.Text = openFileDialogBAT.FileName;
            }
        }

        private void txtWorldPath_DoubleClick(object sender, EventArgs e)
        {
            folderBrowserDialogServerLocation.SelectedPath = txtBATFolder.Text + "\\Worlds";
            // Show the dialog and get result.
            DialogResult result = folderBrowserDialogServerLocation.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtWorldPath.Text = folderBrowserDialogServerLocation.SelectedPath;
            }
        }

        private void txtConfigPath_DoubleClick(object sender, EventArgs e)
        {
            folderBrowserDialogServerLocation.SelectedPath = txtBATFolder.Text + "\\ServerPlugins";
            // Show the dialog and get result.
            DialogResult result = folderBrowserDialogServerLocation.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtTShockConfigPath.Text = folderBrowserDialogServerLocation.SelectedPath;
            }
        }

        private void txtConfig_DoubleClick(object sender, EventArgs e)
        {
            openFileDialogBAT.InitialDirectory = txtBATFolder.Text;
            openFileDialogBAT.FileName = "config.txt";
            // Show the dialog and get result.
            DialogResult result = openFileDialogBAT.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtConfigFile.Text = openFileDialogBAT.FileName;
            }
        }

        private void txtTShockConfig_DoubleClick(object sender, EventArgs e)
        {
            openFileDialogBAT.InitialDirectory = txtBATFolder.Text;
            openFileDialogBAT.FileName = "TShockserverconfig.txt";
            // Show the dialog and get result.
            DialogResult result = openFileDialogBAT.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtConfigFile.Text = openFileDialogBAT.FileName;
            }
        }

        private void btnLoadBAT_Click(object sender, EventArgs e)
        {
            try
            {
                txtBAT.Text = File.ReadAllText(txtBATFolder.Text + "\\" + txtBATFileName.Text);
                parseCommandLine();
            }
            catch
            {
                MessageBox.Show("File " + txtBATFolder.Text + "\\" + txtBATFileName.Text + " could not be found.", PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLogPath_DoubleClick(object sender, EventArgs e)
        {
            folderBrowserDialogServerLocation.SelectedPath = txtBATFolder.Text + "\\ServerPlugins";
            // Show the dialog and get result.
            DialogResult result = folderBrowserDialogServerLocation.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtLogPath.Text = folderBrowserDialogServerLocation.SelectedPath;
            }
        }

        private void btnNewBAT_Click(object sender, EventArgs e)
        {
            initBATFile();
            newBATFile();
        }

        private void newBATFile()
        {
            string batFile = InstallTShock.Properties.Resources.TShock;
            string driveLetter = "";
            string delay = "";

            if (txtBATFolder.Text.Length == 0)
            {
                MessageBox.Show("No location specified.", PROGRAMNAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (delay.Length == 0)
                delay = "5";
            else
                delay = txtDelay.Text;

            if (txtBATFolder.Text.Length == 0)
                driveLetter = "C:";
            else
                driveLetter = txtBATFolder.Text.Substring(0, 2);

            string folder = txtBATFolder.Text;

            string commandLine = "";
            if (chkIgnoreVersion.Checked)
                commandLine += " -ignoreversion";
            if (txtIP.Text.Length > 0)
                commandLine += " -ip " + txtIP.Text;
            if (txtPort.Text.Length > 0)
                commandLine += " -port " + txtPort.Text;
            if (txtMaxPlayers.Text.Length > 0)
                commandLine += " -maxplayers " + txtMaxPlayers.Text;

            if (txtWorld.Text.Length > 0)
                commandLine += " -world " + txtWorld.Text;
            if (txtWorldPath.Text.Length > 0)
                commandLine += " -worldpath \"" + txtWorldPath.Text + "\"";
            if (txtConfigFile.Text.Length > 0)
                commandLine += " -config \"" + txtConfigFile.Text + "\"";

            if (txtTShockConfigPath.Text.Length > 0)
                commandLine += " -configpath \"" + txtTShockConfigPath.Text + "\"";
            if (chkLogClear.Checked)
                commandLine += " -logclear";
            commandLine += "\r\n";

            batFile = batFile.Replace("`delay", delay);
            batFile = batFile.Replace("`drive", driveLetter);
            batFile = batFile.Replace("`folder", folder);
            batFile = batFile.Replace("`commandline", commandLine);

            txtBAT.Text = batFile;
        }

        private void parseCommandLine()
        {
            initBATFile();
            string[] argument;

            string[] commandFile = txtBAT.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            for (int i = 0; i < commandFile.Length; i++)
            {
                if (commandFile[i].ToLower().Contains("terrariaserver.exe"))
                {
                    string[] commandLineArgs = commandFile[i].Split('-');
                    for (int j = 0; j < commandLineArgs.Length; j++)
                    {
                        argument = commandLineArgs[j].Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                        if (argument.Length > 1)
                            argument[1] = argument[1].Replace("\"", "");
                        switch (argument[0].ToLower())
                        {
                            case "ignoreversion":
                                {
                                    chkIgnoreVersion.Checked = true;
                                    break;
                                }
                            case "maxplayers":
                                {
                                    txtMaxPlayers.Text = argument[1];
                                    break;
                                }
                            case "ip":
                                {
                                    txtIP.Text = argument[1];
                                    break;
                                }
                            case "port":
                                {
                                    txtPort.Text = argument[1];
                                    break;
                                }
                            case "world":
                                {
                                    txtWorld.Text = argument[1];
                                    break;
                                }
                            case "worldpath":
                                {
                                    txtWorldPath.Text = argument[1];
                                    break;
                                }
                            case "config":
                                {
                                    txtConfigFile.Text = argument[1];
                                    break;
                                }
                            case "configpath":
                                {
                                    txtTShockConfigPath.Text = argument[1];
                                    break;
                                }
                            case "logpath":
                                {
                                    txtLogPath.Text = argument[1];
                                    break;
                                }
                            case "logclear":
                                {
                                    chkLogClear.Checked = true;
                                    break;
                                }
                        }
                    }
                }
            }
        }

        private void initBATFile()
        {
            chkIgnoreVersion.Checked = false;
            txtMaxPlayers.Text = "";
            txtIP.Text = "";
            txtPort.Text = "";
            txtWorld.Text = "";
            txtWorldPath.Text = "";
            txtConfigFile.Text = "";
            txtTShockConfigPath.Text = "";
            txtLogPath.Text = "";
            chkLogClear.Checked = false;
        }

        private void lblCommandOptionsURL_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lblCommandOptionsURL.Text);
        }

    }
}
