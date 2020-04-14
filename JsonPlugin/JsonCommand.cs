using PluginBase;
using System;

namespace JsonPlugin
{
    public class JsonCommand : ICommand
    {
        public string Name { get => "Json"; }
        public string Description { get => "Get users from Json source"; }

        public int Execute()
        {
            throw new NotImplementedException();
            /*Console.WriteLine("Work in progress...");
            return 0;*/
        }
    }
}
