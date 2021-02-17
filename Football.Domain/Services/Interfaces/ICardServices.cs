using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Domain.Services.Interfaces
{
   public interface ICardServices
    {
        void AddCardsToPlayers(int cardId, int playerId);
    }
}
