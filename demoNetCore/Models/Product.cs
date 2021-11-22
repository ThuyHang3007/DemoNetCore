using System.Runtime.Intrinsics.X86;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demoNetCore.Models
{
    [Table("Product ")]
    public class Product 
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string UnitPrice { get; set; }
        public string Quantity { get; set; }


        
    }
}