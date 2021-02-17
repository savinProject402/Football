using Football.Domain.Services.Interfaces;
using Football.Data.Repositories.Interfaces;

namespace Football.Domain.Services
{
    public class CardServices : ICardServices
    {
        private readonly ICardRepository _cardRepository;

        public CardServices(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public void AddCardsToPlayers(int cardId, int playerId)
        {
            _cardRepository.AddCardsToPlayers(cardId,  playerId);
        }
    }
}
