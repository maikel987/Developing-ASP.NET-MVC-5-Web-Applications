using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Calculation
    {
        [DisplayName("Enter Fisrt Number: ")]
        [Required(ErrorMessage = "enter a name")]
        public int FirstNumber { get; set; }

        [DisplayName("Enter Second Number: ")]
        [Required(ErrorMessage = "enter a name")]
        public int SecondNumber { get; set; }

        public int Addition()
        {
              return this.FirstNumber + this.SecondNumber; 
        }
        
    }
}