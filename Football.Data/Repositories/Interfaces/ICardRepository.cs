using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Data.Repositories.Interfaces
{
   public interface ICardRepository
    {
        void AddCardsToPlayers(int cardId, int playerId);
    }
}
