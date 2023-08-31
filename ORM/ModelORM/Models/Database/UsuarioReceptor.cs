using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class UsuarioReceptor
    {
        public int IdUsuarioReceptor { get; set; }
        public string NombreUsuario { get; set; } = null!;
        public string? Password { get; set; }
        public bool? CambiarClave { get; set; }
        public bool? RecibirSms { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioCreacion { get; set; }
        public string? UsuarioModificacion { get; set; }
    }
}
