using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class FacturaDetalle
    {
        public int IdFacturaDetalle { get; set; }
        public int IdEmpresa { get; set; }
        public int IdFactura { get; set; }
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
        public string? Irbpnr { get; set; }
        public decimal BaseImponibleIrbpnr { get; set; }
        public decimal PorcentajeIrbpnr { get; set; }
        public decimal ValorIrbpnr { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string RucEmpresa { get; set; } = null!;
        public string CodigoInterno { get; set; } = null!;
        public string? CodigoAdicional { get; set; }
        public string? Descripcion { get; set; }
        public string? NumeroSecuencial { get; set; }
        public string? Atributo1 { get; set; }
        public string? DescripcionAtributo1 { get; set; }
        public string? Atributo2 { get; set; }
        public string? DescripcionAtributo2 { get; set; }
        public string? Atributo3 { get; set; }
        public string? DescripcionAtributo3 { get; set; }
        public decimal BaseImponibleIva { get; set; }
        public decimal PrecioSinSubsidio { get; set; }
    }
}
