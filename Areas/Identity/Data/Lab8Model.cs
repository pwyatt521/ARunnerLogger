using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Lab8.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the WebApp1User class
    public class Lab8Model : IdentityUser
    {
        public string FunFact { get; set; }
        public int Age { get; set; }
    }
}
