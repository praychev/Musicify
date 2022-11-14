using izpit.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace izpit.ViewModels.Playlists
{
    public class CreateFullVM
    {
        public int PlaylistId { get; set; }
        public List<int> SongIds { get; set; }


        public List<SongsToPlaylist> Plays { get; set; }
        public List<Song> Songs { get; set; }
        public Playlist Playlist { get; set; }
    }
}
