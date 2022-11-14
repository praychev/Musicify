using izpit.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace izpit.ViewModels.Songs
{
    public class ArtistVM
    {
        public List<Artist> Items { get; set; }

        public List<Song> Songs { get; set; }
    }
}
