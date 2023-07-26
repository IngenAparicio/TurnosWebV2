using CapaDA.Dtos;
using CapaDA.MainDataAccess;
using CapaDA.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBL.MainServices
{
    public class MainServices : IMainServices
    {
        private readonly IMainDataAccess mainDataAccess;
        public MainServices(IMainDataAccess _mainDataAccess)
        {
            mainDataAccess = _mainDataAccess;
        }

        public ResponseQuery<List<ServiciosDto>> ListaServicios(ResponseQuery<List<ServiciosDto>> response)
        {
            try
            {
                response.Result = mainDataAccess.ListaServicios();
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new List<ServiciosDto>();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<List<TurnosDto>> ListaConsultaServicios(ConsultaServiciosDto request, ResponseQuery<List<TurnosDto>> response)
        {
            try
            {
                response.Result = mainDataAccess.ListaConsultaServicios(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new List<TurnosDto>();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }
    }
}
