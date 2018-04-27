using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Helpers
    {
    public static class ProfileHelper
        {
        public static MvcHtmlString CreateProfileHelper (this HtmlHelper html,IEnumerable<string> options, string type)
            {
            TagBuilder ul = new TagBuilder (type);

            foreach ( var item in options )
                {
                TagBuilder li = new TagBuilder ("li");
               
                li.InnerHtml += (item);
                ul.InnerHtml += li;
                }
           


            return new MvcHtmlString (ul.ToString ());
            }
        }
    }