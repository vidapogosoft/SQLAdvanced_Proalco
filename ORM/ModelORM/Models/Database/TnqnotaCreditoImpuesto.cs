using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class TnqnotaCreditoImpuesto
    {
        public string RucEmpresa { get; set; } = null!;
        public string IdNotaCredito { get; set; } = null!;
        public int SecuencialProducto { get; set; }
        public string CodigoInterno { get; set; } = null!;
        public string? CodigoAdicional { get; set; }
        /// <summary>
        /// Codigo del impuesto aplicado, IVA(12%),IVA(0%), ICE, etc
        /// </summary>
        public int IdImpuesto { get; set; }
        /// <summary>
        /// codigo del valor del porcentaje, 12%,0%,10%, etc
        /// </summary>
        public int IdPorcentaje { get; set; }
        /// <summary>
        /// tarifa de impuesto aplicado a cada producto es decir, 12,0,etc
        /// </summary>
        public int Tarifa { get; set; }
        public double BaseImponible { get; set; }
        public double Valor { get; set; }
    }
}
