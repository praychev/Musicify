using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace izpit.Entities
{
    public class Artist:BaseEntity
    {
        
        public int SongId { get; set; }
        public string Name { get; set; }
        [ForeignKey("SongId")]
        public virtual Song Songs { get; set; }

    }
}
