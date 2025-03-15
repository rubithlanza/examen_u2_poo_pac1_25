using AutoMapper;
using ExamenPooUnidad2.API.DataBase.Entities;
using ExamenPooUnidad2.API.Dtos.DetallePlanillas;
using ExamenPooUnidad2.API.Dtos.Empleado;
using ExamenPooUnidad2.API.Dtos.Planillas;

namespace ExamenPooUnidad2.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            

            CreateMap<EmpleadoEntity, EmpleadoDto>();
            CreateMap<EmpleadoEntity, EmpleadoActionResponseDto>();
            CreateMap<EmpleadoCreateDto, EmpleadoEntity>();
            CreateMap <EmpleadoEditDto, EmpleadoEntity>();

            CreateMap<PlanillaEntity, PlanillaDto>();
            CreateMap<PlanillaEntity, DetallePlanillaActionResponseDto>();
            CreateMap<PlanillaCreateDto, PlanillaEntity>();
            CreateMap<PlanillaEditDto, PlanillaEntity>();

            CreateMap<DetallePlanillaEntity, DetallePlanillaDto>();
            CreateMap<DetallePlanillaEntity, DetallePlanillaActionResponseDto>();
            CreateMap<DetallePlanillaDto, DetallePlanillaEntity>();
            CreateMap<DetallePlanillaEditDto, DetallePlanillaEntity>();

        }
    }
}
