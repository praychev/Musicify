using izpit.ActionFilters;
using izpit.Entities;
using izpit.ExtentionMethods;
using izpit.Repositories;
using izpit.ViewModels.Profile;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace izpit.Controllers
{
    [AuthenticationFilter]
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Delete()
        {
            UserRepository repo = new UserRepository();
            User item = this.HttpContext.Session.GetObject<User>("loggedUser");
            

            repo.Delete(item);

            return RedirectToAction("Logout", "Home");
        }



        [HttpGet]
        public IActionResult Edit()
        {
           
            User item = this.HttpContext.Session.GetObject<User>("loggedUser");

            

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.Username = item.Username;
            model.Password = item.Password;
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            User item = new User();
            item.Id = model.Id;
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;

            UserRepository repo = new UserRepository();
            repo.Save(item);

            return RedirectToAction("Index", "Profile");
        }


    }
}
