using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Blog.Helpers
    {
    public static class ListHelper
        {
        public static MvcHtmlString CreateList (this HtmlHelper html,IEnumerable<DAL.ViewModels.ArticleViewModel> articles)
            {
            TagBuilder ul = new TagBuilder ("ul");
            ul.MergeAttribute ("class","listULarticles");
            foreach ( var article in articles )
                {
                TagBuilder divArticleHeader = new TagBuilder ("div");
                divArticleHeader.MergeAttribute ("class","articleHeader");

                TagBuilder articleHeaderReadArticle = new TagBuilder ("div");
                articleHeaderReadArticle.MergeAttribute ("class","articleHeaderReadArticle");

                TagBuilder articleHeaderReadArticleLink = new TagBuilder ("a");

                TagBuilder divArticleContainer = new TagBuilder ("div");
                divArticleContainer.MergeAttribute ("class","articleContainer");

                TagBuilder divArticleContainerLogo = new TagBuilder ("div");
                divArticleContainerLogo.MergeAttribute ("class","divArticleContainerLogo");

                TagBuilder divArticleContainerLogoContainer = new TagBuilder ("div");
                divArticleContainerLogoContainer.MergeAttribute ("class","divArticleContainerLogoContainer");

                divArticleContainerLogo.InnerHtml += divArticleContainerLogoContainer;

                TagBuilder divArticleContainerText = new TagBuilder ("div");
                divArticleContainerText.MergeAttribute ("class","divArticleContainerText");

                TagBuilder divArticleContainerTextNameDate = new TagBuilder ("div");
                divArticleContainerTextNameDate.MergeAttribute ("class","divArticleContainerTextNameDate");

                TagBuilder divArticleContainerTextNameDateName = new TagBuilder ("h3");
                divArticleContainerTextNameDateName.MergeAttribute ("class","divArticleContainerTextNameDateName");

                divArticleContainerTextNameDateName.SetInnerText (article.Name);

                TagBuilder divArticleContainerTextNameDateDate = new TagBuilder ("p");
                divArticleContainerTextNameDateDate.MergeAttribute ("class","divArticleContainerTextNameDateDate");


                divArticleContainerTextNameDateDate.SetInnerText ("Дата публикации " + article.PublicationDate.ToShortDateString ());
                

                divArticleContainerTextNameDate.InnerHtml += divArticleContainerTextNameDateName;
                divArticleContainerTextNameDate.InnerHtml += divArticleContainerTextNameDateDate;

                TagBuilder divArticleContainerTextPlain = new TagBuilder ("div");
                divArticleContainerTextPlain.MergeAttribute ("class","divArticleContainerTextPlain");

                TagBuilder divArticleContainerTextPlainContainer = new TagBuilder ("p");
                divArticleContainerTextPlainContainer.MergeAttribute ("class","divArticleContainerTextPlainContainer");

                if ( articles.Count () == 1 )
                    {
                    divArticleContainerTextPlainContainer.SetInnerText (article.Text);
                    articleHeaderReadArticleLink.MergeAttribute ("href","/Main/Index");
                    articleHeaderReadArticleLink.SetInnerText ("Вернуться к списку статей");
                        TagBuilder divKeyWordLinks = new TagBuilder ("div");
                        divKeyWordLinks.SetInnerText("EEEEEEEEEEEE");
                        divArticleContainerTextPlainContainer.InnerHtml += divKeyWordLinks;
                    }
                else
                    {
                     articleHeaderReadArticleLink.MergeAttribute ("href","/Main/GetArticle/" + article.Id);
                    articleHeaderReadArticleLink.SetInnerText ("Подробнее");
                    divArticleContainerTextPlainContainer.SetInnerText (article.TextPreview);
                    }

                articleHeaderReadArticleLink.MergeAttribute ("class","articleHeaderReadArticleLink");

                articleHeaderReadArticle.InnerHtml += articleHeaderReadArticleLink;

                divArticleHeader.InnerHtml += articleHeaderReadArticle;

                divArticleContainerTextPlain.InnerHtml += divArticleContainerTextPlainContainer;

                divArticleContainerText.InnerHtml += divArticleContainerTextNameDate;
                divArticleContainerText.InnerHtml += divArticleContainerTextPlain;

                divArticleContainer.InnerHtml += divArticleContainerLogo;
                divArticleContainer.InnerHtml += divArticleContainerText;

                TagBuilder divArticleSpace = new TagBuilder ("div");
                divArticleSpace.MergeAttribute ("class","articleSpace");


                TagBuilder li = new TagBuilder ("li");
                li.InnerHtml += divArticleHeader.ToString ();
                li.InnerHtml += divArticleContainer.ToString ();

                ul.InnerHtml += li.ToString ();
                ul.InnerHtml += divArticleSpace.ToString ();
                }
            return new MvcHtmlString (ul.ToString ());
            }
        }
    }