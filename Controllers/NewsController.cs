using izpit.ActionFilters;
using izpit.Entities;
using izpit.ExtentionMethods;
using izpit.Repositories;
using izpit.ViewModels.New;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace izpit.Controllers
{
    [AuthenticationFilter]
    public class NewsController : Controller
    {
        public IActionResult Index(NewsVM model)
        {
            NewsRepository repo = new NewsRepository();

            model.Items = repo.GetAll();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            User loggedUser = this.HttpContext.Session.GetObject<User>("loggedUser");

            CreateVM model = new CreateVM();
            model.Author = loggedUser.Username;

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            User loggedUser = this.HttpContext.Session.GetObject<User>("loggedUser");

            
            NewsRepository repo = new NewsRepository();

            News item = new News();
            item.Author = model.Author;
            item.Title = model.Title;
            item.Description = model.Description;

            repo.Save(item);

            return RedirectToAction("Index", "News");
        }

    }
}
