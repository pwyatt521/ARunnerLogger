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
    public class InjuryLogModel{
        public int ID { get; set; }

        [DisplayName("Injury Log Date")]
        [Required (ErrorMessage = "Date Required")]
        public DateTime Date{get; set;}

        [DisplayName("Injury Log Description")]
        [Required (ErrorMessage = "Injury Description Required")]
        public string Description{get; set;}

        [DisplayName("Pain Rating")]
        [Range(0,10)]
        [Required (ErrorMessage = "Pain Rating 0-10 Required")]
        public int Rating{get; set;}

        [DisplayName("User who posted this Injury Log")]
        [Required (ErrorMessage = "Invalid User")]
        public string PostedBy{get; set;}
    } 
}