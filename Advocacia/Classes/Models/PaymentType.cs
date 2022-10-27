using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advocacia.Models
{
    public class PaymentType
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Description { get; set; }
    }
}
