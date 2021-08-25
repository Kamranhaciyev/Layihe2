using FinalLayihesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.ViewModels
{
    public class VmBlog
    {
       

       
        
        public List<TagToBlog> TagToBlogs { get; set; }
        public List<Gallery> Galleries { get; set; }


        public Blog Blog { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Blog> RecentPost { get; set; }
        public List<Categories> Categories { get; set; }
        
       
        public List<TagToBlog> Tags { get; set; }
        
        public VmBlog Filter { get; set; }
        public int? catId { get; set; }
         public List<Comment> Comment { get; set; }
       /*  public List<Blog> RecentPost { get; set; }*/
         public List<Social> Socials { get; set; }
        public List<VmDate> VmDates { get; set; }

        /* public List<Partner> Partners { get; set; }
         public List<VmDate> VmDates { get; set; }*/
    }
}
