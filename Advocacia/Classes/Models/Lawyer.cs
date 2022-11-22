using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Advocacia.Models
{
    public class Lawyer : Addresses
    {
        [Key]
        public long? Id { get; set; }

        [ForeignKey("Company")]
        public long Id_Company { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(6)]
        public string Registration_Number { get; set; }

        [MaxLength(2)]
        public string Sectional_Council { get; set; }

        public int Inscription_Type { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }
    }
}
