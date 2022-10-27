using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Advocacia.Models
{
    public class Payment
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("Payment_Types")]
        public long Id_Payment_Type { get; set; }
        public PaymentType PaymentsType { get; set; }

        [ForeignKey("Clients")]
        public long Id_Client { get; set; }
        public Client Client { get; set; }

        [Required]
        public DateTime Emission_Date { get; set; }
    }
}
