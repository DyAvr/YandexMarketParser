using YandexMarketParser.Models;

namespace YandexMarketParser.Services.Interfaces
{
    public interface IOfferRepository
    {
        Task<Offer> GetOfferAsync(string id);
        Task CreateOfferAsync(Offer offer);
    }
}
