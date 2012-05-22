using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace mega_saldao.Models
{
    [XmlRoot("products")]
    public class Catalog
    {
        public Catalog()
        {
            Products = new List<Product>();
        }

        [XmlElement("product")]
        public List<Product> Products { get; set; }
    }
}