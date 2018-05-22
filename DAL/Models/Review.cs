using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAL.Models
    {
    public class Review
        {
        public Review ()
            {
            }
        public Review (IEnumerable<Review> reviews,string name,string text)
            {
            var ID = reviews.Max (id => id.Id);
            ID++;
            this.Id = ID;
            this.Name = name;
            this.Text = text;
            this.PublicationDate = DateTime.Now;
            }
        public int Id
            {
            get; set;
            }
        [Required]
        public string Name
            {
            get; set;
            }
        public DateTime PublicationDate
            {
            get; set;
            }
        public string PublicationDateToShortDateString => PublicationDate.ToShortDateString ();

        [Required (ErrorMessage = "Напишите нам что-то")]
        [MinLength (6,ErrorMessage = "Хотя бы два три слова")]
        public string Text
            {
            get; set;
            }
        }
    }