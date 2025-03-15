using AutoMapper;
using ExamenPooUnidad2.API.DataBase;
using ExamenPooUnidad2.API.Dtos.Common;
using ExamenPooUnidad2.API.Dtos.Empleado;
using ExamenPooUnidad2.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using ExamenPooUnidad2.API.Constants;
using ExamenPooUnidad2.API.DataBase.Entities;

namespace ExamenPooUnidad2.API.Services
{
    public class EmpleadosService : IEmpleadosService
    {
        private readonly PagoPlanillasDbContext _context;
        private readonly IMapper _mapper;

        public EmpleadosService(PagoPlanillasDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ResponseDto<EmpleadoActionResponseDto>> CreateAsync(EmpleadoCreateDto dto)
        {

            var empleadoEntity = _mapper.Map<EmpleadoEntity>(dto);

            _context.Empleados.Add(empleadoEntity);
            await _context.SaveChangesAsync(); //Para cambiar los datos 



            return new ResponseDto<EmpleadoActionResponseDto>
            {
                StatusCode = HttpStatusCode.CREATED,
                Status = true,
                Message = "Registro Creado Correctamente",
                Data = _mapper.Map<EmpleadoActionResponseDto>(empleadoEntity)
            };




        }

        public async Task<ResponseDto<EmpleadoActionResponseDto>> DeleteAsync(Guid id)


        {
            var empleadoEntity = await _context.Empleados.FirstOrDefaultAsync(x => x.Id == id);

            if (empleadoEntity != null)
            {
                return new ResponseDto<EmpleadoActionResponseDto>
                {
                    StatusCode = HttpStatusCode.NOT_FOUND,
                    Status = false,
                    Message = "No se encuentra registrado el empleado"
                };


            }

            empleadoEntity.Activo = false;

            _context.Empleados.Update(empleadoEntity);
            await _context.SaveChangesAsync();

            return new ResponseDto<EmpleadoActionResponseDto>
            {
                StatusCode = HttpStatusCode.OK,
                Status = true,
                Message = "El Empleado se elimino correctamente",
                Data = _mapper.Map<EmpleadoActionResponseDto>(empleadoEntity)
            };
        }


        public async Task<ResponseDto<EmpleadoActionResponseDto>> EditAsync(EmpleadoEditDto dto, Guid id)
        {
            var personEntity = await _context.Empleados.FirstOrDefaultAsync(x => x.Id == id);

            if (personEntity is null)
            {
                return new ResponseDto<EmpleadoActionResponseDto>
                {
                    StatusCode = HttpStatusCode.NOT_FOUND,
                    Status = false,
                    Message = "Registro no encontrado",
                };

            }

            _mapper.Map<EmpleadoEditDto, EmpleadoEntity>(dto, personEntity);

            _context.Empleados.Update(personEntity);
            await _context.SaveChangesAsync();

            return new ResponseDto<EmpleadoActionResponseDto>
            {
                StatusCode = HttpStatusCode.OK,
                Status = true,
                Message = "Registro editado corretamente",
                Data = _mapper.Map<EmpleadoActionResponseDto>(personEntity)
            };
        }
    }
}
