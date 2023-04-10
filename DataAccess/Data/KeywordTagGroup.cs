using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class KeywordTagGroup
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
