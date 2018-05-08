using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
    {
    class BlogContextInitializer : DropCreateDatabaseAlways<BlogContext>
        {
            protected override void Seed (BlogContext db)
            {
                db.Articles.AddRange(ArticlesCreator.GetArticles());
                db.Reviews.AddRange(ReviewsCreator.GetReviews());
                db.Profiles.Add(new Profile());
                db.SaveChanges ();
            }
        }
    }
