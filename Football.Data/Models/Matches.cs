using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Data.Models
{
   public class Matches
    {
        public int Id { get; set; }
        public string NameMatches { get; set; }

        public virtual ICollection<Players> Players { get; set; }
    }
}
