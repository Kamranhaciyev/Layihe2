using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Models
{
    public class Certifications
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Pretitle { get; set; }
        [MaxLength(250)]
        public string Title1 { get; set; }
        [MaxLength(250)]
        public string Title2 { get; set; }
        [MaxLength(250)]
        public string Image1 { get; set; }
        [MaxLength(250)]
        public string Image2 { get; set; }
        [MaxLength(250)]
        public string Image3 { get; set; }
        [MaxLength(250)]
        public string Image4 { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
