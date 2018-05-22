using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Blog.Areas.Admin.Filters;
using DAL.Models;
using DAL.Repos;
using PagedList;
using DAL.ViewModels;

namespace Blog.Areas.Admin.Controllers
    {
    [CustomAuthentication]
    public class ArticlesController : Controller
        {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public ActionResult Index (int? page)
            {
            return View (unitOfWork.ArticleRepository.Get ().ToPagedList (page ?? 1,4));
            }
        public ActionResult Create ()
            {
            return View ();
            }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create (Article article)
            {
            if ( ModelState.IsValid )
                {
                article.PublicationDate = DateTime.UtcNow;
                unitOfWork.ArticleRepository.Insert (article);
                unitOfWork.Save ();
                return RedirectToAction ("Index");
                }
            return View (article);
            }
        // GET: Admin/Articles1/Edit/5
        public ActionResult EditTags (int? id)
            {
            if ( id == null )
                {
                return new HttpStatusCodeResult (HttpStatusCode.BadRequest);
                }
            Article article = unitOfWork.ArticleRepository.GetByID (id);
            var keyWordsList =
                KeyWordsViewModelManager.GetKeyWordsViewModels (article,unitOfWork.KeyWordRepository.Get ());

            if ( article == null )
                {
                return HttpNotFound ();
                }
            return View (keyWordsList);
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditTags (FormCollection formCollection)
            {
            List<int> allvalues = new List<int> ();

            if ( formCollection ["keyWordsIfChecked"] != null )
                {
                allvalues = formCollection ["keyWordsIfChecked"].Split (',').Select (x => int.Parse (x)).ToList ();
                }

            Article article = unitOfWork.ArticleRepository.GetByID (int.Parse (formCollection ["Article.Id"]));
            article.KeyWords.Clear ();
            foreach ( var val in allvalues )
                {
                article.KeyWords.Add (unitOfWork.KeyWordRepository.GetByID (val));
                }
            unitOfWork.ArticleRepository.Update (article);
            unitOfWork.Save ();
            return RedirectToAction ("Index");
            }

        }
    }
