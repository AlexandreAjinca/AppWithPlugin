using System;
using System.Collections.Generic;
using System.Text;

namespace PluginBase
{
    public class User
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return "User : " + first_name + " " + last_name + " " + email;
        }
    }
}