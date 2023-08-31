using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Empleado
    {
        public int IdEmpleado { get; set; }
        public string? Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModificacion { get; set; }

        public virtual Persona IdEmpleadoNavigation { get; set; } = null!;
    }
}
