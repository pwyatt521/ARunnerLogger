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
    public class WorkOutModel{
        public int ID {get; set;}

        [DisplayName("Workout Name")]
        [Required (ErrorMessage = "Workout Name Required")]
        public string Name{get; set;}

        [DisplayName("Workout Description")]
        [Required (ErrorMessage = "Workout Description Required")]
        public string Description{get; set;}

        [DisplayName("Workout Difficulty")]
        [Range(1,10)]
        [Required (ErrorMessage = "Difficulty Rating 1-10 Required")]
        public int Rating{get; set;}

        [DisplayName("Workout Date")]
        [Required (ErrorMessage = "Date Required")]
        public DateTime Date{get; set;}

        [DisplayName("User who posted this Workout")]
        [Required]
        public string PostedBy{get; set;}
    } 
}