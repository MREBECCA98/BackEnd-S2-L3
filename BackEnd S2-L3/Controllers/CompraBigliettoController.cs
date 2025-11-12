using BackEnd_S2_L3.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_S2_L3.Controllers
{
    public class CompraBigliettoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Titolo = "COMPRA BIGLIETTO";
            return View();
        }


    }
}
