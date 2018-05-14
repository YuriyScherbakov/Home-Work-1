using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Models;

namespace DAL.ViewModels
    {
   public class ArticleViewModel
        {
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

            public List<KeyWord> KeyWords
            {
                get; set;
            }

        public string TextPreview
            {
            get
                {
                var str = new string (Text.Take (200).ToArray ());
                return str + "...";
                }

            }
        }
    }
