using PluginBase;
using System;

namespace UsersPlugin
{
    public class JSONPlugin : ICommand
    {
        public string Name { get => "json"; }
        public string Description { get => "Charge le liste des utilisateurs depuis un fichier JSON."; }

        public int Execute()
        {
            Console.WriteLine("Hello !!!");
            return 0;
        }
    }
}
