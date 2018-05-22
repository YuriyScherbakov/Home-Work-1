using System.Security.Principal;
using System.Threading;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Blog.Areas.Admin.Filters
    {
    public class CustomAuthenticationAttribute : FilterAttribute, IAuthenticationFilter
        {
        public void OnAuthentication (AuthenticationContext filterContext)
            {
            if ( filterContext.HttpContext.Request.Cookies ["admin"] != null
                && filterContext.HttpContext.Request.Cookies ["admin"].Value == "true" )
                {
                Thread.CurrentPrincipal = new GenericPrincipal (new GenericIdentity ("admin"),null);
                }
            else
                {
                filterContext.Result = new RedirectToRouteResult (
                            new System.Web.Routing.RouteValueDictionary {
                                    { "controller", "Account" }, { "action", "Login" }
                            });
                }
            }

        public void OnAuthenticationChallenge (AuthenticationChallengeContext filterContext)
            {

            }
        }
    }