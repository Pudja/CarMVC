using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pudja.VeichleDB.Models
{
    public class VModel
    {
        [Key]
        public int ModelID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string ModelName { get; set; }
        
        public int MakeID { get; set; }
        public VMake Make { get; set; }
    }
}
