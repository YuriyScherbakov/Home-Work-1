using Blog.Areas.Admin.Filters;
using System.Web.Mvc;

namespace Blog.Areas.admin.Controllers
    {
    [CustomAuthentication]
    public class AdminPanelController : Controller
        {
        public ActionResult Index ()
            {
            return View ();
            }
        }
    }