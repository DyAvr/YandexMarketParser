using System.Net.Http;
using System.Net.Security;
using System.Text;
using System.Xml.Serialization;
using YandexMarketParser.Models;

namespace YandexMarketParser.Services {
    public class YandexMarketApiClient {
        private const string YmlUrl = "http://partner.market.yandex.ru/pages/help/YML.xml";
        private readonly HttpClient _httpClient;

        public YandexMarketApiClient(HttpClient httpClient) {
            _httpClient = httpClient;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public async Task<YmlCatalog?> GetYmlCatalogAsync() {
            var response = await _httpClient.GetAsync(YmlUrl);
            response.EnsureSuccessStatusCode();
            var responseStream = await response.Content.ReadAsStreamAsync();

            var encoding = Encoding.GetEncoding("windows-1251");
            var xmlSerializer = new XmlSerializer(typeof(YmlCatalog));
            return (YmlCatalog?)xmlSerializer.Deserialize(new StreamReader(responseStream, encoding));
        }
    }
}
