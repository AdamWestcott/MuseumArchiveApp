using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ArchivalItem
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public byte[] ArchivalItemImage { get; set; }
        [Required]
        public string ArchivalItemReference { get; set; }
        [Required]
        public string ArchivalItemName { get; set; }

        [Required]
        public DateTime ArchivalItemCreationDate{ get; set; }
        [Required]
        public string ArchivalItemShortDescription { get; set; }
        [Required]
        public string ArchivalItemLongDescription { get; set; }
    }
}
