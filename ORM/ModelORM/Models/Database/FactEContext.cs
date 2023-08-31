using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ModelORM.Models.Database
{
    public partial class FactEContext : DbContext
    {
        public FactEContext()
        {
        }

        public FactEContext(DbContextOptions<FactEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdjuntoComprobante> AdjuntoComprobantes { get; set; } = null!;
        public virtual DbSet<Auditorium> Auditoria { get; set; } = null!;
        public virtual DbSet<Bodega> Bodegas { get; set; } = null!;
        public virtual DbSet<Catalogo> Catalogos { get; set; } = null!;
        public virtual DbSet<CatalogoDetalle> CatalogoDetalles { get; set; } = null!;
        public virtual DbSet<ComprobanteComprobanteRetencion> ComprobanteComprobanteRetencions { get; set; } = null!;
        public virtual DbSet<ComprobanteComprobanteRetencion6725> ComprobanteComprobanteRetencion6725s { get; set; } = null!;
        public virtual DbSet<ComprobanteComprobanteRetencion6726> ComprobanteComprobanteRetencion6726s { get; set; } = null!;
        public virtual DbSet<ComprobanteComprobanteRetencion6848> ComprobanteComprobanteRetencion6848s { get; set; } = null!;
        public virtual DbSet<ComprobanteFactura> ComprobanteFacturas { get; set; } = null!;
        public virtual DbSet<ComprobanteGuiaRemision> ComprobanteGuiaRemisions { get; set; } = null!;
        public virtual DbSet<ComprobanteLog> ComprobanteLogs { get; set; } = null!;
        public virtual DbSet<ComprobanteLogReceptor> ComprobanteLogReceptors { get; set; } = null!;
        public virtual DbSet<ComprobanteMailAdjunto> ComprobanteMailAdjuntos { get; set; } = null!;
        public virtual DbSet<ComprobanteNotaCredito> ComprobanteNotaCreditos { get; set; } = null!;
        public virtual DbSet<ComprobanteNotaDebito> ComprobanteNotaDebitos { get; set; } = null!;
        public virtual DbSet<ComprobanteValorAdjunto> ComprobanteValorAdjuntos { get; set; } = null!;
        public virtual DbSet<Contingencia> Contingencias { get; set; } = null!;
        public virtual DbSet<EmailAdjunto> EmailAdjuntos { get; set; } = null!;
        public virtual DbSet<EmailCopiaComprobante> EmailCopiaComprobantes { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<Empresa> Empresas { get; set; } = null!;
        public virtual DbSet<EmpresaEmail> EmpresaEmails { get; set; } = null!;
        public virtual DbSet<EmpresaInformacionComercial> EmpresaInformacionComercials { get; set; } = null!;
        public virtual DbSet<EmpresaUsuario> EmpresaUsuarios { get; set; } = null!;
        public virtual DbSet<Errore> Errores { get; set; } = null!;
        public virtual DbSet<ExcepcionAdjunto> ExcepcionAdjuntos { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<FacturaDetalle> FacturaDetalles { get; set; } = null!;
        public virtual DbSet<FacturaFormaPago> FacturaFormaPagos { get; set; } = null!;
        public virtual DbSet<FacturaImpuesto> FacturaImpuestos { get; set; } = null!;
        public virtual DbSet<Funcionalidad> Funcionalidads { get; set; } = null!;
        public virtual DbSet<GarantiaProducto> GarantiaProductos { get; set; } = null!;
        public virtual DbSet<Garantium> Garantia { get; set; } = null!;
        public virtual DbSet<GuiaRemision> GuiaRemisions { get; set; } = null!;
        public virtual DbSet<GuiaRemisionDetalle> GuiaRemisionDetalles { get; set; } = null!;
        public virtual DbSet<Imagen> Imagens { get; set; } = null!;
        public virtual DbSet<InventarioItem> InventarioItems { get; set; } = null!;
        public virtual DbSet<InventarioItemMovimiento> InventarioItemMovimientos { get; set; } = null!;
        public virtual DbSet<InventarioItemMovimientoDetalle> InventarioItemMovimientoDetalles { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<ItemCategorium> ItemCategoria { get; set; } = null!;
        public virtual DbSet<ItemSubCategorium> ItemSubCategoria { get; set; } = null!;
        public virtual DbSet<Modulo> Modulos { get; set; } = null!;
        public virtual DbSet<ModuloConfiguracion> ModuloConfiguracions { get; set; } = null!;
        public virtual DbSet<ModuloEmpresa> ModuloEmpresas { get; set; } = null!;
        public virtual DbSet<NotaCredito> NotaCreditos { get; set; } = null!;
        public virtual DbSet<NotaCreditoDetalle> NotaCreditoDetalles { get; set; } = null!;
        public virtual DbSet<NotaCreditoImpuesto> NotaCreditoImpuestos { get; set; } = null!;
        public virtual DbSet<NotaDebito> NotaDebitos { get; set; } = null!;
        public virtual DbSet<NotaDebitoFormaPago> NotaDebitoFormaPagos { get; set; } = null!;
        public virtual DbSet<NotaDebitoImpuesto> NotaDebitoImpuestos { get; set; } = null!;
        public virtual DbSet<NotaDebitoMotivo> NotaDebitoMotivos { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;
        public virtual DbSet<PersonaContacto> PersonaContactos { get; set; } = null!;
        public virtual DbSet<PreguntasSeguridad> PreguntasSeguridads { get; set; } = null!;
        public virtual DbSet<PreguntasUsuario> PreguntasUsuarios { get; set; } = null!;
        public virtual DbSet<Proveedor> Proveedors { get; set; } = null!;
        public virtual DbSet<Receptor> Receptors { get; set; } = null!;
        public virtual DbSet<ReceptorEmpresa> ReceptorEmpresas { get; set; } = null!;
        public virtual DbSet<Retencion> Retencions { get; set; } = null!;
        public virtual DbSet<RetencionImpuesto> RetencionImpuestos { get; set; } = null!;
        public virtual DbSet<RidePersonalizado> RidePersonalizados { get; set; } = null!;
        public virtual DbSet<SricodigosComprobante> SricodigosComprobantes { get; set; } = null!;
        public virtual DbSet<SricodigosSubTipoComprobante> SricodigosSubTipoComprobantes { get; set; } = null!;
        public virtual DbSet<SriimpuestoRetener> SriimpuestoReteners { get; set; } = null!;
        public virtual DbSet<Sucursal> Sucursals { get; set; } = null!;
        public virtual DbSet<SucursalSecuencial> SucursalSecuencials { get; set; } = null!;
        public virtual DbSet<TnqcomprobanteRetencionCabecera> TnqcomprobanteRetencionCabeceras { get; set; } = null!;
        public virtual DbSet<TnqcomprobanteRetencionImpuesto> TnqcomprobanteRetencionImpuestos { get; set; } = null!;
        public virtual DbSet<TnqcomprobanteXml> TnqcomprobanteXmls { get; set; } = null!;
        public virtual DbSet<TnqfacturaCabecera> TnqfacturaCabeceras { get; set; } = null!;
        public virtual DbSet<TnqfacturaDetalle> TnqfacturaDetalles { get; set; } = null!;
        public virtual DbSet<TnqfacturaFormaPago> TnqfacturaFormaPagos { get; set; } = null!;
        public virtual DbSet<TnqfacturaImpuesto> TnqfacturaImpuestos { get; set; } = null!;
        public virtual DbSet<TnqguiaRemisionCabecera> TnqguiaRemisionCabeceras { get; set; } = null!;
        public virtual DbSet<TnqguiaRemisionDestinatario> TnqguiaRemisionDestinatarios { get; set; } = null!;
        public virtual DbSet<TnqguiaRemisionDetalle> TnqguiaRemisionDetalles { get; set; } = null!;
        public virtual DbSet<TnqnotaCreditoCabecera> TnqnotaCreditoCabeceras { get; set; } = null!;
        public virtual DbSet<TnqnotaCreditoDetalle> TnqnotaCreditoDetalles { get; set; } = null!;
        public virtual DbSet<TnqnotaCreditoImpuesto> TnqnotaCreditoImpuestos { get; set; } = null!;
        public virtual DbSet<TnqnotaDebitoCabecera> TnqnotaDebitoCabeceras { get; set; } = null!;
        public virtual DbSet<TnqnotaDebitoFormaPago> TnqnotaDebitoFormaPagos { get; set; } = null!;
        public virtual DbSet<TnqnotaDebitoImpuesto> TnqnotaDebitoImpuestos { get; set; } = null!;
        public virtual DbSet<TnqnotaDebitoMotivo> TnqnotaDebitoMotivos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<UsuarioDetalle> UsuarioDetalles { get; set; } = null!;
        public virtual DbSet<UsuarioReceptor> UsuarioReceptors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("User= sa; Password= Ctek2314;Persist Security Info=False;Initial Catalog=FactE;Data Source=(local)\\A19");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Modern_Spanish_CI_AS");

            modelBuilder.Entity<AdjuntoComprobante>(entity =>
            {
                entity.HasKey(e => e.IdAdjuntoComprobante);

                entity.ToTable("AdjuntoComprobante");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NombreAdjunto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Auditorium>(entity =>
            {
                entity.HasKey(e => e.IdAuditoria)
                    .HasName("PK__Auditori__7FD13FA00BC6C43E");

                entity.Property(e => e.Descripcion).HasColumnType("xml");

                entity.Property(e => e.FechaTransaccion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ip)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.NombrePc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NombrePC");

                entity.Property(e => e.NombreTabla)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTransaccion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Bodega>(entity =>
            {
                entity.HasKey(e => e.IdBodega);

                entity.ToTable("Bodega");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Responsable)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoBodega)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Catalogo>(entity =>
            {
                entity.HasKey(e => e.IdCatalogo);

                entity.ToTable("Catalogo");

                entity.Property(e => e.IdCatalogo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatalogoDetalle>(entity =>
            {
                entity.HasKey(e => new { e.IdCatalogo, e.IdCatalogoDetalle })
                    .HasName("PK_DetalleCatalogo");

                entity.ToTable("CatalogoDetalle");

                entity.Property(e => e.IdCatalogo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdCatalogoDetalle)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Auxiliar1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Auxiliar2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComprobanteComprobanteRetencion>(entity =>
            {
                entity.HasKey(e => new { e.IdComprobanteComprobanteRetencion, e.IdEmpresa })
                    .HasName("pk_ComprobanteComprobanteRetencion");

                entity.ToTable("ComprobanteComprobanteRetencion");

                entity.HasIndex(e => new { e.IdComprobanteComprobanteRetencion, e.IdEmpresa, e.NumeroComprobanteRetencion, e.FechaAutorizacion }, "ComprobanteRetencion_DocumentosEmitidos");

                entity.HasIndex(e => new { e.IdEmpresa, e.EmailEnviado, e.Estado }, "iComprobanteComprobanteRetencion_1");

                entity.HasIndex(e => new { e.ClienteIdentificacion, e.Estado, e.IdEmpresa }, "iComprobanteComprobanteRetencion_2");

                entity.Property(e => e.IdComprobanteComprobanteRetencion).ValueGeneratedOnAdd();

                entity.Property(e => e.ClaveAcceso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveContingencia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteNombre)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EmailDestino)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAutorizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroComprobanteRetencion)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PuntoEmision)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RutaPasajero)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TicketAereo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.XmlComprobanteComprobanteRetencionAutorizado).IsUnicode(false);
            });

            modelBuilder.Entity<ComprobanteComprobanteRetencion6725>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ComprobanteComprobanteRetencion_6725");

                entity.Property(e => e.ClaveAcceso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveContingencia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteNombre)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EmailDestino)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAutorizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.IdComprobanteComprobanteRetencion).ValueGeneratedOnAdd();

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroComprobanteRetencion)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PuntoEmision)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RutaPasajero)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TicketAereo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.XmlComprobanteComprobanteRetencionAutorizado).IsUnicode(false);
            });

            modelBuilder.Entity<ComprobanteComprobanteRetencion6726>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ComprobanteComprobanteRetencion_6726");

                entity.Property(e => e.ClaveAcceso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveContingencia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteNombre)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EmailDestino)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAutorizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.IdComprobanteComprobanteRetencion).ValueGeneratedOnAdd();

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroComprobanteRetencion)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PuntoEmision)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RutaPasajero)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TicketAereo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.XmlComprobanteComprobanteRetencionAutorizado).IsUnicode(false);
            });

            modelBuilder.Entity<ComprobanteComprobanteRetencion6848>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ComprobanteComprobanteRetencion6848");

                entity.Property(e => e.ClaveAcceso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveContingencia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteNombre)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EmailDestino)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAutorizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.IdComprobanteComprobanteRetencion).ValueGeneratedOnAdd();

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroComprobanteRetencion)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PuntoEmision)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RutaPasajero)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TicketAereo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.XmlComprobanteComprobanteRetencionAutorizado).IsUnicode(false);
            });

            modelBuilder.Entity<ComprobanteFactura>(entity =>
            {
                entity.HasKey(e => new { e.IdComprobanteFactura, e.IdEmpresa })
                    .HasName("pkComprobanteFactura");

                entity.ToTable("ComprobanteFactura");

                entity.HasIndex(e => e.FechaEmision, "NonClusteredIndex-20230712-210534");

                entity.Property(e => e.IdComprobanteFactura).ValueGeneratedOnAdd();

                entity.Property(e => e.ClaveAcceso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveContingencia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteNombre)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EmailDestino)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAutorizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PuntoEmision)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RutaPasajero)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TicketAereo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.XmlComprobanteFacturaAutorizado).IsUnicode(false);
            });

            modelBuilder.Entity<ComprobanteGuiaRemision>(entity =>
            {
                entity.HasKey(e => new { e.IdComprobanteGuiaRemision, e.IdEmpresa })
                    .HasName("pkComprobanteGuiaRemision");

                entity.ToTable("ComprobanteGuiaRemision");

                entity.HasIndex(e => new { e.IdComprobanteGuiaRemision, e.IdEmpresa, e.NumeroGuiaRemision, e.FechaAutorizacion }, "GuiaRemision_DocumentosEmitidos");

                entity.Property(e => e.IdComprobanteGuiaRemision).ValueGeneratedOnAdd();

                entity.Property(e => e.ClaveAcceso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveContingencia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteNombre)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EmailDestino)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAutorizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroGuiaRemision)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.XmlComprobanteGuiaRemisionAutorizado).IsUnicode(false);
            });

            modelBuilder.Entity<ComprobanteLog>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("ComprobanteLog");

                entity.HasIndex(e => new { e.IdLog, e.IdEmpresa, e.TipoComprobante, e.NumeroComprobante, e.FechaLog }, "ComprobanteLog_Errores");

                entity.Property(e => e.ClaveContingencia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLog).HasColumnType("datetime");

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.XmlComprobanteError).IsUnicode(false);

                entity.Property(e => e.XmlOrigenError).IsUnicode(false);
            });

            modelBuilder.Entity<ComprobanteLogReceptor>(entity =>
            {
                entity.HasKey(e => e.IdComprobanteLogReceptor);

                entity.ToTable("ComprobanteLogReceptor");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLog).HasColumnType("datetime");

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAccion)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComprobanteMailAdjunto>(entity =>
            {
                entity.HasKey(e => e.IdComprobanteMailAdjunto);

                entity.ToTable("ComprobanteMailAdjunto");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ComprobanteNotaCredito>(entity =>
            {
                entity.HasKey(e => new { e.IdComprobanteNotaCredito, e.IdEmpresa })
                    .HasName("pkComprobanteNotaCredito");

                entity.ToTable("ComprobanteNotaCredito");

                entity.HasIndex(e => new { e.IdComprobanteNotaCredito, e.IdEmpresa, e.NumeroNotaCredito, e.FechaAutorizacion }, "NotaCredito_DocumentosEmitidos");

                entity.Property(e => e.IdComprobanteNotaCredito).ValueGeneratedOnAdd();

                entity.Property(e => e.ClaveAcceso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveContingencia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteNombre)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EmailDestino)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAutorizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroNotaCredito)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PuntoEmision)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RutaPasajero)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TicketAereo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.XmlComprobanteNotaCreditoAutorizado).IsUnicode(false);
            });

            modelBuilder.Entity<ComprobanteNotaDebito>(entity =>
            {
                entity.HasKey(e => new { e.IdComprobanteNotaDebito, e.IdEmpresa })
                    .HasName("pkComprobanteNotaDebito");

                entity.ToTable("ComprobanteNotaDebito");

                entity.HasIndex(e => new { e.IdComprobanteNotaDebito, e.IdEmpresa, e.NumeroNotaDebito, e.FechaAutorizacion }, "NotaDebito_DocumentosEmitidos");

                entity.Property(e => e.IdComprobanteNotaDebito).ValueGeneratedOnAdd();

                entity.Property(e => e.ClaveAcceso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveContingencia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteNombre)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EmailDestino)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAutorizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroNotaDebito)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PuntoEmision)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RutaPasajero)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TicketAereo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.XmlComprobanteNotaDebitoAutorizado).IsUnicode(false);
            });

            modelBuilder.Entity<ComprobanteValorAdjunto>(entity =>
            {
                entity.HasKey(e => e.IdComprobanteValorAdjunto);

                entity.ToTable("ComprobanteValorAdjunto");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValorAdjunto)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contingencia>(entity =>
            {
                entity.HasKey(e => e.IdContingencia)
                    .HasName("PK_Contingencia");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.NumeroContingencia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailAdjunto>(entity =>
            {
                entity.HasKey(e => e.IdEmailAdjuntos);

                entity.Property(e => e.DocumentosAdjuntos)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmailCopia)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailCopiaComprobante>(entity =>
            {
                entity.HasKey(e => e.IdEmailCopiaComprobante);

                entity.ToTable("EmailCopiaComprobante");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.MailCopia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.ToTable("Empleado");

                entity.Property(e => e.IdEmpleado).ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithOne(p => p.Empleado)
                    .HasForeignKey<Empleado>(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empleado_Persona");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("Empresa");

                entity.HasIndex(e => e.Ruc, "UN_RUCEmpresa")
                    .IsUnique();

                entity.Property(e => e.Ambiente).HasComment("Tipo de ambiente 1: Pruebas 2: Produccion");

                entity.Property(e => e.ContrasenaCertificadoDigital)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmailDefecto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EsContribuyenteEspecial).HasDefaultValueSql("((0))");

                entity.Property(e => e.EsObligadoContabilidad).HasDefaultValueSql("((1))");

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCaducidadCertificadoDigital).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.LeyendaResolucionSri)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("LeyendaResolucionSRI");

                entity.Property(e => e.NombreComercial)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResolucionSri)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ResolucionSRI");

                entity.Property(e => e.Ruc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RUC");

                entity.Property(e => e.RutaCertificadoDigital)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RutaLogoEmpresa)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEmision).HasComment("Tipo de emision del sistema 1:Emisión Normal, 2:Emisión por Indisponibilidad del sistema");

                entity.Property(e => e.UrlReceptor)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpresaEmail>(entity =>
            {
                entity.HasKey(e => e.IdEmpresaEmail);

                entity.ToTable("EmpresaEmail");

                entity.Property(e => e.ClienteUsar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EsSsl).HasColumnName("esSSL");

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NombreServidor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("pwd");

                entity.Property(e => e.Remitente)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RutaBannerInferior)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RutaBannerSuperior)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TextoMailBienvenida).IsUnicode(false);

                entity.Property(e => e.TextoMailRecepcionComprobante).IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.EmpresaEmails)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmpresaEmail_Empresa");
            });

            modelBuilder.Entity<EmpresaInformacionComercial>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PK__EmpresaI__5EF4033E2E1BDC42");

                entity.ToTable("EmpresaInformacionComercial");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFinActualPeriodo).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioActualPeriodo).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioOperaciones).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NombreComercial)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodicidadPago)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ruc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RUC");

                entity.Property(e => e.Telefono1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValorPago).HasColumnType("decimal(14, 2)");
            });

            modelBuilder.Entity<EmpresaUsuario>(entity =>
            {
                entity.HasKey(e => e.IdEmpresaUsuario);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.EmpresaUsuarios)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmpresaUsuarios_Empresa");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.EmpresaUsuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmpresaUsuarios_Usuarios");
            });

            modelBuilder.Entity<Errore>(entity =>
            {
                entity.HasKey(e => e.IdError)
                    .HasName("PK__Errores__C8A4CFD933D4B598");

                entity.Property(e => e.DescripcionError)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExcepcionAdjunto>(entity =>
            {
                entity.HasKey(e => e.IdExcepcionAdjunto);

                entity.ToTable("ExcepcionAdjunto");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.PatronExcepcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFactura)
                    .HasName("pkFactura");

                entity.ToTable("Factura");

                entity.HasIndex(e => new { e.IdEmpresa, e.NumeroFactura }, "NonClusteredIndex-20230712-205101");

                entity.Property(e => e.Descripcion1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion4)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion5)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DescuentoAdicional).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.DirecccionEstablecimiento)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DirecccionMatriz)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionEstablecimientoCliente)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.ImporteTotal).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Moneda)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre4)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre5)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSecuencial)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Propina).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Subtotal).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacionComprador)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDescuento).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.TotalIce).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.TotalIrbpnr).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.TotalIva).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.TotalSubsidio).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Factura_Empresa");

                entity.HasOne(d => d.IdSucursalNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdSucursal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Factura_Sucursal");
            });

            modelBuilder.Entity<FacturaDetalle>(entity =>
            {
                entity.HasKey(e => e.IdFacturaDetalle);

                entity.ToTable("FacturaDetalle");

                entity.Property(e => e.Atributo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BaseImponibleIce).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.BaseImponibleIrbpnr).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.BaseImponibleIva).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CodigoAdicional)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoInterno)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAtributo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAtributo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAtributo3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descuento).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Ice)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Irbpnr)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Iva)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSecuencial)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OtroConcepto)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PorcentajeIce).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PorcentajeIrbpnr).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PorcentajeIva).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PrecioSinSubsidio).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PrecioTotalSinImpuesto).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ValorIce).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.ValorIrbpnr).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.ValorIva).HasColumnType("decimal(14, 2)");
            });

            modelBuilder.Entity<FacturaFormaPago>(entity =>
            {
                entity.HasKey(e => e.IdFacturaFormaPago);

                entity.ToTable("FacturaFormaPago");

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Plazo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.UnidadTiempo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.FacturaFormaPagos)
                    .HasForeignKey(d => d.IdFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FacturaFormaPago_Factura");
            });

            modelBuilder.Entity<FacturaImpuesto>(entity =>
            {
                entity.HasKey(e => e.IdImpuesto)
                    .HasName("PK__FacturaI__A9B889283F466844");

                entity.ToTable("FacturaImpuesto");

                entity.Property(e => e.CodigoInterno)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTarifa)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tarifa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Funcionalidad>(entity =>
            {
                entity.HasKey(e => e.IdFuncionalidad)
                    .HasName("PK__Funciona__11182292C6F8C772");

                entity.ToTable("Funcionalidad");

                entity.Property(e => e.DescripcionFuncionalidad)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FormularioFuncionalidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoFuncionalidad)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NombreFuncionalidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.Funcionalidads)
                    .HasForeignKey(d => d.IdModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Funcionalidad_Modulo");
            });

            modelBuilder.Entity<GarantiaProducto>(entity =>
            {
                entity.HasKey(e => e.IdGarantiaProducto);

                entity.ToTable("GarantiaProducto");

                entity.Property(e => e.DescripcionGarantia)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionProducto)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Garantium>(entity =>
            {
                entity.HasKey(e => e.IdGarantia);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.TextoGarantia).IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GuiaRemision>(entity =>
            {
                entity.HasKey(e => e.IdGuiaRemision)
                    .HasName("pkGuiaRemision");

                entity.ToTable("GuiaRemision");

                entity.Property(e => e.CodigoDocumentoSustento)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion4)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion5)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionDestino)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionPartida)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoAduanero)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaEmisionDocumentoSustento).HasColumnType("datetime");

                entity.Property(e => e.FechaFinTransporte).HasColumnType("date");

                entity.Property(e => e.FechaInicioTransporte).HasColumnType("date");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Moneda)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoTraslado)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre4)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre5)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoSustento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroGuiaRemision)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSecuencial)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PlacaCamion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ruta)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.GuiaRemisions)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuiaRemision_Empresa");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.GuiaRemisionIdPersonaNavigations)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuiaRemision_Persona");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.GuiaRemisionIdProveedorNavigations)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuiaRemision_Proveedor");

                entity.HasOne(d => d.IdSucursalNavigation)
                    .WithMany(p => p.GuiaRemisions)
                    .HasForeignKey(d => d.IdSucursal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuiaRemision_Sucursal");
            });

            modelBuilder.Entity<GuiaRemisionDetalle>(entity =>
            {
                entity.HasKey(e => e.IdGuiaRemisionDetalle)
                    .HasName("PK_[IdGuiaRemision");

                entity.ToTable("GuiaRemisionDetalle");

                entity.Property(e => e.Atributo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAtributo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAtributo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAtributo3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.OtroConcepto)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.GuiaRemisionDetalles)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuiaRemisionDetalle_Empresa");

                entity.HasOne(d => d.IdItemNavigation)
                    .WithMany(p => p.GuiaRemisionDetalles)
                    .HasForeignKey(d => d.IdItem)
                    .HasConstraintName("FK_GuiaRemisionDetalle_Item");
            });

            modelBuilder.Entity<Imagen>(entity =>
            {
                entity.HasKey(e => e.IdImagen)
                    .HasName("PK__Imagen__B42D8F2A4CA06362");

                entity.ToTable("Imagen");

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Ruta)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoItem)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventarioItem>(entity =>
            {
                entity.HasKey(e => new { e.IdItem, e.IdBodega });

                entity.ToTable("InventarioItem");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBodegaNavigation)
                    .WithMany(p => p.InventarioItems)
                    .HasForeignKey(d => d.IdBodega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InventarioItem__IdBodega");

                entity.HasOne(d => d.IdItemNavigation)
                    .WithMany(p => p.InventarioItems)
                    .HasForeignKey(d => d.IdItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InventarioItem__IdItem");
            });

            modelBuilder.Entity<InventarioItemMovimiento>(entity =>
            {
                entity.HasKey(e => e.IdInventarioItemMovimiento);

                entity.ToTable("InventarioItemMovimiento");

                entity.Property(e => e.DocumentoRespaldo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaMovimiento).HasColumnType("datetime");

                entity.Property(e => e.IdMotivoMovimiento)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoMovimiento)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBodegaNavigation)
                    .WithMany(p => p.InventarioItemMovimientos)
                    .HasForeignKey(d => d.IdBodega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventarioItemMovimiento_Bodega");
            });

            modelBuilder.Entity<InventarioItemMovimientoDetalle>(entity =>
            {
                entity.HasKey(e => e.IdInventarioItemMovimientoDetalle);

                entity.ToTable("InventarioItemMovimientoDetalle");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdInventarioItemMovimientoNavigation)
                    .WithMany(p => p.InventarioItemMovimientoDetalles)
                    .HasForeignKey(d => d.IdInventarioItemMovimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventarioItemMovimientoDetalle_InventarioItemMovimiento");

                entity.HasOne(d => d.IdItemNavigation)
                    .WithMany(p => p.InventarioItemMovimientoDetalles)
                    .HasForeignKey(d => d.IdItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventarioItemMovimientoDetalle_Item");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.IdItem)
                    .HasName("PK__Item__51E842625629CD9C");

                entity.ToTable("Item");

                entity.Property(e => e.Atributo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoAuxiliar)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPrincipal)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAtributo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAtributo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAtributo3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Iva)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("IVA");

                entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoBien)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemCategorium>(entity =>
            {
                entity.HasKey(e => e.IdItemCategoria)
                    .HasName("PK__ItemCate__68ACE1ED59FA5E80");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemSubCategorium>(entity =>
            {
                entity.HasKey(e => e.IdItemSubCategoria)
                    .HasName("PK__ItemSubC__D7AC3CF45DCAEF64");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdItemCategoriaNavigation)
                    .WithMany(p => p.ItemSubCategoria)
                    .HasForeignKey(d => d.IdItemCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemCategoria_SubCategori");
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.HasKey(e => e.IdModulo);

                entity.ToTable("Modulo");

                entity.Property(e => e.CodigoModulo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModuloConfiguracion>(entity =>
            {
                entity.HasKey(e => e.IdModuloConfiguracion);

                entity.ToTable("ModuloConfiguracion");

                entity.Property(e => e.CodigoParametro)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.ModuloConfiguracions)
                    .HasForeignKey(d => new { d.IdModulo, d.IdEmpresa })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModuloConfiguracion_ModuloEmpresa");
            });

            modelBuilder.Entity<ModuloEmpresa>(entity =>
            {
                entity.HasKey(e => new { e.IdModulo, e.IdEmpresa });

                entity.ToTable("ModuloEmpresa");

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.ModuloEmpresas)
                    .HasForeignKey(d => d.IdModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModuloEmpresa_Empresa");

                entity.HasOne(d => d.IdModulo1)
                    .WithMany(p => p.ModuloEmpresas)
                    .HasForeignKey(d => d.IdModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModuloEmpresa_Modulo");
            });

            modelBuilder.Entity<NotaCredito>(entity =>
            {
                entity.HasKey(e => e.IdNotaCredito);

                entity.ToTable("NotaCredito");

                entity.Property(e => e.Atributo1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo4)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo5)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoDocumentoModificado)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic4)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic5)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DirecccionEstablecimiento)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DirecccionMatriz)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaFactura).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.ImporteTotal).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Moneda)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Motivo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroNotaCredito)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSecuencial)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Subtotal).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.TipoIdentificacionComprador)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDescuento).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.TotalIce).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.TotalIva).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.NotaCreditos)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaCredito_Empresa");

                entity.HasOne(d => d.IdSucursalNavigation)
                    .WithMany(p => p.NotaCreditos)
                    .HasForeignKey(d => d.IdSucursal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaCredito_Sucursal");
            });

            modelBuilder.Entity<NotaCreditoDetalle>(entity =>
            {
                entity.HasKey(e => e.IdNotaCreditoDetalles);

                entity.Property(e => e.Atributo1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.BaseImponibleIce).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CodigoAdicional)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoInterno)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Descuento).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Ice)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdNotaCredito).HasColumnName("idNotaCredito");

                entity.Property(e => e.Iva)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OtroConcepto)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PorcentajeIce).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PorcentajeIva).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PrecioTotalSinImpuesto).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ValorIce).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.ValorIva).HasColumnType("decimal(14, 2)");
            });

            modelBuilder.Entity<NotaCreditoImpuesto>(entity =>
            {
                entity.HasKey(e => e.IdImpuesto)
                    .HasName("PK__NotaCred__A9B8892831B762FC");

                entity.ToTable("NotaCreditoImpuesto");

                entity.Property(e => e.CodigoInterno)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTarifa)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Tarifa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NotaDebito>(entity =>
            {
                entity.HasKey(e => e.IdNotaDebito);

                entity.ToTable("NotaDebito");

                entity.Property(e => e.Atributo1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo4)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo5)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoDocumentoModificado)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEstablecimiento)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic4)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic5)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DirecccionEstablecimiento)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DirecccionMatriz)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmesionDocumentoModificado).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoModificado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroNotaDebito)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSecuencial)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PuntotoEmision)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacionComprador)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TotalIva).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalSinImpuesto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValorTotal).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<NotaDebitoFormaPago>(entity =>
            {
                entity.HasKey(e => e.IdNotaDebitoFormaPago);

                entity.ToTable("NotaDebitoFormaPago");

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Plazo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadTiempo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNotaDebitoNavigation)
                    .WithMany(p => p.NotaDebitoFormaPagos)
                    .HasForeignKey(d => d.IdNotaDebito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaDebitoFormaPago_NotaDebito");
            });

            modelBuilder.Entity<NotaDebitoImpuesto>(entity =>
            {
                entity.HasKey(e => e.IdImpuesto)
                    .HasName("PK__NotaDebi__A9B889286D0D32F4");

                entity.ToTable("NotaDebitoImpuesto");

                entity.Property(e => e.CodigoTarifa)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tarifa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NotaDebitoMotivo>(entity =>
            {
                entity.HasKey(e => e.IdNotaDebitoMotivo)
                    .HasName("PK__NotaDebi__5E25362F70DDC3D8");

                entity.ToTable("NotaDebitoMotivo");

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdNotaDebito).HasColumnName("idNotaDebito");

                entity.Property(e => e.Iva)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Razon)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK_Persona_1");

                entity.ToTable("Persona");

                entity.HasIndex(e => new { e.NumeroIdentificacion, e.IdEmpresa }, "iPersona_2");

                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Convencional)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmailCopias)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NumeroIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacion)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonaContacto>(entity =>
            {
                entity.HasKey(e => e.IdPersonaContacto)
                    .HasName("PK_Contacto_1")
                    .IsClustered(false);

                entity.ToTable("PersonaContacto");

                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Convencional)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Relacion)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreguntasSeguridad>(entity =>
            {
                entity.HasKey(e => e.IdPregunta)
                    .HasName("PK__Pregunta__754EC09E787EE5A0");

                entity.ToTable("PreguntasSeguridad");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NombrePregunta)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreguntasUsuario>(entity =>
            {
                entity.HasKey(e => e.IdpreguntaUsuario)
                    .HasName("PK__Pregunta__9F419CB6145C0A3F");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Respuesta).IsUnicode(false);

                entity.HasOne(d => d.IdPreguntaNavigation)
                    .WithMany(p => p.PreguntasUsuarios)
                    .HasForeignKey(d => d.IdPregunta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PreguntasUsuarios_PreguntasSeguridad");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.PreguntasUsuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PreguntasUsuarios_Usuarios");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor);

                entity.ToTable("Proveedor");

                entity.Property(e => e.IdProveedor).ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithOne(p => p.Proveedor)
                    .HasForeignKey<Proveedor>(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proveedor_Persona");
            });

            modelBuilder.Entity<Receptor>(entity =>
            {
                entity.HasKey(e => e.IdReceptor)
                    .HasName("PK_Receptor_1");

                entity.ToTable("Receptor");

                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Convencional)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailCopias)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NumeroIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RecibirSms).HasColumnName("RecibirSMS");

                entity.Property(e => e.TipoIdentificacion)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReceptorEmpresa>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdReceptor })
                    .HasName("PK_ReceptorEmpresa_1");

                entity.ToTable("ReceptorEmpresa");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<Retencion>(entity =>
            {
                entity.HasKey(e => e.IdComprobanteRetencion);

                entity.ToTable("Retencion");

                entity.Property(e => e.Atributo1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo4)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Atributo5)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic4)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic5)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DirecccionEstablecimiento)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.NumeroComprobanteRetencion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSecuencial)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoFiscal)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacionComprador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Retencions)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Retencion_Empresa");

                entity.HasOne(d => d.IdSucursalNavigation)
                    .WithMany(p => p.Retencions)
                    .HasForeignKey(d => d.IdSucursal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Retencion_Sucursal");
            });

            modelBuilder.Entity<RetencionImpuesto>(entity =>
            {
                entity.HasKey(e => e.IdRetencionDetalle);

                entity.ToTable("RetencionImpuesto");

                entity.Property(e => e.BaseImponible).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CodDocSustento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codDocSustento");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoSustentoCodigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoSustentoFechaEmision).HasColumnType("datetime");

                entity.Property(e => e.DocumentoSustentoTipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Porcentaje)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<RidePersonalizado>(entity =>
            {
                entity.HasKey(e => e.IdRidePersonalizado);

                entity.ToTable("RidePersonalizado");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FormularioRide)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NombreRide)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SricodigosComprobante>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SRICodigosComprobantes");

                entity.Property(e => e.CodigoComprobante)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionComprobante)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdCodigoComprobante).ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SricodigosSubTipoComprobante>(entity =>
            {
                entity.HasKey(e => e.IdSubTipoComprobante);

                entity.ToTable("SRICodigosSubTipoComprobantes");

                entity.Property(e => e.CodigoSubTipoComprobante)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTipoComprobante)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionSubTipoComprobante)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<SriimpuestoRetener>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SRIImpuestoRetener");

                entity.Property(e => e.CodigoImpuestoRetener)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdImpuestoRetener).ValueGeneratedOnAdd();

                entity.Property(e => e.ImpuestoRetener)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIngreso)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.HasKey(e => e.IdSucursal);

                entity.ToTable("Sucursal");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEstablecimiento)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PuntoEmision)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RutaLogo).HasMaxLength(90);

                entity.Property(e => e.Telefono1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SucursalSecuencial>(entity =>
            {
                entity.HasKey(e => e.IdSecuencial)
                    .HasName("PK__Sucursal__7366E5800F624AF8");

                entity.ToTable("SucursalSecuencial");

                entity.Property(e => e.Estado)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TnqcomprobanteRetencionCabecera>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdComprobanteRetencion })
                    .HasName("PK_ComprobanteRetencion");

                entity.ToTable("TNQComprobanteRetencionCabecera");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdComprobanteRetencion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEstablecimiento)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DirecccionEstablecimiento)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.NumeroComprobanteRetencion)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoFiscal).HasColumnType("datetime");

                entity.Property(e => e.PuntoEmision)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacionComprador)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TnqcomprobanteRetencionImpuesto>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdComprobanteRetencion, e.SecuencialImpuesto, e.CodigoImpuesto })
                    .HasName("PK_ComprobanteRetencionImpuesto");

                entity.ToTable("TNQComprobanteRetencionImpuesto");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdComprobanteRetencion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoDocumentoSustento)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRetencion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmisionDocumentoSustento).HasColumnType("datetime");

                entity.Property(e => e.NumeroDocumentoSustento)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TnqcomprobanteXml>(entity =>
            {
                entity.HasKey(e => e.ClaveAccesoCliente);

                entity.ToTable("TNQComprobanteXML");

                entity.Property(e => e.ClaveAccesoCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveAccesoInterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRecepcion).HasColumnType("datetime");

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Procesado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoComprobante)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.XmlComprobante).IsUnicode(false);
            });

            modelBuilder.Entity<TnqfacturaCabecera>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdFactura })
                    .HasName("PK_tblCabeFact");

                entity.ToTable("TNQFacturaCabecera");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdFactura)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEstablecimiento)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DirecccionEstablecimiento)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.ImporteTotal).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.Moneda)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Propina).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.PuntotoEmision)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacionComprador)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDescuentos).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.TotalSinImpu).HasColumnType("decimal(14, 4)");
            });

            modelBuilder.Entity<TnqfacturaDetalle>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdFactura, e.SecuencialProducto, e.CodigoInterno })
                    .HasName("PK_tblDetaFact");

                entity.ToTable("TNQFacturaDetalle");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdFactura)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoInterno)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cantidad).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.CodigoAdicional)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional4)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional5)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ValorDescuento).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.ValorTotalSinImpuesto).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.ValorUnitario).HasColumnType("decimal(14, 4)");
            });

            modelBuilder.Entity<TnqfacturaFormaPago>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdFactura, e.SecuencialFormaPago })
                    .HasName("PK_tblFactFP");

                entity.ToTable("TNQFacturaFormaPago");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdFactura)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoFormaPago)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Plazo).HasColumnName("plazo");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnidadTiempo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TnqfacturaImpuesto>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdFactura, e.SecuencialProducto, e.CodigoInterno, e.IdImpuesto })
                    .HasName("PK_tblImpFact");

                entity.ToTable("TNQFacturaImpuesto");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdFactura)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoInterno)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IdImpuesto).HasComment("Codigo del impuesto aplicado, IVA(12%),IVA(0%), ICE, etc");

                entity.Property(e => e.BaseImponible).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.CodigoAdicional)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IdPorcentaje).HasComment("codigo del valor del porcentaje, 12%,0%,10%, etc");

                entity.Property(e => e.Tarifa)
                    .HasColumnType("decimal(14, 4)")
                    .HasComment("tarifa de impuesto aplicado a cada producto es decir, 12,0,etc");

                entity.Property(e => e.Valor).HasColumnType("decimal(14, 4)");
            });

            modelBuilder.Entity<TnqguiaRemisionCabecera>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdGuiaRemision })
                    .HasName("PK_GuiaRemisionCabecera");

                entity.ToTable("TNQGuiaRemisionCabecera");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdGuiaRemision)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEstablecimiento)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionEstablecimiento)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionPartida)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaFinTransporte).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioTransporte).HasColumnType("datetime");

                entity.Property(e => e.NumeroGuia)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacionTransportista)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Placa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PuntoEmision)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocialTransportista)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacionTransportista)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TnqguiaRemisionDestinatario>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdGuiaRemision, e.SecDestinatario, e.IdentificacionDestinatario })
                    .HasName("PK_GuiaRemisionDestinatario");

                entity.ToTable("TNQGuiaRemisionDestinatario");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdGuiaRemision)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificacionDestinatario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodEstablecimientoDestino)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoDocumentoSustento)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional4)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional5)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionDestinatario)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DocAduaneroUnico)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmisionDocumentoSustento).HasColumnType("datetime");

                entity.Property(e => e.MotivoTraslado)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAuthDocumentoSustento)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoSustento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocialDestinatario)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Ruta)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TnqguiaRemisionDetalle>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdGuiaRemision, e.SecDestinatario, e.CodigoInterno })
                    .HasName("PK_GuiaRemisionDetalle");

                entity.ToTable("TNQGuiaRemisionDetalle");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdGuiaRemision)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoInterno)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoAdicional)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional3)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TnqnotaCreditoCabecera>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdNotaCredito })
                    .HasName("PK_NotaCreditoCabecera");

                entity.ToTable("TNQNotaCreditoCabecera");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdNotaCredito)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoDocumentoModificado)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEstablecimiento)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DirecccionEstablecimiento)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaEmisionDocumentoSustento).HasColumnType("datetime");

                entity.Property(e => e.Moneda)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Motivo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoModificado)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroNotaCredito)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PuntoEmision)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacionComprador)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TnqnotaCreditoDetalle>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdNotaCredito, e.SecuencialProducto, e.CodigoProducto })
                    .HasName("PK_NotaCreditoDetalle");

                entity.ToTable("TNQNotaCreditoDetalle");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdNotaCredito)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional4)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAdicional5)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TnqnotaCreditoImpuesto>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdNotaCredito, e.SecuencialProducto, e.CodigoInterno, e.IdImpuesto })
                    .HasName("PK_NotaCreditoImpuesto");

                entity.ToTable("TNQNotaCreditoImpuesto");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdNotaCredito)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoInterno)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IdImpuesto).HasComment("Codigo del impuesto aplicado, IVA(12%),IVA(0%), ICE, etc");

                entity.Property(e => e.CodigoAdicional)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IdPorcentaje).HasComment("codigo del valor del porcentaje, 12%,0%,10%, etc");

                entity.Property(e => e.Tarifa).HasComment("tarifa de impuesto aplicado a cada producto es decir, 12,0,etc");
            });

            modelBuilder.Entity<TnqnotaDebitoCabecera>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdNotaDebito })
                    .HasName("PK_NotaDebitoCabecera");

                entity.ToTable("TNQNotaDebitoCabecera");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdNotaDebito)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoDocumentoModificado)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEstablecimiento)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DetaAdic3)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DirecccionEstablecimiento)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaEmisionDocumentoSustento).HasColumnType("datetime");

                entity.Property(e => e.NumeroDocumentoModificado)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroNotaDebito)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PuntoEmision)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacionComprador)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TnqnotaDebitoFormaPago>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdNotaDebito, e.SecuencialFormaPago })
                    .HasName("PK_tblNDFP");

                entity.ToTable("TNQNotaDebitoFormaPago");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdNotaDebito)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoFormaPago)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Plazo).HasColumnName("plazo");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnidadTiempo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TnqnotaDebitoImpuesto>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdNotaDebito, e.SecuencialImpuesto, e.IdImpuesto })
                    .HasName("PK_NotaDebitoImpuesto");

                entity.ToTable("TNQNotaDebitoImpuesto");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdNotaDebito)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdImpuesto).HasComment("Codigo del impuesto aplicado, IVA(12%),IVA(0%), ICE, etc");

                entity.Property(e => e.IdPorcentaje).HasComment("codigo del valor del porcentaje, 12%,0%,10%, etc");

                entity.Property(e => e.Tarifa).HasComment("tarifa de impuesto aplicado a cada producto es decir, 12,0,etc");
            });

            modelBuilder.Entity<TnqnotaDebitoMotivo>(entity =>
            {
                entity.HasKey(e => new { e.RucEmpresa, e.IdNotaDebito, e.SecuencialMotivo })
                    .HasName("PK_NotaDebitoMotivo");

                entity.ToTable("TNQNotaDebitoMotivo");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdNotaDebito)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Razon)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__5B65BF970DAF0CB0");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveUsuario).IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdTipoAut)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsuarioDetalle>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__UsuarioD__5B65BF970F624AF8");

                entity.ToTable("UsuarioDetalle");

                entity.Property(e => e.IdUsuario).ValueGeneratedNever();

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoConvencional)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithOne(p => p.UsuarioDetalle)
                    .HasForeignKey<UsuarioDetalle>(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioDetalle_Usuarios");
            });

            modelBuilder.Entity<UsuarioReceptor>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioReceptor)
                    .HasName("PK_UsuarioReceptor_1");

                entity.ToTable("UsuarioReceptor");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RecibirSms).HasColumnName("RecibirSMS");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
