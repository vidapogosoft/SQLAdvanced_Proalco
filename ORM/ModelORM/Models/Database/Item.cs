using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Item
    {
        public Item()
        {
            GuiaRemisionDetalles = new HashSet<GuiaRemisionDetalle>();
            InventarioItemMovimientoDetalles = new HashSet<InventarioItemMovimientoDetalle>();
            InventarioItems = new HashSet<InventarioItem>();
        }

        public int IdEmpresa { get; set; }
        public int IdItem { get; set; }
        public string CodigoPrincipal { get; set; } = null!;
        public string? CodigoAuxiliar { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal PrecioUnitario { get; set; }
        public string TipoBien { get; set; } = null!;
        public string Iva { get; set; } = null!;
        public string? Atributo1 { get; set; }
        public string? DescripcionAtributo1 { get; set; }
        public string? Atributo2 { get; set; }
        public string? DescripcionAtributo2 { get; set; }
        public string? Atributo3 { get; set; }
        public string? DescripcionAtributo3 { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public int? IdItemSubCategoria { get; set; }
        public int? IdItemCategoria { get; set; }

        public virtual ICollection<GuiaRemisionDetalle> GuiaRemisionDetalles { get; set; }
        public virtual ICollection<InventarioItemMovimientoDetalle> InventarioItemMovimientoDetalles { get; set; }
        public virtual ICollection<InventarioItem> InventarioItems { get; set; }
    }
}
