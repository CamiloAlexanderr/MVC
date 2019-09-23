using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Metodolgia.Models;

namespace Metodolgia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

         public IActionResult Usuario()
        {
            return View();
        }

        public IActionResult Autos()
        {
                    var coches = new List<Coche>
                    {
                        new Coche {Marca="BMW",Modelo="X6",Color="Gris"},
                        new Coche {Marca="Mercedes",Modelo="A200",Color="Blanco"},
                        new Coche {Marca="Porsche",Modelo="Cayanne",Color="Azul"},
                        new Coche {Marca="Ford",Modelo="Mustang",Color="Rojo"},


                    };

            return View(coches);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
