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
    public class HealthModel{
        public int ID { get; set; }

        [DisplayName("Health Date")]
        [Required (ErrorMessage = "Health Date Required")]
        public string AName{get; set;}

        [DisplayName("Health Description")]
        [Required (ErrorMessage = "Health Description Required")]
        public string ADescription{get; set;}

        [DisplayName("Health Rating")]
        [Range(0,7)]
        [Required (ErrorMessage = "Health Rating 0-7 Required")]
        public int ARating{get; set;}

        [DisplayName("User who posted this Health Log")]
        [Required (ErrorMessage = "Invalid User")]
        public string PostedBy{get; set;}
    } 
}