using System.Collections.Generic;

namespace DAL.Models
    {
   public class KeyWord
        {
            public KeyWord()
            {
                Articles = new List<Article>();
            }
            public int Id
            {
                get; set;
            }
            public string Word
            {
                get; set;
            }
            public virtual ICollection<Article> Articles
            {
                get; set;
            }
        }
    }
