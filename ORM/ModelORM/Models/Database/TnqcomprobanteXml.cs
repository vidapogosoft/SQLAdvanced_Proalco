using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class TnqcomprobanteXml
    {
        public string ClaveAccesoCliente { get; set; } = null!;
        public string TipoComprobante { get; set; } = null!;
        public string RucEmpresa { get; set; } = null!;
        public string XmlComprobante { get; set; } = null!;
        public string Procesado { get; set; } = null!;
        public string? Email { get; set; }
        public string? NumeroComprobante { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public string? ClaveAccesoInterno { get; set; }
        public string? SubTipoComprobante { get; set; }
    }
}
