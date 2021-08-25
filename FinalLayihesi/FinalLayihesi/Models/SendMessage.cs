using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Models
{
    public class SendMessage
    {
        [Key]
        public string Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Surname { get; set; }
        [MaxLength(250)]
        public int Phone { get; set; }
        [MaxLength(3000)]
        public string Message { get; set; }
    }
}
