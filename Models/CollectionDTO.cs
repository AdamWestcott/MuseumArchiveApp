using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CollectionDTO
    {
        [Required]
        public string CollectionID { get; set; }
        [Required]
        public string CollectionName { get; set; }
    }
}
