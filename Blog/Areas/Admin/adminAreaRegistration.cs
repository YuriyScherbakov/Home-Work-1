using System.Web.Mvc;

namespace Blog.Areas.admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }
       
        public override void RegisterArea(AreaRegistrationContext context) 
        {

            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new {controller="AdminPanel", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}