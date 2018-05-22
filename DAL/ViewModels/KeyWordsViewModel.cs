using DAL.Models;

namespace DAL.ViewModels
    {
    public class KeyWordsViewModel
        {
        public Article Article
            {
            get; set;
            }
        public int Id
            {
            get; set;
            }
        public string Word
            {
            get; set;
            }
        public bool IsSelected
            {
            get; set;
            }
        }
    }
