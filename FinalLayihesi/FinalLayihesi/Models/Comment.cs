using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(2000)]
        public string Message { get; set; }


        [ForeignKey("BlogId")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }


        [ForeignKey("CommentId")]
        public int? CommentId { get; set; }

        public Comment ParentComment { get; set; }

        public DateTime AddedDate { get; set; }
    }
}
