using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace demoNetCore.Models
{
    [Table("tes1s")]
    public class tes1
    {
        [Key]
        public string tes1ID { get; set; }
        public string tes1Name { get; set; }
        public ICollection<tes2> tes2s {get; set; }

    }
}