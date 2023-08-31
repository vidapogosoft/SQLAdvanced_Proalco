using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class TnqfacturaDetalle
    {
        public string RucEmpresa { get; set; } = null!;
        public string IdFactura { get; set; } = null!;
        public int SecuencialProducto { get; set; }
        public string CodigoInterno { get; set; } = null!;
        public string? CodigoAdicional { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorDescuento { get; set; }
        public decimal ValorTotalSinImpuesto { get; set; }
        public string? DetalleAdicional1 { get; set; }
        public string? DetalleAdicional2 { get; set; }
        public string? DetalleAdicional3 { get; set; }
        public string? DetalleAdicional4 { get; set; }
        public string? DetalleAdicional5 { get; set; }
    }
}
