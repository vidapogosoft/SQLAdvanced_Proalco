using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class TnqguiaRemisionDestinatario
    {
        public string RucEmpresa { get; set; } = null!;
        public string IdGuiaRemision { get; set; } = null!;
        public int SecDestinatario { get; set; }
        public string IdentificacionDestinatario { get; set; } = null!;
        public string RazonSocialDestinatario { get; set; } = null!;
        public string DireccionDestinatario { get; set; } = null!;
        public string MotivoTraslado { get; set; } = null!;
        public string? DocAduaneroUnico { get; set; }
        public string? CodEstablecimientoDestino { get; set; }
        public string? Ruta { get; set; }
        public string? CodigoDocumentoSustento { get; set; }
        public string? NumeroDocumentoSustento { get; set; }
        public string? NumeroAuthDocumentoSustento { get; set; }
        public DateTime? FechaEmisionDocumentoSustento { get; set; }
        public string? DetalleAdicional1 { get; set; }
        public string? DetalleAdicional2 { get; set; }
        public string? DetalleAdicional3 { get; set; }
        public string? DetalleAdicional4 { get; set; }
        public string? DetalleAdicional5 { get; set; }
    }
}
