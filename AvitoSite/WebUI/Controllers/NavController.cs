using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class NavController : Controller
    {
        private IAnRepository repository;

        public NavController (IAnRepository rep)
        {
            repository = rep;
        }
        public PartialViewResult Menu(string genre = null)
        {
            ViewBag.SelectedGenre = genre;

            IEnumerable<string> genres = repository.Announcments
                .Select(an => an.Category.Name)
                .Distinct()
                .OrderBy(x => x);

            return PartialView(genres);
        }
    }
}