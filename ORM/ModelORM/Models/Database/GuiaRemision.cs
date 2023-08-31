using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class GuiaRemision
    {
        public int IdGuiaRemision { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string NumeroGuiaRemision { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public int IdPersona { get; set; }
        public string DireccionPartida { get; set; } = null!;
        public string? DireccionDestino { get; set; }
        public string MotivoTraslado { get; set; } = null!;
        public string? NumeroSecuencial { get; set; }
        public string Ruta { get; set; } = null!;
        public int IdProveedor { get; set; }
        public string? DocumentoAduanero { get; set; }
        public DateTime FechaInicioTransporte { get; set; }
        public DateTime FechaFinTransporte { get; set; }
        public int? IdVehiculo { get; set; }
        public string PlacaCamion { get; set; } = null!;
        public string? NumeroFactura { get; set; }
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
        public string Moneda { get; set; } = null!;
        public bool Procesado { get; set; }
        public string? Email { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string? CodigoDocumentoSustento { get; set; }
        public string? NumeroDocumentoSustento { get; set; }
        public DateTime? FechaEmisionDocumentoSustento { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
        public virtual Persona IdPersonaNavigation { get; set; } = null!;
        public virtual Persona IdProveedorNavigation { get; set; } = null!;
        public virtual Sucursal IdSucursalNavigation { get; set; } = null!;
    }
}
