using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogProjesi.Models
{
    public class BlogContext:DbContext
    {
        //blogcontexte 2 tane tablomuz var ısımlerıde verdik
        //blog context adında veri tabanı olucak
        public BlogContext()
        {
            Database.SetInitializer(new Blogitializer());
        }
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
    }
}