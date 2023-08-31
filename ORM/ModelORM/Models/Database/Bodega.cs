using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Bodega
    {
        public Bodega()
        {
            InventarioItemMovimientos = new HashSet<InventarioItemMovimiento>();
            InventarioItems = new HashSet<InventarioItem>();
        }

        public int IdBodega { get; set; }
        public int IdEmpresa { get; set; }
        public string Descripcion { get; set; } = null!;
        public string TipoBodega { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Responsable { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModificacion { get; set; }

        public virtual ICollection<InventarioItemMovimiento> InventarioItemMovimientos { get; set; }
        public virtual ICollection<InventarioItem> InventarioItems { get; set; }
    }
}
