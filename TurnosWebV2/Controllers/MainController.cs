using CapaBL.MainServices;
using CapaDA.Dtos;
using CapaDA.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TurnosWebV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : Controller
    {
        readonly IMainServices mainServices;

        public MainController(IMainServices _mainServices)
        {
            mainServices = _mainServices;
        }

        [HttpPost]
        [Route("ListaServicios")]        
        public IActionResult ListaServicios()
        {
            ResponseQuery<List<ServiciosDto>> response = new ResponseQuery<List<ServiciosDto>>();
            mainServices.ListaServicios(response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("ListaConsultaServicios")]
        public IActionResult ListaConsultaServicios(ConsultaServiciosDto request)
        {
            ResponseQuery<List<TurnosDto>> response = new ResponseQuery<List<TurnosDto>>();
            mainServices.ListaConsultaServicios(request, response);
            return Ok(response.Result);
        }
    }
}
