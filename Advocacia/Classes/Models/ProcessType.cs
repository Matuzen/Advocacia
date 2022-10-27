using System;
using System.ComponentModel.DataAnnotations;

namespace Advocacia.Models
{
    public class ProcessType
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }        
    }
}
