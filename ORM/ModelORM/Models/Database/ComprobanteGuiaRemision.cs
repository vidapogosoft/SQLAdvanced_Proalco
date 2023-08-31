using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class ComprobanteGuiaRemision
    {
        public int IdComprobanteGuiaRemision { get; set; }
        public int IdEmpresa { get; set; }
        public string NumeroGuiaRemision { get; set; } = null!;
        public double ImporteTotal { get; set; }
        public DateTime FechaEmision { get; set; }
        public string ClienteNombre { get; set; } = null!;
        public string ClienteIdentificacion { get; set; } = null!;
        public string? NumeroAutorizacion { get; set; }
        public string? ClaveContingencia { get; set; }
        public DateTime? FechaAutorizacion { get; set; }
        public string? ClaveAcceso { get; set; }
        public string XmlComprobanteGuiaRemision { get; set; } = null!;
        public string? XmlComprobanteGuiaRemisionAutorizado { get; set; }
        public string? EmailDestino { get; set; }
        public bool? EmailEnviado { get; set; }
        public string Estado { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public string? SubTipoComprobante { get; set; }
        public bool? EmailLeido { get; set; }
    }
}
