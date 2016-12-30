using Domain;
using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class AnnouncmentController : Controller
    {
        private IAnRepository repository;
        public AnnouncmentController(IAnRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
            return View(repository.announcment);
        }
    }
}