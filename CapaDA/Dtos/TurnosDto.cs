
using System;

namespace CapaDA.Dtos
{
    public class TurnosDto
    {
        public int IdTurno { get; set; }
        public int? IdServicio { get; set; }
        public DateTime? FechaTurno { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string Estado { get; set; }
    }
}
