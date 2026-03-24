using Microsoft.AspNetCore.Mvc;
using ListaDeTareas.Services;
using ListaDeTareas.Models;
using ListaDeTareas.Data;
using ListaDeTareas.DTO;

namespace ListaDeTareas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TareaController : ControllerBase
    {

        private readonly TareaService _tareaService;

        public TareaController(TareaService tareaService)
        {
            _tareaService = tareaService;
        }

        [HttpPost]

        public IActionResult AgregarTarea([FromBody] TareaRequestDTO tDto)
        {
            try
            {
                _tareaService.AgregarTarea(tDto.Titulo, tDto.Descripcion, false, DateTime.Now);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok("Tarea agregada exitosamente");
        }

        [HttpGet]

        public ActionResult<List<TareaResponseDTO>> ListarTareas()
        {

            var tareas = _tareaService.ListarTareas();
            var tareaResponse = new List<TareaResponseDTO>();

            foreach (var t in tareas)
            {
                tareaResponse.Add(new TareaResponseDTO
                {
                    Id = t.Id,
                    Titulo = t.Titulo,
                    Descripcion = t.Descripcion,
                    Completada = t.Completada,
                    FechaCreacion = t.FechaCreacion

                });
            }

            return Ok(tareaResponse);

        }

        [HttpPut("{Id}")]

        public IActionResult ModificarTareas(int Id, [FromBody] TareaRequestDTO tDto)
        {
            try
            {
                _tareaService.ModificarTarea(Id, tDto.Titulo, tDto.Descripcion, tDto.Completada);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok("Tarea modificada exitosamente");

        }

        [HttpDelete("{Id}")]
        public IActionResult EliminarTarea(int Id)
        {

            try
            {
                _tareaService.EliminarTarea(Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }

            return Ok("Tarea eliminada exitosamente");

        }
    }
}
