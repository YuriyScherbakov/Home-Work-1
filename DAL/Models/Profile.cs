using System.Collections.Generic;

namespace DAL.Models
    {
    
    public class Profile
        {

       // List<string> likes;

        public Profile ()
            {
            this.Likes = new List<Like> ();
            }

        public int Id
            {
            get; set;
            }
        public string Name
            {
            get; set;
            }

        public string KindnessOpinion
            {
            get; set;
            }
        public string AboutMe
            {
            get; set;
            }
        public ICollection<Like> Likes { get; set; }
        }
    }