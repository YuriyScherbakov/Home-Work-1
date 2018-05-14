using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Models;

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
