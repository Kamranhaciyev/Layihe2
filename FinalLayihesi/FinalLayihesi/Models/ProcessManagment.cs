using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Models
{
    public class ProcessManagment
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        [MaxLength(3000)]
        public string Description { get; set; }
    }
}
