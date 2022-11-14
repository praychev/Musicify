﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace izpit.Entities
{
    public class SongsToPlaylist : BaseEntity
    {
       
        public int SongId { get; set; }
        public int PlaylistId { get; set; }
        [ForeignKey("SongId")]
        public virtual Song Song { get; set; }
        [ForeignKey("PlaylistId")]
        public virtual Playlist Playlist { get; set; }

    }
}
