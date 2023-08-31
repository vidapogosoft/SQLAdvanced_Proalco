using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class CatalogoDetalle
    {
        public string IdCatalogo { get; set; } = null!;
        public string IdCatalogoDetalle { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Auxiliar1 { get; set; }
        public string? Auxiliar2 { get; set; }
        public int? Ordenamiento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string? Estado { get; set; }
    }
}
