using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebVideoJuego.Controllers
{
    public class ProductorInternoController : Controller
    {
        // GET: ProductoInterno
        public ActionResult Index()
        {
            return View("FormProductorInterno");
        }
    }
}