using Football.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Data.Repositories
{
    public class CardRepository : ICardRepository
    {
        public void AddCardsToPlayers(int cardId, int playerId)
        {
            using (var ctx  = new FootballContext("Default"))
            {
                var players = ctx.Players.FirstOrDefault(x => x.Id == playerId);
                var card = ctx.Cards.FirstOrDefault(x => x.Id == cardId);

                players.Cards.Add(card);
                ctx.SaveChanges();
            }
        }
    }
}
