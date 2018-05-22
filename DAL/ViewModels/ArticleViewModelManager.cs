using System.Collections.Generic;
using DAL.Models;

namespace DAL.ViewModels
    {
    public class ArticleViewModelManager
        {
        private static List<ArticleViewModel> articlesViewModels = new List<ArticleViewModel>();

        public static IEnumerable<ArticleViewModel> GetArticlesViewModels (IEnumerable<Article> articles)
            {
            articlesViewModels.Clear ();

            foreach ( var article in articles )
                {
                ListFiller (article);
                }
            return articlesViewModels;
            }

        public static IEnumerable<ArticleViewModel> GetArticlesViewModels (Article article)
            {
            articlesViewModels.Clear ();
            ListFiller (article);
            return articlesViewModels;
            }

        static List<KeyWord> KeyWordsFiller (Article article)
            {
            var list = new List<KeyWord> ();
            list.AddRange (article.KeyWords);
            return list;
            }

        static void ListFiller (Article article)
            {
            articlesViewModels.Add (new ArticleViewModel ()
                {
                Id = article.Id,
                Name = article.Name,
                PublicationDate = article.PublicationDate,
                Text = article.Text,
                KeyWords = KeyWordsFiller (article)
                });
            }
        }
    }