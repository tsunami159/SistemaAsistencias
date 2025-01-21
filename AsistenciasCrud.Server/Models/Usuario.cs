using System;
using System.Collections.Generic;

namespace AsistenciasCrud.Server.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string CorreoElectronico { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? TipoUsuario { get; set; }

    public DateOnly FechaRegistro { get; set; }

    public virtual ICollection<Asistencia> Asistencia { get; set; } = new List<Asistencia>();

}
