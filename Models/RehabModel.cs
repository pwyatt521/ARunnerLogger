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
    public class RehabModel{
        public int ID { get; set; }

        [DisplayName("Rehab Name")]
        [Required(ErrorMessage="Rehab Name Required")]
        [StringLength(40)]
        public string rName;

        [DisplayName("Rehab Description")]
        [Required(ErrorMessage="Explain what this Rehab is and what it is used for")]
        public string rDescription;

        public int timesUsed;
    } 
}