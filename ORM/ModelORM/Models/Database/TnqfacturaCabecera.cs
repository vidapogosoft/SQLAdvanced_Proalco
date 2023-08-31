using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class TnqfacturaCabecera
    {
        public string RucEmpresa { get; set; } = null!;
        public string IdFactura { get; set; } = null!;
        public string CodigoEstablecimiento { get; set; } = null!;
        public string PuntotoEmision { get; set; } = null!;
        public string NumeroFactura { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string DirecccionEstablecimiento { get; set; } = null!;
        public string TipoIdentificacionComprador { get; set; } = null!;
        public string NumeroIdentificacion { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public decimal TotalSinImpu { get; set; }
        public decimal TotalDescuentos { get; set; }
        public decimal Propina { get; set; }
        public decimal ImporteTotal { get; set; }
        public string Moneda { get; set; } = null!;
        public bool Procesado { get; set; }
        public string? DetaAdic1 { get; set; }
        public string? DetaAdic2 { get; set; }
        public string? DetaAdic3 { get; set; }
        public string? Email { get; set; }
    }
}
