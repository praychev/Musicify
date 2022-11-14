using izpit.ActionFilters;
using izpit.Entities;
using izpit.ExtentionMethods;
using izpit.Repositories;
using izpit.ViewModels.Playlists;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace izpit.Controllers
{
    [AuthenticationFilter]
    public class PlaylistsController : Controller
    {
        public IActionResult Index(IndexVM model)
        {
            
            PlaylistsRepository repo = new PlaylistsRepository();

            model.Items = repo.GetAll();

            return View(model);
        }

        [HttpGet]
        public IActionResult CreatePlayName()
        {
            

            CreateNamePlayVM model = new CreateNamePlayVM();
           

            return View(model);
        }

        [HttpPost]
        public IActionResult CreatePlayName(CreateNamePlayVM model)
        {
          

            PlaylistsRepository repo = new PlaylistsRepository();
            SongRepository songRepo = new SongRepository();

            Playlist item = new Playlist();
            Song sDefault = songRepo.GetFirstOrDefault(i => i.Id == 1);
            
            item.Title = model.Title;
            item.SongId = sDefault.Id;
           
            repo.Save(item);


            HttpContext.Session.SetObject("currentPlaylist", item);

            return RedirectToAction("CreateFullPlay", "Playlists", new { Id = item.Id });
        }

        [HttpGet]
        public IActionResult CreateFullPlay(int Id)
        {

            PlaylistsRepository repo = new PlaylistsRepository();
            SongsToPlaylistRepository songsToProjectRepo = new SongsToPlaylistRepository();
            SongRepository songsRepo = new SongRepository();

            CreateFullVM model = new CreateFullVM();

            model.Playlist = repo.GetFirstOrDefault(i => i.Id == Id);

            HttpContext.Session.SetObject("currentPlaylist", model.Playlist);

            model.Plays = songsToProjectRepo.GetAll(i => i.PlaylistId == Id);

            List<int> songsToAdd = model.Plays
                                              .Select(i => i.SongId)
                                                .ToList();
            
            model.Songs = songsRepo.GetAll(i => !songsToAdd.Contains(i.Id));

            return View(model);
        }


        [HttpPost]
        public IActionResult CreateFullPlay(CreateFullVM model)
        {

            SongsToPlaylistRepository songsToProjectRepo = new SongsToPlaylistRepository();
            Playlist cPlaylist = this.HttpContext.Session.GetObject<Playlist>("currentPlaylist");

            foreach (int songId in model.SongIds)
            {
                SongsToPlaylist item = new SongsToPlaylist();
                item.SongId = songId;
                item.PlaylistId = cPlaylist.Id;

                songsToProjectRepo.Save(item);
            }

            return RedirectToAction("CreateFullPlay", "Playlists", new { Id = cPlaylist.Id });

        }

        public IActionResult Done()
        {

            HttpContext.Session.Remove("currentPlaylist");

            return RedirectToAction("Index", "Playlists");
        }

        [HttpGet]
        public IActionResult RemoveSong(int id)
        {
            SongsToPlaylistRepository songsToProjectRepo = new SongsToPlaylistRepository();
            Playlist cPlaylist = this.HttpContext.Session.GetObject<Playlist>("currentPlaylist");

            SongsToPlaylist item = songsToProjectRepo.GetFirstOrDefault(i => i.Id == id);

            songsToProjectRepo.Delete(item);

            return RedirectToAction("CreateFullPlay", "Playlists", new { Id = cPlaylist.Id });
        }


        public IActionResult Delete(int id)
        {
             PlaylistsRepository repo = new PlaylistsRepository();
            Playlist item = new Playlist();
            item.Id = id;

            repo.Delete(item);

            return RedirectToAction("Index", "Playlists");
        }

    }
}
