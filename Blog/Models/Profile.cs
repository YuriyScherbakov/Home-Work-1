using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
    {
    
    public class Profile
        {

        List<string> likes;

        public Profile ()
            {
            this.likes = new List<string> ();
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
        public List<string> Likes
            {
            get
                {
                return this.likes;
                }
               
            }
        }
    }