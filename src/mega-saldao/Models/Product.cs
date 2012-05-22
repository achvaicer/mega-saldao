using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace mega_saldao.Models
{
    [XmlRoot("product")]
    public class Product
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("price")]
        public decimal Price { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("quantity")]
        public int QuantityAvailable { get; set; }

        [XmlElement("image")]
        public string ImageUrl { get; set; }
    }
}