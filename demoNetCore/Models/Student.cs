using System.Runtime.Intrinsics.X86;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demoNetCore.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int PersonID { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }


        
    }
}