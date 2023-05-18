using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ProvenanceRecord
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string ProvidenceID { get; set; }
        [Required]
        public byte[] ProvenanceRecordImage { get; set; }
        [Required]
        public string ProvenanceName { get; set; }
        [Required]
        public string ProvenanceLocationOfPurchase { get; set; }
        [Required]
        public string ProvenanceNotes { get; set; }
        [Required]
        public string ProvenanceDescription { get; set; }
        [Required]
        public int ProvenanceNumberOfPriorOwners { get; set; }
        [Required]
        public DateTime ProvenanceDateOfPurchase { get; set; }
        [Required]
        public double PurchaseValue { get; set; }
    }
}
