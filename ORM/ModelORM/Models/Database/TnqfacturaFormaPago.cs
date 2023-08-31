using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class TnqfacturaFormaPago
    {
        public string RucEmpresa { get; set; } = null!;
        public string IdFactura { get; set; } = null!;
        public int SecuencialFormaPago { get; set; }
        public string CodigoFormaPago { get; set; } = null!;
        public decimal? Total { get; set; }
        public int? Plazo { get; set; }
        public string? UnidadTiempo { get; set; }
    }
}
