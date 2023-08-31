using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class FacturaFormaPago
    {
        public int IdFacturaFormaPago { get; set; }
        public int IdFactura { get; set; }
        public string FormaPago { get; set; } = null!;
        public decimal? Total { get; set; }
        public string Plazo { get; set; } = null!;
        public string UnidadTiempo { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModificacion { get; set; }

        public virtual Factura IdFacturaNavigation { get; set; } = null!;
    }
}
