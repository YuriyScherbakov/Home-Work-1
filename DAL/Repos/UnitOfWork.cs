using System;
using DAL.Models;

namespace DAL.Repos
    {
        public class UnitOfWork : IDisposable
        {
            private BlogContext context = new BlogContext();

            private GenericRepository<Article> articleRepository;
            private GenericRepository<Profile> profileRepository;
            private GenericRepository<Review> reviewRepository;
            private GenericRepository<KeyWord> keyWordRepository;


        public GenericRepository<KeyWord> KeyWordRepository
            {
            get
            {
                if ( this.keyWordRepository == null )
                {
                    this.keyWordRepository = new GenericRepository<KeyWord> (context);
                }
                return keyWordRepository;
            }
        }

        public GenericRepository<Article> ArticleRepository
            {
                get
                {

                    if ( this.articleRepository == null )
                    {
                        this.articleRepository = new GenericRepository<Article> (context);
                    }
                    return articleRepository;
                }
            }

            public GenericRepository<Profile> ProfileRepository
            {
                get
                {

                    if ( this.profileRepository == null )
                    {
                        this.profileRepository = new GenericRepository<Profile> (context);
                    }
                    return profileRepository;
                }
            }

            public GenericRepository<Review> ReviewRepository
            {
                get
                {

                    if ( this.reviewRepository == null )
                    {
                        this.reviewRepository = new GenericRepository<Review> (context);
                    }
                    return reviewRepository;
                }
            }


        public void Save ()
            {
                context.SaveChanges ();
            }

            private bool disposed = false;

            protected virtual void Dispose (bool disposing)
            {
                if ( !this.disposed )
                {
                    if ( disposing )
                    {
                        context.Dispose ();
                    }
                }
                this.disposed = true;
            }

            public void Dispose ()
            {
                Dispose (true);
                GC.SuppressFinalize (this);
            }
        }
    }
