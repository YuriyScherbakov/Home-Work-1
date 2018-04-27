using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class MainController : Controller
        {
        IList<Article> articles;
        IList<Review> reviews;

        public MainController ()
            {
            this.articles = ArticlesCreator.GetArticles ();
            this.reviews = ReviewsCreator.GetReviews ();
            }

        // GET: Main
        public ActionResult Index ()
            {
            return View (this.articles);
            }
        public ActionResult GetArticle (int Id)
            {
            var articlesSingle = new List<Article> ();
            articlesSingle.Add (this.articles.Single (a => a.Id == Id));
            return View ("Index",articlesSingle);
            }
        public ActionResult GuestPage ()
            {
            return View (this.reviews);
            }
        [HttpGet]
        public ActionResult AddReview ()
            {
            return View ();
            }
        [HttpPost]
        public ActionResult AddReview (string review, string name)
            {
            if ( String.IsNullOrEmpty (review) || String.IsNullOrEmpty (name) )
                {
                return View ();
                }
            else
                {
                this.reviews.Add (new Review (this.reviews,name,review));
                return View ("GuestPage",this.reviews);
                }
            
            }


        [HttpGet]
        public ActionResult AddProfile ()
            {
            return View ();
            }
        [HttpPost]
        public ActionResult AddProfile (FormCollection formCollection)
            {
            var profile = new Profile ();

            profile.Name = formCollection ["name"];
            profile.AboutMe = formCollection ["AboutMe"];
            if ( formCollection ["Cats"].Contains("true") )
                {
                profile.Likes.Add("Кошечки");
                }
            if ( formCollection ["Birds"].Contains ("true") )
                {
                profile.Likes.Add ("Птички");
                }
            if ( formCollection ["Dogs"].Contains ("true") )
                {
                profile.Likes.Add ("Собачки");
                }

            switch ( formCollection ["Person"] )
                {
                case "Grandma": profile.KindnessOpinion = "Бабушка";
                break;
                case "Mom":
                profile.KindnessOpinion = "Мама";
                break;
                case "Dad":
                profile.KindnessOpinion = "Папа";
                break;
                }
            return View ("ShowProfile",profile);
            }


        }

    

    }