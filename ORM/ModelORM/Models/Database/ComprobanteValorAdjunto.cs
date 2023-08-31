using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class ComprobanteValorAdjunto
    {
        public int IdComprobanteValorAdjunto { get; set; }
        public string NumeroComprobante { get; set; } = null!;
        public string? TipoComprobante { get; set; }
        public string? SubTipoComprobante { get; set; }
        public int IdEmpresa { get; set; }
        public string ValorAdjunto { get; set; } = null!;
        public bool Estado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
