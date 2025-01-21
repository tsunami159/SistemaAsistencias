using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AsistenciasCrud.Server.Models;

namespace AsistenciasCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AsistenciasContext _dbContext;

        public UsuarioController(AsistenciasContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("Lista")]
        public async Task<IActionResult> Lista()
        {
            var usuarios = await _dbContext.Usuarios.ToListAsync();
            return Ok(usuarios);
        }

        [HttpGet("Buscar/{id}")]
        public async Task<IActionResult> Buscar(int id)
        {
            var usuario = await _dbContext.Usuarios.FindAsync(id);
            if (usuario == null)
                return NotFound("Usuario no encontrado.");
            return Ok(usuario);
        }

        [HttpPost("Guardar")]
        public async Task<IActionResult> Guardar([FromBody] Usuario usuario)
        {
            if (!ModelState.IsValid)
                return BadRequest("Modelo de usuario no válido.");

            _dbContext.Usuarios.Add(usuario);
            await _dbContext.SaveChangesAsync();
            return Ok(usuario.IdUsuario);
        }

        [HttpPut("Editar/{id}")]
        public async Task<IActionResult> Editar(int id, [FromBody] Usuario usuario)
        {
            if (!ModelState.IsValid)
                return BadRequest("Modelo de usuario no válido.");

            var dbUsuario = await _dbContext.Usuarios.FindAsync(id);
            if (dbUsuario == null)
                return NotFound("Usuario no encontrado.");

            dbUsuario.Nombre = usuario.Nombre;
            dbUsuario.CorreoElectronico = usuario.CorreoElectronico;
            dbUsuario.Telefono = usuario.Telefono;
            dbUsuario.TipoUsuario = usuario.TipoUsuario;

            _dbContext.Usuarios.Update(dbUsuario);
            await _dbContext.SaveChangesAsync();
            return Ok(dbUsuario.IdUsuario);
        }

        [HttpDelete("Eliminar/{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var usuario = await _dbContext.Usuarios.FindAsync(id);
            if (usuario == null)
                return NotFound("Usuario no encontrado.");

            _dbContext.Usuarios.Remove(usuario);
            await _dbContext.SaveChangesAsync();
            return Ok("Usuario eliminado.");
        }
    }
}
