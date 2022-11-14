using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace izpit.Entities
{
    public class Playlist : BaseEntity
    {
       
        public int SongId { get; set; }
        public string Title { get; set; }
        [ForeignKey("SongId")]
        public virtual Song Songs { get; set; }

    }
}
