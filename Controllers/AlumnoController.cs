using System;
using System.Collections.Generic;
using System.Linq;
using aspplatzi.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspplatzi.Controllers
{
    public class AlumnoController: Controller
    {
        public IActionResult Index()
        {
            var alumno = new Alumno{
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Aldo Robot"
            };

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;
            
            return View(alumno);
        }
         public IActionResult MultiAlumno()
         {
            var alumnos = GenerarAlumnos();

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;
            /*Por convencion el View() llama a la vista del nombre del 
            metodo del controlle a menos de que se le indique otro */
            return View("MultiAlumno", alumnos);
        }
        private List<Alumno> GenerarAlumnos()
        {
            string[] nombre1 = {"Juan", "Carlos","Alvarez"};
            string[] nombre2 = {"Manuel", "Maria","Jose"};
            string[] apellido = {"Rodriguez", "Alcantara","Santos"};

            var listaAllumnos = from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido
                                select new Alumno{ Nombre = $"{n1}" + " " + $"{n2}" + " " + $"{a1}", UniqueId = Guid.NewGuid().ToString()};
        return listaAllumnos.OrderBy(a=>a.UniqueId).ToList();
        }               
                 
    
    }
}