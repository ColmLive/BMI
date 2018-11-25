using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BMI.Models
{
    public enum Category
    {
                    Underweight,
                    Normal,
                    Overweight,
                    Obese
    }
    public class Person
    {
        [Display(Name="Name")]
        public string PersonName { get; set; }
        [Display(Name = "Category")]
        public Category PersonCategory {get;set;}
        [Display(Name = "Height")]
        public double PersonHeight { get; set; }
        [Display(Name = "Weight")]
        public double PersonWeight { get; set; }
        [Display(Name = "BMI")]
        public double PersonBMI { get; set; }

    }
}