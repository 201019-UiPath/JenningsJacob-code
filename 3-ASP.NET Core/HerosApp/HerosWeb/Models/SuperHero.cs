using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HerosWeb.Models
{
    public class SuperHero 
    {
        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Real Name")]
        public string RealName { get; set; }
        [Required]
        //[StringLength(20, ErrorMessage = "Alias should be between 2-20 characters", MinimumLength = 2)]
        [RegularExpression(@"[a-zA-z]{2,30}", ErrorMessage ="Alias must be between 2-30 characters")]
        public string Alias { get; set; }
        [DataType(DataType.Text)]
        [DisplayName("Hide Out")]
        public string HideOut { get; set; }
        public List<SuperPower> SuperPowers { get; set; }
    }
}
