using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class KeywordTagDTO
    {
        [Required]
        public string keywordTagID { get; set; }
        [Required]
        public string keywordTagName { get; set; }
    }
}
