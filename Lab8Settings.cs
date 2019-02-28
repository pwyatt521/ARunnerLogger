using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab8
{
    public class Lab8Settings
    {
        public string DatabaseConfigFile { get; set; }
        public string EmptyGroupName { get; set; }
        public string EmptyGroupDescription { get; set; }
        public string DefaultUser {get; set; }
        public Dictionary<string, string> ConnectionStrings { get; set; }
    }
}