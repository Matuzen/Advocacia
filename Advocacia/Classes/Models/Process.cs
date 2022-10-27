using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Advocacia.Models
{
    public class Process
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("Lawyers")]
        public long Id_Lawyer { get; set; }
        public Lawyer Lawyers { get; set; }

        [ForeignKey("Clients")]
        public long Id_Client { get; set; }
        public Client Clients { get; set; }

        [ForeignKey("Process_Type")]
        public long Id_Process_Type { get; set; }
        public ProcessType ProcessType { get; set; }

        public DateTime Process_Date { get; set; }

        [MaxLength(550)]
        public string Description { get; set; }

        public int Status { get; set; }

        public DateTime Modify_Date { get; set; }
    }
}
