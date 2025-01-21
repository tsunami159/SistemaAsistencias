using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciasCrud.Shared
{
    public class UsuariosIN
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingrese un correo válido.")]
        public string CorreoElectronico { get; set; }

        public string? Telefono { get; set; }
        public string? TipoUsuario { get; set; }
        public DateOnly FechaRegistro { get; set; }
    }


}
