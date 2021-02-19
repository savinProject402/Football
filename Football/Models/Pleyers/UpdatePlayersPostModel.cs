using Football.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Models.Pleyers
{
   public class UpdatePlayersPostModel
    {
        public int Id { get; set; }
        public string NamePlayer { get; set; }
        public int MatchesId { get; set; }
        public int Status { get; set; }
    }
}
