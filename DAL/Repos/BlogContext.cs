using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
    {
        public class BlogContext : DbContext
        {
            public DbSet<Article> Articles
            {
                get; set;
            }
            public DbSet<Profile> Profiles
            {
                get; set;
            }
            public DbSet<Review> Reviews
            {
                get; set;
            }


        static BlogContext ()
            {
            Database.SetInitializer<BlogContext> (new BlogContextInitializer ());
            }

        public BlogContext ()
                :base("BlogDBConnection")
            {
            }
        }
    }
