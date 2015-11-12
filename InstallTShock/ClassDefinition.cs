using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallTShock
{
    class ClassDefinition
    {
    }
    public class Connecton
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Server { get; set; }
        public Connecton(string userId, string password, string server)
        {
            UserId = userId;
            Password = password;
            Server = server;
        }

               public Connecton()
        {
            UserId = null;
            Password = null;
            Server = null;
        }
    }
    public class PluginList
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public string Author { get; set; }

        public string Version { get; set; }

        public PluginList(string name, string description, string author, string version)
        {
            Name = name;
            Description = description;
            Author = author;
            Version = version;
        }

        public PluginList()
        {
            Name = string.Empty;
            Description = string.Empty;
            Author = string.Empty;
            Version = string.Empty;
        }
    }
}
