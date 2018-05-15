
using System.Data.Entity;
using DAL.Models;

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
            public DbSet<KeyWord> KeyWords
            {
                get; set;
            }

            public BlogContext ()
                :base("BlogDBConnection")
            {
            }

        static BlogContext ()
            {
            Database.SetInitializer<BlogContext> (new BlogContextInitializer ());
            }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Article>().HasMany(k => k.KeyWords)
                    .WithMany(a => a.Articles);
            }
        }
    }
