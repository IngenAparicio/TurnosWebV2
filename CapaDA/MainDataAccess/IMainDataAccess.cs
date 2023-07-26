using CapaDA.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDA.MainDataAccess
{
    public interface IMainDataAccess
    {
        public List<ServiciosDto> ListaServicios();
        public List<TurnosDto> ListaConsultaServicios(ConsultaServiciosDto request);
    }
}
