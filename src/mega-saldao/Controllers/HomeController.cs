using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;
using System.IO;

namespace mega_saldao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var serializer = new XmlSerializer(typeof(Models.Catalog));
            Models.Catalog catalog;
            using (var stream = new StreamReader(Server.MapPath("~/App_Data/products.xml")))
                catalog = (Models.Catalog)serializer.Deserialize(stream);

            return View(catalog.Products);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
