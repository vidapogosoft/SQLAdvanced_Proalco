using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class GarantiaProducto
    {
        public int IdGarantiaProducto { get; set; }
        public int IdDocumento { get; set; }
        public int IdProducto { get; set; }
        public int IdGarantia { get; set; }
        public string DescripcionProducto { get; set; } = null!;
        public string DescripcionGarantia { get; set; } = null!;
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string Estado { get; set; } = null!;
    }
}
