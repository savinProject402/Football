using Football.Domain.Services.Interfaces;
using Football.Models.Cards;

namespace Football.Controllers
{
    public class CardsController
    {
        private readonly ICardServices _cardService;

        public CardsController(ICardServices cardService)
        {
            _cardService = cardService;
        }
        //AddCardToPlayerPostModel
        public void AddCardsToPlayers(AddCardToPlayerPostModel model)
        {
            _cardService.AddCardsToPlayers(model.CardsId, model.PlayersId);
        }
    }
}
