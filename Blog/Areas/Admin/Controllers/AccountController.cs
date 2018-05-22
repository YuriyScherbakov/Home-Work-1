using System.Web;
using System.Web.Mvc;
using Blog.Areas.admin.Models;

namespace Blog.Areas.Admin.Controllers
    {
    public class AccountController : Controller
        {
        public ActionResult Login ()
            {
            return View ();
            }
        [HttpPost]
        public ActionResult Login (User user)
            {
            if ( ModelState.IsValid )
                {
                if ( user.UserName == "1" && user.Password == "1" )
                    {
                    this.Response.Cookies.Add (new HttpCookie ("admin","true"));
                    return RedirectToAction ("Index","AdminPanel");
                    }
                else
                    {
                    ViewBag.Message = "У Вас нет прав доступа к админ панели.";
                    }
                }
            return View ();
            }
        public ActionResult Logout ()
            {
            HttpCookie cookie = new HttpCookie ("admin","false");
            Response.Cookies.Add (cookie);
            return RedirectToAction ("Index","Main",new
                {
                area = ""
                });
            }
        }
    }