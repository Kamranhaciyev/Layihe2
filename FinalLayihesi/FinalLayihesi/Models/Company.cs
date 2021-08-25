using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Icon { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        [MaxLength(3000)]
        public string Description { get; set; }
    }
}
