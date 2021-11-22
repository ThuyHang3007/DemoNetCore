using System.Runtime.Intrinsics.X86;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demoNetCore.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string PersonName { get; set; }

        
    }
}