using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class NotaCredito
    {
        public int IdNotaCredito { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string NumeroNotaCredito { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public decimal TotalDescuento { get; set; }
        public int? IdReceptor { get; set; }
        public decimal Subtotal { get; set; }
        public decimal TotalIva { get; set; }
        public decimal TotalIce { get; set; }
        public decimal ImporteTotal { get; set; }
        public string Motivo { get; set; } = null!;
        public string? Atributo1 { get; set; }
        public string? Atributo2 { get; set; }
        public string? Atributo3 { get; set; }
        public string? Atributo4 { get; set; }
        public string? Atributo5 { get; set; }
        public string? DetaAdic1 { get; set; }
        public string? DetaAdic2 { get; set; }
        public string? DetaAdic3 { get; set; }
        public string? DetaAdic4 { get; set; }
        public string? DetaAdic5 { get; set; }
        public string? Email { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioCreacion { get; set; }
        public string? UsuarioModificacion { get; set; }
        public string? Estado { get; set; }
        public string? NumeroFactura { get; set; }
        public DateTime? FechaFactura { get; set; }
        public string? CodigoDocumentoModificado { get; set; }
        public double? ValorModificacion { get; set; }
        public string NumeroSecuencial { get; set; } = null!;
        public string? DirecccionEstablecimiento { get; set; }
        public string TipoIdentificacionComprador { get; set; } = null!;
        public string NumeroIdentificacion { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public bool Procesado { get; set; }
        public string DirecccionMatriz { get; set; } = null!;

        public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
        public virtual Sucursal IdSucursalNavigation { get; set; } = null!;
    }
}
