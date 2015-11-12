using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using TShockAPI;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace InstallTShock
{
    class UpdateManager
    {
        private static string updateUrl = "http://update.tshock.co/latest/";
        
        /// <summary>
        /// Checks to see if the server is out of date.
        /// </summary>
        /// <returns></returns>
        public static string GetLatestServerVersion()
        {
            var client = (HttpWebRequest)WebRequest.Create(updateUrl);
            client.Timeout = 5000;
            try
            {
                JObject results = GetHTTP(updateUrl);

                // this can be a string or null
                string status = (string)results["status"];

                if (results == null)
                {
                    throw new IOException("Server did not respond with an OK.");
                }

                string version = (string)results["version"];
                return version;
            }
            catch (Exception e)
            {
                Console.WriteLine("UpdateManager Exception: {0}", e);
                throw e;
            }

            return null;
        }

                public static JObject GetHTTP(string url)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ServicePoint.Expect100Continue = false; 
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
                    Stream r = response.GetResponseStream();
                    // Get the stream containing content returned by the server.
                    Stream dataStream = response.GetResponseStream();
                    // Open the stream using a StreamReader for easy access.
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.
                    string responseFromServer = reader.ReadToEnd();
                    // Parse JSON into dynamic object, convenient!
                    JObject results = JObject.Parse(responseFromServer);
                    response.Close();

                    return results;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
