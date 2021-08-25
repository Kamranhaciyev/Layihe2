using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Models
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public List<Blog> Blogs { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
