using System;
using aspplatzi.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspplatzi.Controllers
{
    public class EscuelaController: Controller
    {
        public IActionResult Index(){
            var escuela = new Escuela{
                Id  = Guid.NewGuid().ToString(),
                Nombre = "Esperanza",
                AnoFundacion = 1992
            };

            ViewBag.CosaDinamica = "La Monja";
            return View(escuela);
        }
    }
}