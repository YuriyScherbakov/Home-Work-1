using Blog.Models;
using System.Data.Entity;
using System.Linq;
using DAL.Models;
using DAL.Util;

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
                var articlesForEveryKeyWord = RandomNumberGenerator.GetRandomNumber (1,5);

                for ( int i = 0; i < articlesForEveryKeyWord; i++ )
                    {
                    var r = RandomNumberGenerator.GetRandomNumber (1,12);
                    keyWord.Articles.Add (db.Articles.FirstOrDefault
                    (
                        id => id.Id == r)
                    );
                    }
                }

            db.SaveChanges ();
            }
        }
    }
