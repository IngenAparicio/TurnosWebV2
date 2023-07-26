using CapaDA.Dtos;
using CapaDA.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBL.MainServices
{
    public interface IMainServices
    {
        public ResponseQuery<List<ServiciosDto>> ListaServicios(ResponseQuery<List<ServiciosDto>> response);
        public ResponseQuery<List<TurnosDto>> ListaConsultaServicios(ConsultaServiciosDto request, ResponseQuery<List<TurnosDto>> response);
    }
}
