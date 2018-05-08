using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
    {
    public class Article
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
        public string TextPreview
            {
            get {
                var str = new string (Text.Take (300).ToArray());
                return str + "...";
                }

            }
        }
    }