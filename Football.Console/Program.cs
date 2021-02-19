using Football.Controllers;
using Football.Data.Repositories;
using Football.Data.Repositories.Interfaces;
using Football.Domain.Services;
using Football.Models.Cards;
using Football.Models.Pleyers;
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
            var addCardPostModel = new AddCardToPlayerPostModel { CardsId = 2, PlayersId = 5 };
            cardControl.AddCardsToPlayers(addCardPostModel);
            //var repository = new PlayerRepository();
            //var service = new PlayersService(repository);
            //var controller = new PleyersController(service);
            //var playersPostModel = new PlayersPostModel { Status = 2, Id = 5, MatchesId = 1 };
            //var updatePlayersPostModel = new UpdatePlayersPostModel
            //{
            //    Status = 2
            //};
            //controller.Update(updatePlayersPostModel);
        }
    }
}
