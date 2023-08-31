using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Sucursal
    {
        public Sucursal()
        {
            Facturas = new HashSet<Factura>();
            GuiaRemisions = new HashSet<GuiaRemision>();
            NotaCreditos = new HashSet<NotaCredito>();
            Retencions = new HashSet<Retencion>();
        }

        public int IdSucursal { get; set; }
        public int IdEmpresa { get; set; }
        public string? Nombre { get; set; }
        public string? Ciudad { get; set; }
        public string Direccion { get; set; } = null!;
        public string? Telefono1 { get; set; }
        public string? Telefono2 { get; set; }
        public string? Correo { get; set; }
        public string PuntoEmision { get; set; } = null!;
        public string CodigoEstablecimiento { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string? Estado { get; set; }
        public int? IdBodega { get; set; }
        public string? RutaLogo { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<GuiaRemision> GuiaRemisions { get; set; }
        public virtual ICollection<NotaCredito> NotaCreditos { get; set; }
        public virtual ICollection<Retencion> Retencions { get; set; }
    }
}
