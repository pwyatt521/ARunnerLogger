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
    public class AdventureModel{


        public int ID { get; set; }

        [DisplayName("Adventure Name")]
        [Required (ErrorMessage = "Adventure Name Required")]
        public string AName{get; set;}

        [DisplayName("Adventure Description")]
        [Required (ErrorMessage = "Adventure Description Required")]
        public string ADescription{get; set;}

        [DisplayName("Adventure Rating")]
        [Range(1,7)]
        [Required (ErrorMessage = "Adventure Rating 1-7 Required")]
        public int ARating{get; set;}

        [DisplayName("User who posted this Adventure")]
        [Required (ErrorMessage = "Invalid User")]
        public string PostedBy{get; set;}
    } 
}