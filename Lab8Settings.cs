using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab8
{
    public class Lab8Settings
    {
        public string DatabaseConfigFile { get; set; }
        public string DefaultName { get; set; }
        public int DefaultRating { get; set; }
        public string DefaultUser {get; set; }
        public Dictionary<string, string> ConnectionStrings { get; set; }
    }
}