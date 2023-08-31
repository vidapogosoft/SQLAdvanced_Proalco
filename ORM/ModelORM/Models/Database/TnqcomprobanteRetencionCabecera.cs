using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class TnqcomprobanteRetencionCabecera
    {
        public string RucEmpresa { get; set; } = null!;
        public string IdComprobanteRetencion { get; set; } = null!;
        public string CodigoEstablecimiento { get; set; } = null!;
        public string PuntoEmision { get; set; } = null!;
        public string NumeroComprobanteRetencion { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string DirecccionEstablecimiento { get; set; } = null!;
        public string TipoIdentificacionComprador { get; set; } = null!;
        public string NumeroIdentificacion { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public DateTime PeriodoFiscal { get; set; }
        public bool Procesado { get; set; }
        public string? DetaAdic1 { get; set; }
        public string? DetaAdic2 { get; set; }
        public string? DetaAdic3 { get; set; }
        public string? Email { get; set; }
    }
}
