using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250), Required]
         public string Name { get; set; }

        [MaxLength(250), Required]
         public string Surname { get; set; }

        [MaxLength(50), Required]
        public string Email { get; set; }

        [MaxLength(250), Required]
        public string UserName { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [MaxLength(250)]
        public string Password { get; set; }

        [NotMapped, MaxLength(15), Required]
        public string ConfirmPassword { get; set; }

        public DateTime AddedDate { get; set; }

        public List<Blog> Blogs { get; set; }

        public List<SocialToUser> SocialToUsers { get; set; }
    }
}
