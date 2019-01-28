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
        public string BTitle{get; set;}

        [DisplayName("Injury Cause")]
        [Required (ErrorMessage = "Injury Cause Required")]
        public string BAuthor{get; set;}

        [DisplayName("Injury Summary (Where it hurts and what hurts to do)")]
        [Required (ErrorMessage = "Book Summary Required")]
        public string BSummary{get; set;}

        [DisplayName("Pain Rating")]
        [Range(1,10)]
        [Required (ErrorMessage = "Rating 1-10 Required")]
        public int BRating{get; set;}

        [DisplayName("Injured Date")]
        public DateTime BDate{get; set;}

        [DisplayName("Duration out of Competition (1= out for a workout, 10 = out for more than a year")]
        [Range(1, 10, ErrorMessage="Injury Must have severity Level")]
        public int BLength {get; set;}

        [DisplayName("User who posted this Injury Report")]
        [Required]
        public string PostedBy{get; set;}
    } 
}