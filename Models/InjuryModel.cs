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
    public class InjuryModel{


        public int ID {get; set;}
        
        [DisplayName("Injury Name")]
        [Required (ErrorMessage = "Injury Name Required")]
        public string Name{get; set;}

        [DisplayName("Injury Cause")]
        [Required (ErrorMessage = "Injury Cause Required")]
        public string InjuryCause{get; set;}

        [DisplayName("Injury Summary (Where it hurts and what hurts to do)")]
        [Required (ErrorMessage = "Injury Summary Required")]
        public string Summary{get; set;}

        [DisplayName("Injury Pain 0-10")]
        [Range(0,10)]
        [Required (ErrorMessage = "Pain 0-10 Required")]
        public int Pain{get; set;}

        [DisplayName("Injured Date")]
        public DateTime Date{get; set;}

        [DisplayName("Duration out of competition (0=Missed nothing, 3= out for a workout, 10 = out for a season or more)")]
        [Range(0, 10, ErrorMessage="Injury must have severity Level")]
        public int Length {get; set;}

        [DisplayName("User who posted this Injury Report")]
        [Required]
        public string PostedBy{get; set;}
    } 
}