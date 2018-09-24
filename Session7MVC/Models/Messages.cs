using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Session7MVC.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }

    public class Blog
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime PostedOn { get; set; }
    }

    public class AnythingIWant : DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}