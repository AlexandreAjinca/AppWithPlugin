using PluginBase;
using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace JsonPlugin
{
    public class JsonCommand : ICommand
    {
        public string Name { get => "json"; }
        public string Description { get => "Get users from Json source"; }

        public List<User> getUsers()
        {
            List<User> result = new List<User>();
            string[] filePaths = Directory.GetFiles("../../../../users/");
            foreach(string s in filePaths){
                using (StreamReader r = new StreamReader(s))
                {
                    String json = r.ReadToEnd();
                    User u = JsonConvert.DeserializeObject<User>(json);
                    result.Add(u);
                }
            }
            foreach(User user in result)
            {
                Console.WriteLine(user);
            }
            return result;
        }
    }
}
