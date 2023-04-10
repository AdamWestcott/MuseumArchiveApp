using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class KeywordTagGroupDTO
    {
        [Required]
        public string keywordTagGroupID { get; set; }
        [Required]
        public string keywordTagID { get; set; }
        [Required]
        public string ArchivalItemID { get; set; }
        [Required]
        public string keywordTagName { get; set; }
    }
}
