using System.Xml.Serialization;

namespace YandexMarketParser.Models {
    public class Offer {

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("url")]
        public string Url { get; set; }

        [XmlElement("price")]
        public string Price { get; set; }

        [XmlElement("currencyId")]
        public string CurrencyId { get; set; }

        [XmlElement("picture")]
        public string Picture { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }
    }
}
