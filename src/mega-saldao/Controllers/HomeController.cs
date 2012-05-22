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
            var catalog = (Models.Catalog)serializer.Deserialize(new StreamReader(Server.MapPath("~/App_Data/products.xml")));

            return View(catalog.Products);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
