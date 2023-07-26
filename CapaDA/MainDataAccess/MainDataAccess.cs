using AutoMapper;
using CapaDA.Dtos;
using CapaDA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDA.MainDataAccess
{
    public class MainDataAccess : IMainDataAccess
    {
        protected PermisosDbContext context;
        private readonly IMapper mapper;

        public MainDataAccess(PermisosDbContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public List<ServiciosDto> ListaServicios()
        {
            List<Servicios> lista = new List<Servicios>();
            lista = context.Servicios.ToList();
            return mapper.Map<List<ServiciosDto>>(lista);
        }

        public List<TurnosDto> ListaConsultaServicios(ConsultaServiciosDto request)
        {
            StringBuilder query = new StringBuilder("exec [dbo].[ConsultaServicios] ");
            query.Append($"@id_servicio = {request.IdServicio}");
            var entidad =  context.ConsultaServicios.FromSqlRaw(query.ToString()).ToList();
            
                List<Turnos> turnos = new List<Turnos>();

                if (entidad != null)
                {
                    var horaInicio = entidad[0].HoraApertura;
                    var horaFin = entidad[0].HoraCierre;
                    var duracion = entidad[0].Duracion;
                    var fecha1 = request.FechaInicio.ToString();
                    var fechaInicio = DateTime.Parse(fecha1);
                    var fechaFin = request.FechaFin;
                    for (var i = fechaInicio; i <= fechaFin; i = i.AddDays(1))
                    {
                        for (TimeSpan? j = horaInicio; j < horaFin; j = j + duracion)
                        {
                            Turnos turno = new Turnos();
                            turno.IdServicio = entidad[0].IdServicio;
                            turno.FechaTurno = i;
                            turno.HoraInicio = j;
                            turno.HoraFin = j + duracion;
                            turno.Estado = "Activo";
                            turnos.Add(turno);
                        }
                    }
                }
                context.Turnos.AddRange(turnos);
                context.SaveChangesAsync();
                return mapper.Map<List<TurnosDto>>(turnos);          
        }
    }
}
