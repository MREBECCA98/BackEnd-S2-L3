using BackEnd_S2_L3.Models;
using BackEnd_S2_L3.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_S2_L3.Controllers
{
    public class CompraBigliettoController : Controller
    {
        public static List<Biglietto> ListaSale { get; set; } = new List<Biglietto>()
        {

            new Biglietto()
            {
                Id = Guid.NewGuid(),
                EmessoIl= DateTime.Now,



            },


        };


        public IActionResult Index()
        {
            ViewBag.Titolo = "COMPRA BIGLIETTO";
            ListaBigliettiViewModel listaBigliettiViewModel = new ListaBigliettiViewModel();
            listaBigliettiViewModel.Biglietti = ListaSale;
            return View(listaBigliettiViewModel);
        }


    }
}
