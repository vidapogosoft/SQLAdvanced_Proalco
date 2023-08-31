using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class SricodigosSubTipoComprobante
    {
        public int IdSubTipoComprobante { get; set; }
        public string CodigoSubTipoComprobante { get; set; } = null!;
        public string DescripcionSubTipoComprobante { get; set; } = null!;
        public string CodigoTipoComprobante { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public int UsuarioIngreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int UsuarioModifico { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
