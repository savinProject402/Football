using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Data.Models
{
   public class Players
    {
        public int Id { get; set; }
        public string NamePlayer { get; set; }
        public int MatchesId { get; set; }

        public virtual Matches Matches { get; set; }

        public virtual ICollection<Cards> Cards { get; set; }
    }
}
