using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Abstract;

namespace WebUI.Controllers
{
    public class AccountsController : Controller
    {
        private IAvitoRepository repository;
        public AccountsController(IAvitoRepository repo)
        {
            repository = repo;
        }
        public ViewResult List()
        {
            return View(repository.Accounts);
        }
    }
}