using Mi_primera_aplicación_web_MVC.Models;
using Mi_primera_aplicación_web_MVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Mi_primera_aplicación_web_MVC.Controllers
{
    public class EquipoController : Controller
    {
        EquipoRepository repository = new EquipoRepository(); // Evitamos repetir instancias

        public IActionResult ListaEquipos()
        {
            var equipos = repository.DevuelveListadoEquipos();
            return View(equipos);
        }

        public IActionResult Edit(int Id)
        {
            var equipo = repository.DevuelveInfoEquipo(Id);
            if (equipo == null)
                return NotFound();
            return View(equipo);
        }

        //generado por chatgpt
        [HttpPost]
        public IActionResult Edit(Equipo equipo)
        {
            // Validacion - p.jugados debe ser igual a la suma de ganados + empatados + perdidos
            int suma = equipo.PartidosGanados + equipo.PartidosEmpatados + equipo.PartidosPerdidos;

            if (suma != equipo.PartidosJugados)
            {
                ViewBag.Error = "Los partidos jugados no coinciden con la suma de los partidos ganados, empatados y perdidos, por fav or revisalo";
                return View(equipo); // Devuelve con mensaje de error
            }

            // Cálculo de puntos
            equipo.Puntos = (equipo.PartidosGanados * 3) + equipo.PartidosEmpatados;

            // Actualizar equipo
            bool actualizado = repository.ActualizarEquipo(equipo);
            if (!actualizado)
            {
                return NotFound(); // No se encontro el equipo a actualizar
            }

            return RedirectToAction("ListaEquipos");
        }
        public IActionResult Detalle(int Id)
        {
            var equipo = EquipoRepository.Instancia.DevuelveInfoEquipo(Id);
            return View(equipo);
        }
    }
}

