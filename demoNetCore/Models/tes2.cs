using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demoNetCore.Models
{
    [Table("tes2s")]
    public class tes2
    {
        [Key]
        public string ProducttID { get; set; }
        public string ProducttName { get; set; }
        public string UnitPrice { get; set; }
        public string Quantity { get; set; }
         public string tes1ID { get; set; }
        public tes1 tes1 { get; set; }
    }
}