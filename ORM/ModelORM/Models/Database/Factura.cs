using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Factura
    {
        public Factura()
        {
            FacturaFormaPagos = new HashSet<FacturaFormaPago>();
        }

        public int IdFactura { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string NumeroFactura { get; set; } = null!;
        public string? SubTipoComprobante { get; set; }
        public DateTime FechaEmision { get; set; }
        public int? IdReceptor { get; set; }
        public decimal TotalDescuento { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Propina { get; set; }
        public decimal TotalIva { get; set; }
        public decimal TotalIce { get; set; }
        public decimal TotalIrbpnr { get; set; }
        public decimal ImporteTotal { get; set; }
        public string? NumeroAutorizacion { get; set; }
        public string? Nombre1 { get; set; }
        public string? Descripcion1 { get; set; }
        public string? Nombre2 { get; set; }
        public string? Descripcion2 { get; set; }
        public string? Nombre3 { get; set; }
        public string? Descripcion3 { get; set; }
        public string? Nombre4 { get; set; }
        public string? Descripcion4 { get; set; }
        public string? Nombre5 { get; set; }
        public string? Descripcion5 { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string NumeroSecuencial { get; set; } = null!;
        public string? DirecccionEstablecimiento { get; set; }
        public string TipoIdentificacionComprador { get; set; } = null!;
        public string NumeroIdentificacion { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public bool Procesado { get; set; }
        public string? Email { get; set; }
        public string DirecccionMatriz { get; set; } = null!;
        public string? DireccionEstablecimientoCliente { get; set; }
        public string? Tipo { get; set; }
        public decimal DescuentoAdicional { get; set; }
        public decimal TotalSubsidio { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
        public virtual Sucursal IdSucursalNavigation { get; set; } = null!;
        public virtual ICollection<FacturaFormaPago> FacturaFormaPagos { get; set; }
    }
}
