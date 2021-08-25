using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Models
{
    public class SocialToUser
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("SocialId")]
        public int SocialId { get; set; }
        public Social Social { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }

        public string Link { get; set; }
    }
}
