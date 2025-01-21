using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AsistenciasCrud.Server.Models;

namespace AsistenciasCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsistenciaController : ControllerBase
    {
        private readonly AsistenciasContext _dbContext;

        public AsistenciaController(AsistenciasContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("Lista")]
        public async Task<IActionResult> Lista()
        {
            var asistencias = await _dbContext.Asistencias.ToListAsync();
            return Ok(asistencias);
        }

        [HttpGet("Buscar/{id}")]
        public async Task<IActionResult> Buscar(int id)
        {
            var asistencia = await _dbContext.Asistencias.FindAsync(id);
            if (asistencia == null)
                return NotFound("Asistencia no encontrada.");
            return Ok(asistencia);
        }

        [HttpPost("Guardar")]
        public async Task<IActionResult> Guardar(Asistencia asistencia)
        {
            _dbContext.Asistencias.Add(asistencia);
            await _dbContext.SaveChangesAsync();
            return Ok(asistencia.IdAsistencia);
        }

        [HttpPut("Editar/{id}")]
        public async Task<IActionResult> Editar(int id, Asistencia asistencia)
        {
            var dbAsistencia = await _dbContext.Asistencias.FindAsync(id);
            if (dbAsistencia == null)
                return NotFound("Asistencia no encontrada.");

            dbAsistencia.Fecha = asistencia.Fecha;
            dbAsistencia.HoraEntrada = asistencia.HoraEntrada;
            dbAsistencia.HoraSalida = asistencia.HoraSalida;

            _dbContext.Asistencias.Update(dbAsistencia);
            await _dbContext.SaveChangesAsync();
            return Ok(dbAsistencia.IdAsistencia);
        }

        [HttpDelete("Eliminar/{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var asistencia = await _dbContext.Asistencias.FindAsync(id);
            if (asistencia == null)
                return NotFound("Asistencia no encontrada.");

            _dbContext.Asistencias.Remove(asistencia);
            await _dbContext.SaveChangesAsync();
            return Ok("Asistencia eliminada.");
        }
    }
}
