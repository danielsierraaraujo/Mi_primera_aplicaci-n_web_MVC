using Mi_primera_aplicación_web_MVC.Models;

namespace Mi_primera_aplicación_web_MVC.Interfaces
{
    public interface IEquipoRepository
    {
        List<Equipo> DevuelveListadoEquipos();
        Equipo DevuelveEquipo(int Id);
        bool CrearEquipo();
        bool ActualizarEquipo();
        bool EliminarEquipo();
    }
}
