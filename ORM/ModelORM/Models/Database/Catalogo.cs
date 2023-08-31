using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Catalogo
    {
        public string IdCatalogo { get; set; } = null!;
        public string? Codigo { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string? Estado { get; set; }
    }
}
