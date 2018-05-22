using System.Collections.Generic;
using System.Web.Mvc;
using DAL.Models;

namespace Blog.Helpers
    {
    public static class ProfileHelper
        {
        public static MvcHtmlString CreateProfileHelper (this HtmlHelper html,IEnumerable<Like> options, string type)
            {
            TagBuilder ul = new TagBuilder (type);

            foreach ( var item in options )
                {
                TagBuilder li = new TagBuilder ("li");
               
                li.InnerHtml += (item.SomeOneToLike);
                ul.InnerHtml += li;
                }
            return new MvcHtmlString (ul.ToString ());
            }
        }
    }