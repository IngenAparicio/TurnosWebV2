
using System;

namespace CapaDA.Dtos
{
    public class ConsultaServiciosDto
    {
        public int IdServicio { get; set; }        
        public string NomServicio { get; set; }
        public TimeSpan? HoraApertura { get; set; }
        public TimeSpan? HoraCierre { get; set; }
        public TimeSpan? Duracion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
