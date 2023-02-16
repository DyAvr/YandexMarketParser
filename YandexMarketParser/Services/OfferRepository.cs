using YandexMarketParser.Data;
using YandexMarketParser.Models;
using YandexMarketParser.Services.Interfaces;

namespace YandexMarketParser.Services {
    public class OfferRepository: IOfferRepository {
        private readonly ApplicationDbContext _dbContext;

        public OfferRepository(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Offer> GetOfferAsync(string id) {
            return await _dbContext.Offers.FindAsync(id) ;
        }

        public async Task CreateOfferAsync(Offer offer) {
            if(await GetOfferAsync(offer.Id) == null) {
                await _dbContext.Offers.AddAsync(offer);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
