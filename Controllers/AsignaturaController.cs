using System;
using System.Collections.Generic;
using aspplatzi.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspplatzi.Controllers
{
    public class AsignaturaController: Controller
    {
        public IActionResult Index(){
            var asignaturas = new Asignatura{
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Matematicas"
            };

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;
            
            return View(asignaturas);
        }
         public IActionResult MultiAsignatura(){
            var asignaturas = new List<Asignatura>(){
                    new Asignatura{UniqueId = Guid.NewGuid().ToString(), Nombre = "Programacion"},
                    new Asignatura{UniqueId = Guid.NewGuid().ToString(), Nombre = "Matematicas"},
                    new Asignatura{UniqueId = Guid.NewGuid().ToString(), Nombre = "Educacion Fisica"},
                    new Asignatura{UniqueId = Guid.NewGuid().ToString(), Nombre = "Castellano"},
                    new Asignatura{UniqueId = Guid.NewGuid().ToString(), Nombre = "Ciencias Naturales"}
            };

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;
            /*Por convencion el View() llama a la vista del nombre del 
            metodo del controlle a menos de que se le indique otro */
            return View("MultiAsignatura", asignaturas);
        }
    }
}