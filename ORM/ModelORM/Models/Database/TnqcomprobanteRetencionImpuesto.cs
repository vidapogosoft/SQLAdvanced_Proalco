using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class TnqcomprobanteRetencionImpuesto
    {
        public string RucEmpresa { get; set; } = null!;
        public string IdComprobanteRetencion { get; set; } = null!;
        public int SecuencialImpuesto { get; set; }
        public int CodigoImpuesto { get; set; }
        public string CodigoRetencion { get; set; } = null!;
        public double BaseImponible { get; set; }
        public int IdPorcentaje { get; set; }
        public double ValorRetenido { get; set; }
        public string? CodigoDocumentoSustento { get; set; }
        public string? NumeroDocumentoSustento { get; set; }
        public DateTime? FechaEmisionDocumentoSustento { get; set; }
    }
}
