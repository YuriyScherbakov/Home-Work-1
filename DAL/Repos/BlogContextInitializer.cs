using System.Data.Entity;
using System.Linq;
using DAL.Models;

namespace DAL.Repos
    {
    class BlogContextInitializer : DropCreateDatabaseAlways<BlogContext>
        {
        protected override void Seed (BlogContext db)
            {
            db.Articles.AddRange (ArticlesCreator.GetArticles ());
            db.Reviews.AddRange (ReviewsCreator.GetReviews ());
            db.Profiles.Add (new Profile ());
            db.KeyWords.AddRange (KeyWordsCreator.GetKeyWords ());
            db.SaveChanges ();
            foreach ( var keyWord in db.KeyWords.ToList () )
                {
                keyWord.Articles = db.Articles.ToList ().FindAll (
                    m => m.Text.ToLower ().Contains (keyWord.Word.ToLower ()));
                }
            db.SaveChanges ();
            }
        }
    }
