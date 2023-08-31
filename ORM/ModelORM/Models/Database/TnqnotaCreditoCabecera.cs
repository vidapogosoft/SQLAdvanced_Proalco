using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class TnqnotaCreditoCabecera
    {
        public string RucEmpresa { get; set; } = null!;
        public string IdNotaCredito { get; set; } = null!;
        public string CodigoEstablecimiento { get; set; } = null!;
        public string PuntoEmision { get; set; } = null!;
        public string NumeroNotaCredito { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string DirecccionEstablecimiento { get; set; } = null!;
        public string TipoIdentificacionComprador { get; set; } = null!;
        public string NumeroIdentificacion { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string CodigoDocumentoModificado { get; set; } = null!;
        public string NumeroDocumentoModificado { get; set; } = null!;
        public DateTime FechaEmisionDocumentoSustento { get; set; }
        public double TotalSinImpu { get; set; }
        public double ValorModificacion { get; set; }
        public string Moneda { get; set; } = null!;
        public string Motivo { get; set; } = null!;
        public bool Procesado { get; set; }
        public string? DetaAdic1 { get; set; }
        public string? DetaAdic2 { get; set; }
        public string? DetaAdic3 { get; set; }
        public string? Email { get; set; }
    }
}
