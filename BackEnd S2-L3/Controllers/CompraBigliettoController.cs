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

            return View();
        }

        [HttpPost]
        public IActionResult Compra(AcquistaBigliettoViewModel acquistaBigliettoViewModel)
        {
            Console.WriteLine(acquistaBigliettoViewModel.CodiceFiscale);
            var Biglietto = new Biglietto()
            {
                Id = Guid.NewGuid(),
                EmessoIl = DateTime.Now,
                Spettatore = new Spettatore()
                {
                    CodiceFiscale = acquistaBigliettoViewModel.CodiceFiscale,
                    Nome = acquistaBigliettoViewModel.Nome,
                    Cognome = acquistaBigliettoViewModel.Cognome,
                    Id = Guid.NewGuid(),
                }

            };
            return View();
        }
    }
}
