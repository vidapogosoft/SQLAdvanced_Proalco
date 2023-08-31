using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class InventarioItemMovimientoDetalle
    {
        public int IdInventarioItemMovimientoDetalle { get; set; }
        public int IdInventarioItemMovimiento { get; set; }
        public int IdItem { get; set; }
        public decimal Cantidad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string Estado { get; set; } = null!;

        public virtual InventarioItemMovimiento IdInventarioItemMovimientoNavigation { get; set; } = null!;
        public virtual Item IdItemNavigation { get; set; } = null!;
    }
}
