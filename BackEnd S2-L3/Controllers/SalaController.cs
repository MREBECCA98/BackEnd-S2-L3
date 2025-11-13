using BackEnd_S2_L3.Models;
using Microsoft.AspNetCore.Mvc;
using BackEnd_S2_L3.ViewModels;


namespace BackEnd_S2_L3.Controllers
{
    public class SalaController : Controller
    {

        public static List<Sala> ListaSale { get; set; } = new List<Sala>()
        {

            new Sala()
            {
                Id = Guid.NewGuid(),
                NomeSala = "Sala Nord",
                NumeroPosti= 120,
                PrezzoBase= 8.00m,
            },

            new Sala()
            {
                Id = Guid.NewGuid(),
                NomeSala = "Sala Sud",
                NumeroPosti= 120,
                 PrezzoBase= 8.00m,
            },

            new Sala()
            {
                Id = Guid.NewGuid(),
                NomeSala = "Sala Est",
                NumeroPosti= 120,
                 PrezzoBase= 8.00m,
            }
        };

        public IActionResult Index()
        {
            ViewBag.Titolo = "SALE DISPONIBILI";

            ListaSaleViewModel listaSaleViewModel = new ListaSaleViewModel();
            listaSaleViewModel.Sales = ListaSale;
            return View(listaSaleViewModel);
        }
    }
}
