using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSocialNetworkManager.Utilities.Log
{
    public class LogJson : ILog
    {
        public void SaveLog(string action)
        {
            string logPath = Directory.GetCurrentDirectory() + @"\Log.json";
            string currentContent = string.Empty;

            var logObjects = new List<LogObject>();

            if (File.Exists(logPath))
            {
                var streamReader = new StreamReader(logPath);
                currentContent = streamReader.ReadToEnd();
                logObjects = JsonConvert.DeserializeObject<List<LogObject>>(currentContent);
                streamReader.Close();
            }

            var streamWriter = new StreamWriter(logPath);


            var logObject = new LogObject() { LogDate = DateTime.Now, Action=action };
            logObjects.Add(logObject);

            var jsonResult = JsonConvert.SerializeObject(logObjects);

            streamWriter.WriteLine(jsonResult);
            streamWriter.WriteLine(currentContent);
            streamWriter.Close();

        }
    }
}
