using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advocacia.Models
{
    public class Addresses
    {
        [MaxLength(9)]
        public string Address_Code { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        public int Number { get; set; }

        [MaxLength(50)]
        public string District { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(2)]
        public string State { get; set; }
    }
}
