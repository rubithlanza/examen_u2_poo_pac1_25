using ExamenPooUnidad2.API.DataBase;
using ExamenPooUnidad2.API.Dtos.Common;
using ExamenPooUnidad2.API.Dtos.Empleado;

namespace ExamenPooUnidad2.API.Services.Interfaces
{
    public interface IEmpleadosService
    {
        Task<ResponseDto<EmpleadoActionResponseDto>> CreateAsync(EmpleadoCreateDto dto);
        Task<ResponseDto<EmpleadoActionResponseDto>> DeleteAsync(Guid id);
        Task<ResponseDto<EmpleadoActionResponseDto>> EditAsync(EmpleadoEditDto dto, Guid id);
    }
}
