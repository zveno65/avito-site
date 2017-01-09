using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class RegController : Controller
    {
        IAccRepository repository;
        public RegController(IAccRepository repo)
        {
            repository = repo;
        }
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Account acc)
        {
            if (ModelState.IsValid)
            {
                Account con = repository.Accounts.SingleOrDefault(u => u.Login == acc.Login && u.Password == acc.Password);
                if (con == null)
                {
                    TempData["message"] = string.Format("Регистрация прошла успешно");
                    Session["UserName"] = acc.Login.ToString();
                    repository.SaveAccount(acc);
                    Session["UserId"] = repository.Accounts.SingleOrDefault(u => u.Login == acc.Login && u.Password == acc.Password).ID;
                }
                else
                {
                    ModelState.AddModelError("password", "Введенные логин или пароль уже существуют");
                }
            }
            return View();
        }
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account acc)
        {
            Account con = repository.Accounts.SingleOrDefault(u => u.Login == acc.Login && u.Password == acc.Password);
            if (con != null)
            {
                Session["UserId"] = con.ID.ToString();
                Session["UserName"] = con.Login.ToString();
                return RedirectToAction("LoggedIn");
            }
            else
            {
                ModelState.AddModelError("password", "Логин или пароль не верен");
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
                return View();
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}