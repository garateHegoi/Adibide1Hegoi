using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace Ariketa1.Controllers
{
    public class kaixomunduaController : Controller
    {
        private string izena;
        private string zenbat;

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult OngiEtorri(string izena, int zenbat = 1)
        {
            ViewBag.Mezua = "Hello " + izena;
            ViewBag.Zenbat = zenbat;
            return View();
        }
    }
}
