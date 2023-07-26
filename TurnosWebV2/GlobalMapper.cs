using AutoMapper;
using CapaDA.Dtos;
using CapaDA.Models;

namespace TurnosWebV2
{
    public class GlobalMapper : Profile
    {

        public GlobalMapper()
        {
            CreateMap<ServiciosDto, Servicios>().ReverseMap(); 
            CreateMap<TurnosDto, Turnos>().ReverseMap();
        }
    }
}
