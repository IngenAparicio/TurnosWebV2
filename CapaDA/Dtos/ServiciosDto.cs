
using System;

namespace CapaDA.Dtos
{
    public class ServiciosDto
    {
        public int IdServicio { get; set; }
        public int? IdComercio { get; set; }
        public string NomServicio { get; set; }
        public TimeSpan? HoraApertura { get; set; }
        public TimeSpan? HoraCierre { get; set; }
        public TimeSpan? Duracion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
