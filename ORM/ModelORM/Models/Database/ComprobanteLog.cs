using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class ComprobanteLog
    {
        public int IdLog { get; set; }
        public int IdEmpresa { get; set; }
        public string RucEmpresa { get; set; } = null!;
        public string TipoComprobante { get; set; } = null!;
        public string NumeroComprobante { get; set; } = null!;
        public string? ClaveContingencia { get; set; }
        public DateTime FechaLog { get; set; }
        public string XmlOrigenError { get; set; } = null!;
        public string XmlComprobanteError { get; set; } = null!;
        public string? SubTipoComprobante { get; set; }
    }
}
