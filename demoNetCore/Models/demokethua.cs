using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demoNetCore.Models
{
    public class demokethua : Person
    {
        [Display(Name = "ID ke thua")]
        public string demokethuaID { get; set; }
        
        [Display(Name = "ten ke thua")]
        public decimal demokethuatName { get; set; }
    }
}