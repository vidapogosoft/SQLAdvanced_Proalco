using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class InventarioItemMovimiento
    {
        public InventarioItemMovimiento()
        {
            InventarioItemMovimientoDetalles = new HashSet<InventarioItemMovimientoDetalle>();
        }

        public int IdInventarioItemMovimiento { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public int IdBodega { get; set; }
        public int? IdProveedor { get; set; }
        public string IdTipoMovimiento { get; set; } = null!;
        public string IdMotivoMovimiento { get; set; } = null!;
        public int? IdTransferencia { get; set; }
        public string? DocumentoRespaldo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string Estado { get; set; } = null!;

        public virtual Bodega IdBodegaNavigation { get; set; } = null!;
        public virtual ICollection<InventarioItemMovimientoDetalle> InventarioItemMovimientoDetalles { get; set; }
    }
}
