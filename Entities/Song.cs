using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace izpit.Entities
{
    public class Song : BaseEntity
    {
       
        
        public string Title { get; set; }
      
        public string Genre { get; set; }
        public string Composer { get; set; }

    }
}
