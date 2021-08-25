using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Title { get; set; }

        [MaxLength(250)]
        public string MainImage { get; set; }

        [MaxLength(3000)]
        public string Description { get; set; }

        [MaxLength(250)]
        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Categories Categories { get; set; }

        public List<TagToBlog> TagToBlogs { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public DateTime AddedDate { get; set; }

        [NotMapped]
        public int[] TagIds { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
       

        [MaxLength(250)]
        public int? GalleryId { get; set; }

        [ForeignKey("GalleryId")]
        public Gallery Gallery { get; set; }
    }
}
