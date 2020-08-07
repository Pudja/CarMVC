using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pudja.VeichleDB.Models
{
    public class VMake
    {
        [Key]
        public int MakeID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string MakeName { get; set; }
        public ICollection<VModel> Models { get; set; }
    }
}
