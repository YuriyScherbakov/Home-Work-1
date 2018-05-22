using System.Collections.Generic;
using DAL.Models;

namespace DAL.ViewModels
    {
    public class KeyWordsViewModelManager
        {
        private static List<KeyWordsViewModel> keyWordsViewModel = new List<KeyWordsViewModel>();

        public static IEnumerable<KeyWordsViewModel> GetKeyWordsViewModels (Article article,IEnumerable<KeyWord> keyWords)
            {
            keyWordsViewModel.Clear ();

            foreach ( var keyWord in keyWords )
                {
                if ( article.KeyWords.Contains (keyWord) )
                    {
                    keyWordsViewModel.Add (new KeyWordsViewModel () { Article = article,Id = keyWord.Id,IsSelected = true,Word = keyWord.Word });
                    }
                else
                    {
                    keyWordsViewModel.Add (new KeyWordsViewModel () { Article = article,Id = keyWord.Id,IsSelected = false,Word = keyWord.Word });
                    }
                }
            return keyWordsViewModel;
            }
        }
    }
