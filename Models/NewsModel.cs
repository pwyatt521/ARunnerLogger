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
    public class NewsModel{
        public int ID { get; set; }

        [DisplayName("News Date")]
        [Required(ErrorMessage="News Date Required")]
        public DateTime Date {get; set;}

        [DisplayName("News Title")]
        [Required(ErrorMessage="Title required for News")]
        public string Title {get; set;}

        [DisplayName("News Message")]
        [Required(ErrorMessage="News Message")]
        public string Message {get; set;}
    } 
}