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
    public class BookModel{


        public int ID {get; set;}
        
        [DisplayName("Book Title")]
        [Required (ErrorMessage = "Book Title Required")]
        public string BTitle{get; set;}

        [DisplayName("Book Author")]
        [Required (ErrorMessage = "Book Author Required")]
        public string BAuthor{get; set;}

        [DisplayName("Book Summary")]
        [Required (ErrorMessage = "Book Summary Required")]
        public string BSummary{get; set;}

        [DisplayName("Book Rating")]
        [Range(1,10)]
        [Required (ErrorMessage = "Rating 1-6 Required")]
        public int BRating{get; set;}

        [DisplayName("Publication Date")]
        public DateTime BDate{get; set;}

        [DisplayName("Book Length in Pages")]
        [Range(1, int.MaxValue, ErrorMessage="Book must have a positive number of pages")]
        public int BLength {get; set;}

        [DisplayName("User who posted this Book Report")]
        [Required]
        public string PostedBy{get; set;}
    } 
}