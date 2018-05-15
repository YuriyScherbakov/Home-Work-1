using System;
using System.Collections.Generic;

namespace DAL.Models
    {
    public class Article
        {
            public Article()
            {
                KeyWords = new List<KeyWord>();
            }
        public int Id
            {
            get; set;
            }
        public string Name
            {
            get; set;
            }
        public DateTime PublicationDate
            {
            get; set;
            }

        public string Text
            {
            get; set;
            }
            public virtual ICollection<KeyWord> KeyWords
            {
                get; set;
            }
        }
    }