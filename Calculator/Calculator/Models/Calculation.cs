using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.WebPages.Html;

namespace Calculator.Models
{
    public class Calculation
    {
        [Required]
        [Display(Name = "Operand 1")]
        public double Operand1 { get; set; }

        [Required]
        [Display(Name = "Operand 2")]
        public double Operand2 { get; set; }

    }
}
