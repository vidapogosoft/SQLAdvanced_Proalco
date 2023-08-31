using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class UsuarioDetalle
    {
        public int IdUsuario { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? Nombre1 { get; set; }
        public string? Nombre2 { get; set; }
        public string? TelefonoConvencional { get; set; }
        public string? Celular { get; set; }
        public string? Direccion { get; set; }
        public string? Email { get; set; }
        public int IdEstado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int UsuarioModificacion { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}
