using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advocacia.Models
{
    public class Company : Addresses
    {
        [Key]
        public long? Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Corporate_Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Trade_Name { get; set; }

        [Required]
        [MaxLength(18)]
        public string Cpf_Cnpj { get; set; }
    }
}