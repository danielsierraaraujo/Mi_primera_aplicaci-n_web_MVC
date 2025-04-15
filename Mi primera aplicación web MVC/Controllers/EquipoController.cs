using Mi_primera_aplicación_web_MVC.Models;
using Mi_primera_aplicación_web_MVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Mi_primera_aplicación_web_MVC.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            EquipoRepository repository = new EquipoRepository();
            var equipos = repository.DevuelveListadoEquipos();

            return View(equipos);
        }
        public IActionResult Edit(int Id)
        {
            EquipoRepository repository = new EquipoRepository();
            var equipo = repository.DevuelveInfoEquipo(Id);
            return View(equipo);
        }
        public IActionResult Detalle(int Id)
        {
            EquipoRepository repository = new EquipoRepository();
            var equipo = repository.DevuelveInfoEquipo(Id);
            return View(equipo);
        }

    }
}
