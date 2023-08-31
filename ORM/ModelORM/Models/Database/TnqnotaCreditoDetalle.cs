using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class TnqnotaCreditoDetalle
    {
        public string RucEmpresa { get; set; } = null!;
        public string IdNotaCredito { get; set; } = null!;
        public int SecuencialProducto { get; set; }
        public string CodigoProducto { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public short Cantidad { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorDescuento { get; set; }
        public double ValorTotalSinImpuesto { get; set; }
        public string? DetalleAdicional1 { get; set; }
        public string? DetalleAdicional2 { get; set; }
        public string? DetalleAdicional3 { get; set; }
        public string? DetalleAdicional4 { get; set; }
        public string? DetalleAdicional5 { get; set; }
    }
}
