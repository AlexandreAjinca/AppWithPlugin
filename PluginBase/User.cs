using System;
using System.Collections.Generic;
using System.Text;

namespace PluginBase
{
    public interface User
    {
        string id { get; }
        string first_name { get; }
        string last_name { get; }
        string email { get; }

        void AddUser();
    }
}