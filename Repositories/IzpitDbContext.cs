using izpit.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace izpit.Repositories
{
    public class IzpitDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }    
        public DbSet<News> News { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<SongsToPlaylist> SongsToPlaylists { get; set; }

    
        public IzpitDbContext()
        {
            this.Users = Set<User>();
            this.News = Set<News>();
            this.Songs = Set<Song>();
            this.Artists = Set<Artist>();
            this.Playlists = Set<Playlist>();
            this.SongsToPlaylists = Set<SongsToPlaylist>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=IzpitDb;Trusted_Connection=True;").UseLazyLoadingProxies();
        }
    }
}
