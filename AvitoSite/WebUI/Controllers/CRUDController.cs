using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class CRUDController : Controller
    {
        IAnRepository repository;
        ICategoryRepository repositoryC;

        public CRUDController(IAnRepository repo, ICategoryRepository repoC)
        {
            repository = repo;
            repositoryC = repoC;
        }

        public ViewResult Index()
        {
            IEnumerable<An> announcments = repository.Announcments.Where(a => a.AccountID.ToString() == Session["UserId"].ToString());
            return View(announcments);
        }

        public ActionResult Edit(Guid id)
        {
                An announcment = repository.Announcments.FirstOrDefault(a => a.ID == id);
                return View(announcment);
        }

        public ViewResult Create()
        {
            List<SelectListItem> listItem = new List<SelectListItem>();

            List<Category> sd = repositoryC.Categories.ToList<Category>();

            foreach (var item in sd)
            {
                listItem.Add(new SelectListItem() { Value = item.Name, Text = item.ID.ToString() });
            }

            ViewBag.DropDownValues = new SelectList(listItem, "Text", "Value");
            return View();
        }

        [HttpPost]
        public ActionResult Create(An announcment)
        {
            if (ModelState.IsValid)
            {
                announcment.AccountID = Guid.Parse(Session["UserId"].ToString());
                announcment.DateStart = DateTime.Now;
                announcment.DateFinish = announcment.DateStart.AddDays(14);
                repository.SaveAnnouncment(announcment);
                TempData["message"] = string.Format("Новое объявление сохранено");
                return RedirectToAction("Index");
            }
            else
            {
                List<SelectListItem> listItem = new List<SelectListItem>();
                List<Category> sd = repositoryC.Categories.ToList<Category>();
                foreach (var item in sd)
                {
                    listItem.Add(new SelectListItem() { Value = item.Name, Text = item.ID.ToString() });
                }
                ViewBag.DropDownValues = new SelectList(listItem, "Text", "Value");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Edit(An announcment)
        {
            if (ModelState.IsValid)
            {
                repository.SaveAnnouncment(announcment);
                TempData["message"] = string.Format("Изменение информации сохранены");
                return RedirectToAction("Index");
            }
            else
            {
                return View(announcment);
            }
        }
        public ActionResult Delete(An announcment)
        {
            repository.DeleteAnnouncment(announcment);
            TempData["message"] = string.Format("Объявление удалено");
            return RedirectToAction("Index");
        }
    }
}