using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Imagen
    {
        public int? IdEmpresa { get; set; }
        public int IdImagen { get; set; }
        public int IdReferencia { get; set; }
        public string TipoItem { get; set; } = null!;
        public string Ruta { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
    }
}
