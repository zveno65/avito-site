using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Abstract;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class AnnouncementsController : Controller
    {
        private IAnRepository repository;
        public int pagesize=5;
        public AnnouncementsController(IAnRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string genre,int page = 1)
        {
            AnnouncmentsListViewModel model = new AnnouncmentsListViewModel
            {
                Announcments = repository.Announcments
                .Where(a => genre == null || a.Category.Name == genre)
                .OrderBy(An => An.ID)
                .Skip((page - 1) * pagesize)
                .Take(pagesize),
                PagingInfo = new Paginginfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pagesize,
                    TotalItems = genre == null ?
                    repository.Announcments.Count() :
                    repository.Announcments.Where(An => An.Category.Name == genre).Count()
                },
                CurrentCategory=genre
            };
            return View(model);
        }
        public ActionResult Vihod()
        {
            Session["UserId"] = null;
            Session["UserName"] = null;
            return RedirectToAction("List");
        }
    }
}