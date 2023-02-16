using System.Xml.Serialization;

namespace YandexMarketParser.Models {
    [XmlRoot("yml_catalog")]
    public class YmlCatalog {
        [XmlElement("shop")]
        public Shop Shop { get; set; }
    }

    public class Shop {
        [XmlArray("offers")]
        [XmlArrayItem("offer")]
        public List<Offer> Offers { get; set; }
    }
}
