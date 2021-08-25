using FinalLayihesi.Models;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Partners> Partners { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<ProcessManagment> Processes { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<SendMessage> SendMessages { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutCard> AboutCards { get; set; }
        public DbSet<Results> Results { get; set; }
        public DbSet<ResultCards> ResultCards { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<TagToBlog> TagToBlogs{ get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<SocialToUser> SocialToUsers { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }

    }
}
