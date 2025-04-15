using Mi_primera_aplicación_web_MVC.Interfaces;
using Mi_primera_aplicación_web_MVC.Models;

namespace Mi_primera_aplicación_web_MVC.Repositories
{
    public class EquipoRepository : IEquipoRepository
    {
        private static List<Equipo> equipos = new List<Equipo>
            {
                new Equipo { Id = 1, Nombre = "Liga Deportiva Universitaria", Logo = "liga.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 },
                new Equipo { Id = 2, Nombre = "Barcelona SC", Logo = "bsc.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 },
                new Equipo { Id = 3, Nombre = "Emelec", Logo = "emelec.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 },
                new Equipo { Id = 4, Nombre = "Aucas", Logo = "aucas.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 },
                new Equipo { Id = 5, Nombre = "Delfín", Logo = "delfin.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 },
                new Equipo { Id = 6, Nombre = "El Nacional", Logo = "nacional.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 },
                new Equipo { Id = 7, Nombre = "Técnico Universitario", Logo = "tecnico.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 },
                new Equipo { Id = 8, Nombre = "Universidad Católica", Logo = "cato.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 },
                new Equipo { Id = 9, Nombre = "Orense", Logo = "orense.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 },
                new Equipo { Id = 10, Nombre = "Vinotinto", Logo = "venecos.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 },
                new Equipo { Id = 11, Nombre = "Dep. Cuenca", Logo = "cuenca.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 },
                new Equipo { Id = 12, Nombre = "Libertad FC", Logo = "libertad.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 },
                new Equipo { Id = 13, Nombre = "Manta FC", Logo = "manta.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 },
                new Equipo { Id = 14, Nombre = "Macará", Logo = "macara.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 },
                new Equipo { Id = 15, Nombre = "Mushuc Runa SC", Logo = "runa.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 },
                new Equipo { Id = 16, Nombre = "Ind. del Valle", Logo = "idv.png", PartidosJugados = 0, PartidosGanados = 0, PartidosPerdidos = 0, PartidosEmpatados = 0 }
            };

        public static EquipoRepository Instancia { get; } = new EquipoRepository();

        public Equipo DevuelveInfoEquipo(int Id)
        {
            return equipos.FirstOrDefault(e => e.Id == Id);
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            return equipos.OrderByDescending(e => e.Puntos).ToList();
        }

        public Equipo ObtenerPorId(int id)
        {
            return equipos.FirstOrDefault(e => e.Id == id);
        }

        public bool ActualizarEquipo(Equipo equipoActualizado)
        {
            var equipo = equipos.FirstOrDefault(e => e.Id == equipoActualizado.Id);
            if (equipo == null)
                return false;

            equipo.PartidosJugados = equipoActualizado.PartidosJugados;
            equipo.PartidosGanados = equipoActualizado.PartidosGanados;
            equipo.PartidosEmpatados = equipoActualizado.PartidosEmpatados;
            equipo.PartidosPerdidos = equipoActualizado.PartidosPerdidos;
            equipo.Puntos = equipoActualizado.Puntos;

            return true;
        }
        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveEquipo(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
