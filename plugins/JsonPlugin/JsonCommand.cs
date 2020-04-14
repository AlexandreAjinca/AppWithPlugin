using PluginBase;
using System;
using Newtonsoft.Json;
using System.IO;

namespace JsonPlugin
{
    public class JsonCommand : ICommand
    {
        public string Name { get => "json"; }
        public string Description { get => "Get users from Json source"; }

        public int Execute()
        {
            string[] filePaths = Directory.GetFiles("../../../../users/");
            foreach(string s in filePaths){
                using (StreamReader r = new StreamReader(s))
                {
                    String json = r.ReadToEnd();
                    User u = JsonConvert.DeserializeObject<User>(json);
                    Console.WriteLine(u);
                }
            }
            return 0;
        }
    }
}
