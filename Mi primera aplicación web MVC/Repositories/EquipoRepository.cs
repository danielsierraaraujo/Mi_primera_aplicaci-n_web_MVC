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
            var equipo = equipos.Where(item => item.Id == Id).First();
            return equipo;
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>
    {
        new Equipo { Id = 1, Nombre = "Liga Deportiva Universitaria",Logo = "liga.png", PartidosJugados = 7, PartidosGanados = 18, PartidosPerdidos = 2, PartidosEmpatados = 0 },
        new Equipo { Id = 2, Nombre = "Barcelona SC",Logo = "bsc.png", PartidosJugados = 6, PartidosGanados = 4, PartidosPerdidos = 5, PartidosEmpatados = 0 },
        new Equipo { Id = 3, Nombre = "Emelec",Logo = "emelec.png", PartidosJugados = 7, PartidosGanados = 5, PartidosPerdidos = 3, PartidosEmpatados = 2 },
        new Equipo { Id = 4, Nombre = "Aucas",Logo = "aucas.png", PartidosJugados = 7, PartidosGanados = 10, PartidosPerdidos = 7, PartidosEmpatados = 2 },
        new Equipo { Id = 5, Nombre = "Delfín",Logo = "delfin.png", PartidosJugados = 8, PartidosGanados = 7, PartidosPerdidos = 5, PartidosEmpatados = 5 },
        new Equipo { Id = 6, Nombre = "El Nacional",Logo = "nacional.png", PartidosJugados = 8, PartidosGanados = 6, PartidosPerdidos = 6, PartidosEmpatados = 6 },
        new Equipo { Id = 7, Nombre = "Técnico Universitario",Logo = "tecnico.png", PartidosJugados = 8, PartidosGanados = 5, PartidosPerdidos = 10, PartidosEmpatados = 3 },
        new Equipo { Id = 8, Nombre = "Universidad Católica",Logo = "cato.png", PartidosJugados = 8, PartidosGanados = 11, PartidosPerdidos = 5, PartidosEmpatados = 2 },
        new Equipo { Id = 9, Nombre = "Orense",Logo = "orense.png", PartidosJugados = 7, PartidosGanados = 3, PartidosPerdidos = 11, PartidosEmpatados = 3 },
        new Equipo { Id = 10, Nombre = "Vinotinto",Logo = "venecos.png", PartidosJugados = 8, PartidosGanados = 2, PartidosPerdidos = 15, PartidosEmpatados = 3 },
        new Equipo { Id = 11, Nombre = "Dep. Cuenca",Logo = "cuenca.png", PartidosJugados = 8, PartidosGanados = 4, PartidosPerdidos = 10, PartidosEmpatados = 2 },
        new Equipo { Id = 12, Nombre = "Libertad FC",Logo = "libertad.png", PartidosJugados = 8, PartidosGanados = 3, PartidosPerdidos = 12, PartidosEmpatados = 3 },
        new Equipo { Id = 13, Nombre = "Manta FC",Logo = "manta.png", PartidosJugados = 8, PartidosGanados = 8, PartidosPerdidos = 8, PartidosEmpatados = 2 },
        new Equipo { Id = 14, Nombre = "Macará",Logo = "macara.png", PartidosJugados = 8, PartidosGanados = 6, PartidosPerdidos = 9, PartidosEmpatados = 3 },
        new Equipo { Id = 15, Nombre = "Mushuc Runa SC",Logo = "runa.png", PartidosJugados = 8, PartidosGanados = 5, PartidosPerdidos = 10, PartidosEmpatados = 3 },
        new Equipo { Id = 16, Nombre = "Ind. del Valle",Logo = "idv.png", PartidosJugados = 8, PartidosGanados = 17, PartidosPerdidos = 2, PartidosEmpatados = 0 }
    };

            return equipos.OrderByDescending(e => e.Puntos).ToList();
        }


        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }

    }
}
