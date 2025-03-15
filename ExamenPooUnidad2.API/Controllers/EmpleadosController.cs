using System.Security.Cryptography.X509Certificates;
using ExamenPooUnidad2.API.DataBase.Entities;
using ExamenPooUnidad2.API.Dtos.Common;
using ExamenPooUnidad2.API.Dtos.Empleado;
using ExamenPooUnidad2.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExamenPooUnidad2.API.Controllers
{
    [ApiController]
    [Route("api/empleados")]
    public class EmpleadosController : ControllerBase
    {
        public readonly  IEmpleadosService _empleadosService;

        public EmpleadosController(IEmpleadosService empleadosService)
        {
            _empleadosService = empleadosService;
        }




        [HttpPost]
        public async Task<ActionResult<ResponseDto<EmpleadoEntity>>> Post([FromBody] EmpleadoCreateDto dto)
        {
            var response = await _empleadosService.CreateAsync(dto);

            return StatusCode(response.StatusCode, new
            {
                response.Status,
                response.Message,
                response.Data
            });
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseDto<EmpleadoActionResponseDto>>> Delete(Guid id)
        {
            var response = await _empleadosService.DeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResponseDto<EmpleadoActionResponseDto>>> Edit([FromBody] EmpleadoEditDto dto, Guid id)
        {
            var response = await _empleadosService.EditAsync(dto, id);
            return StatusCode(response.StatusCode, response);
        }

    }
}
