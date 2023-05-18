using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Collection
    {
        [Required]
        public string CollectionID { get; set; }
        [Required]
        public string CollectionName { get; set; }
    }
}
