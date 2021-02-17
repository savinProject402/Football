using Football.Controllers;
using Football.Data.Repositories;
using Football.Domain.Services;
using Football.Models.Cards;
using System;

namespace Football.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardRepo = new CardRepository();
            var cardServices = new CardServices(cardRepo);
            var cardControl = new CardsController(cardServices);

            var addCardPostModel = new AddCardToPlayerPostModel {CardsId = 2, PlayersId = 1 };

            cardControl.AddCardsToPlayers(addCardPostModel);

        }
    }
}
