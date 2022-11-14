using izpit.Entities;
using izpit.Repositories;
using izpit.ViewModels.Songs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace izpit.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index(IndexVM model)
        {
            SongRepository repo = new SongRepository();

            model.Items = repo.GetAll();

            return View(model);
        }
        public IActionResult Artists(ArtistVM model)
        {
            ArtistRepository repo = new ArtistRepository();
            SongRepository songRepo = new SongRepository();

            model.Items = repo.GetAll();
            foreach(Artist a in model.Items)
            {
                model.Songs=songRepo.GetAll(i=> i.Id==a.SongId);
            }
            return View(model);
        }
    }
}
