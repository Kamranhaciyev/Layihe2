﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Models
{
    public class Testimonials
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [MaxLength(3000)]
        public string Description { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
