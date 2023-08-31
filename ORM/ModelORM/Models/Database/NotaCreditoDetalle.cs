using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class NotaCreditoDetalle
    {
        public int IdNotaCreditoDetalles { get; set; }
        public int IdNotaCredito { get; set; }
        public int IdEmpresa { get; set; }
        public int? IdItem { get; set; }
        public string? OtroConcepto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Descuento { get; set; }
        public decimal PrecioTotalSinImpuesto { get; set; }
        public string Iva { get; set; } = null!;
        public decimal PorcentajeIva { get; set; }
        public decimal ValorIva { get; set; }
        public string? Ice { get; set; }
        public decimal BaseImponibleIce { get; set; }
        public decimal PorcentajeIce { get; set; }
        public decimal ValorIce { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string CodigoInterno { get; set; } = null!;
        public string? CodigoAdicional { get; set; }
        public string? Descripcion { get; set; }
        public string? Descripcion1 { get; set; }
        public string? Descripcion2 { get; set; }
        public string? Descripcion3 { get; set; }
        public string? Atributo1 { get; set; }
        public string? Atributo2 { get; set; }
        public string? Atributo3 { get; set; }
    }
}
