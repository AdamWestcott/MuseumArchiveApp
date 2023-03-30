using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProvidenceDTO
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string ArchivalItemID { get; set; }

        [Required]
        public byte[] ProvidenceImage { get; set; }
        [Required]
        public string ProvidenceName { get; set; }
        [Required]
        public DateTime ProvidenceDateOfPurchase { get; set; }
        [Required]
        public double PurchaseValue { get; set; }
    }
}
