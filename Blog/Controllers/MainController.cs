
using System.Web.Mvc;
using DAL.Models;
using DAL.Repos;
using DAL.ViewModels;

namespace Blog.Controllers
    {
    public class MainController : Controller
        {
        /// <summary>
        /// The unit of work class serves one purpose: to make sure that when you use multiple
        /// repositories, they share a single database context.
        /// </summary>
        private UnitOfWork unitOfWork = new UnitOfWork();

        public ActionResult Index ()
            {
                ViewBag.Title = "Главная";
            return View (ArticleViewModelManager.GetArticlesViewModels (this.unitOfWork.ArticleRepository.Get ()));
            }
        public ActionResult GetArticle (int Id)
            {
                ViewBag.Title = "Статья";
            return View ("Index",ArticleViewModelManager.GetArticlesViewModels (
                this.unitOfWork.ArticleRepository.GetByID (Id)));
            }
        public ActionResult GuestPage ()
            {
            return View (this.unitOfWork.ReviewRepository.Get ());
            }
        [HttpGet]
        public ActionResult AddReview ()
            {
            return View ();
            }
        [HttpPost]
        public ActionResult AddReview (Review review)
        {
           
                if (!ModelState.IsValid)
                {
                    return View ();
                }
                this.unitOfWork.ReviewRepository.Insert (new Review (this.unitOfWork
                    .ReviewRepository.Get (),review.Name,review.Text));
                this.unitOfWork.Save ();
                return View ("GuestPage",this.unitOfWork.ReviewRepository.Get ());
             
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
            if ( formCollection ["Cats"].Contains ("true") )
                {
                profile.Likes.Add (new Like () { SomeOneToLike = "Кошечки" });
                }
            if ( formCollection ["Birds"].Contains ("true") )
                {
                profile.Likes.Add (new Like () { SomeOneToLike = "Птички" });
                }
            if ( formCollection ["Dogs"].Contains ("true") )
                {
                profile.Likes.Add (new Like () { SomeOneToLike = "Собачки" });
                }

            switch ( formCollection ["Person"] )
                {
                case "Grandma":
                profile.KindnessOpinion = "Бабушка";
                break;
                case "Mom":
                profile.KindnessOpinion = "Мама";
                break;
                case "Dad":
                profile.KindnessOpinion = "Папа";
                break;
                }

            unitOfWork.ProfileRepository.Insert (profile);
            unitOfWork.Save ();

            return View ("ShowProfile",profile);
            }


        }



    }