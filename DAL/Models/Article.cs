using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAL.Models
    {
    public class Article : IArticle
        {
        public Article ()
            {
            KeyWords = new List<KeyWord> ();
            }
        public int Id
            {
            get; set;
            }
        [Display (Name = "Название статьи")]
        [Required (ErrorMessage = "Не указано название статьи")]
        public string Name
            {
            get; set;
            }
        public DateTime PublicationDate
            {
            get; set;
            }
        [Display (Name = "Содержание статьи")]
        [Required (ErrorMessage = "Статья пустая")]
        [MinLength (6,ErrorMessage = "Хотя бы два три слова")]
        public string Text
            {
            get; set;
            }
        public virtual ICollection<KeyWord> KeyWords
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