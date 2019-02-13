using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Lab8.Models
{
    public class GroupModel{
        public int ID {get; set;}
        
        [DisplayName("Group Name")]
        [Required (ErrorMessage = "Group Name Required")]
        public string Name{get; set;}

        [DisplayName("Group Description")]
        [Required (ErrorMessage = "Group Description Required")]
        public string Description{get; set;}

        [DisplayName("Group Type")]
        [Required (ErrorMessage= "Please select a group type that best fits your group")]
        public string Type {get; set;}

        public int NumberOfMembers {get; set;}

        public static readonly List<string> GroupTypes = new List<string>{
            "High School", "College", "Professional", "Casual", "Other"
        };

    } 
}