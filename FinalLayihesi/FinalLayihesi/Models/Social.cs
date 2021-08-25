using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Models
{
    public class Social
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(20), Required]
        public string Icon { get; set; }

        [MaxLength(250)]
        public string Link { get; set; }


        public List<SocialToUser> SocialToUsers { get; set; }

    }
}
