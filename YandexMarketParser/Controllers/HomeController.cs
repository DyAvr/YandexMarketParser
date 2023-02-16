using Microsoft.AspNetCore.Mvc;
using YandexMarketParser.Services;
using YandexMarketParser.Services.Interfaces;

namespace YandexMarketParser.Controllers {
    public class HomeController: Controller {
        private readonly YandexMarketApiClient _yandexMarketApiClient;
        private readonly IOfferRepository _offerRepository;

        public HomeController(YandexMarketApiClient yandexMarketApiClient, IOfferRepository offerRepository) {
            _yandexMarketApiClient = yandexMarketApiClient;
            _offerRepository = offerRepository;
        }

        public async Task<IActionResult> Index() {
            var ymlCatalog = await _yandexMarketApiClient.GetYmlCatalogAsync();
            var offer = ymlCatalog?.Shop.Offers.FirstOrDefault(o => o.Id == "12344");

            if(offer != null) {
                await _offerRepository.CreateOfferAsync(offer);
            }

            return View(offer);
        }
    }
}
