using System.ComponentModel.DataAnnotations;

namespace Mi_primera_aplicación_web_MVC.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Display(Name = "Nombre Equipo")]
        [Required]
        public string Nombre { get; set; }
        [Range(0, 20)]
        public string Logo { get; set; }
        public int PartidosJugados { get; set; }
        [Range(0, 20)]
        public int PartidosGanados { get; set; }
        [Range(0, 20)]
        public int PartidosPerdidos { get; set; }
        [Range(0, 20)]
        public int PartidosEmpatados { get; set; }
        public int Puntos { get; set; }

    }
}

