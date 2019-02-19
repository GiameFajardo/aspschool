using System;
using aspplatzi.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspplatzi.Controllers
{
    public class EscuelaController: Controller
    {
        public IActionResult Index(){
            var escuela = new Escuela{
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Esperanza",
                AñoDeCreación = 1992,
                Ciudad = "Santiago",
                Pais = "Republica Dominicana",
                TipoEscuela = TiposEscuela.Secundaria
            };

            ViewBag.CosaDinamica = "La Monja";
            return View(escuela);
        }
    }
}