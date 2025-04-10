using Mi_primera_aplicación_web_MVC.Interfaces;
using Mi_primera_aplicación_web_MVC.Models;

namespace Mi_primera_aplicación_web_MVC.Repositories
{
    public class EquipoRepository : IEquipoRepository
    {
        public bool ActualizarEquipo()
        {
            throw new NotImplementedException();
        }

        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveEquipo(int Id)
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveInfoEquipo(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.Where( item => item.Id == Id).First();
            return equipo;
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo LDU = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PartidosJugados = 20,
                PartidosGanados = 18,
                PartidosPerdidos = 2,
                PartidosEmpatados = 0
            };
            equipos.Add(LDU);
            Equipo BSC = new Equipo
            {
                Id = 2,
                Nombre = "BSC",
                PartidosJugados = 10,
                PartidosGanados = 4,
                PartidosPerdidos = 6,
                PartidosEmpatados = 0
            };
            equipos.Add(BSC);
            return equipos;
        }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }

    }
}
