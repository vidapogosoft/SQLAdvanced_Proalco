using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class SricodigosComprobante
    {
        public int IdCodigoComprobante { get; set; }
        public string DescripcionComprobante { get; set; } = null!;
        public string CodigoComprobante { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string UsuarioIngreso { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public string? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
