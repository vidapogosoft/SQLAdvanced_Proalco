using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Empresa
    {
        public Empresa()
        {
            EmpresaEmails = new HashSet<EmpresaEmail>();
            EmpresaUsuarios = new HashSet<EmpresaUsuario>();
            Facturas = new HashSet<Factura>();
            GuiaRemisionDetalles = new HashSet<GuiaRemisionDetalle>();
            GuiaRemisions = new HashSet<GuiaRemision>();
            ModuloEmpresas = new HashSet<ModuloEmpresa>();
            NotaCreditos = new HashSet<NotaCredito>();
            Retencions = new HashSet<Retencion>();
        }

        public int IdEmpresa { get; set; }
        public string NombreComercial { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string Ruc { get; set; } = null!;
        public string? Telefono1 { get; set; }
        public string? Telefono2 { get; set; }
        public string? EmailDefecto { get; set; }
        public string? Website { get; set; }
        public string Direccion { get; set; } = null!;
        public string? RutaLogoEmpresa { get; set; }
        public string? ResolucionSri { get; set; }
        public string? LeyendaResolucionSri { get; set; }
        public int IdMoneda { get; set; }
        public bool? EsContribuyenteEspecial { get; set; }
        public bool? EsObligadoContabilidad { get; set; }
        /// <summary>
        /// Tipo de ambiente 1: Pruebas 2: Produccion
        /// </summary>
        public int? Ambiente { get; set; }
        /// <summary>
        /// Tipo de emision del sistema 1:Emisión Normal, 2:Emisión por Indisponibilidad del sistema
        /// </summary>
        public int? TipoEmision { get; set; }
        public string? RutaCertificadoDigital { get; set; }
        public DateTime? FechaCaducidadCertificadoDigital { get; set; }
        public string? ContrasenaCertificadoDigital { get; set; }
        public string Estado { get; set; } = null!;
        public string UsuarioIngreso { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public string? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? UrlReceptor { get; set; }

        public virtual ICollection<EmpresaEmail> EmpresaEmails { get; set; }
        public virtual ICollection<EmpresaUsuario> EmpresaUsuarios { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<GuiaRemisionDetalle> GuiaRemisionDetalles { get; set; }
        public virtual ICollection<GuiaRemision> GuiaRemisions { get; set; }
        public virtual ICollection<ModuloEmpresa> ModuloEmpresas { get; set; }
        public virtual ICollection<NotaCredito> NotaCreditos { get; set; }
        public virtual ICollection<Retencion> Retencions { get; set; }
    }
}
