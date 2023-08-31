using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class EmpresaInformacionComercial
    {
        public int IdEmpresa { get; set; }
        public string NombreComercial { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string Ruc { get; set; } = null!;
        public string Contacto { get; set; } = null!;
        public string? Telefono1 { get; set; }
        public string? Telefono2 { get; set; }
        public string? Email { get; set; }
        public DateTime FechaInicioOperaciones { get; set; }
        public DateTime FechaInicioActualPeriodo { get; set; }
        public DateTime FechaFinActualPeriodo { get; set; }
        public decimal ValorPago { get; set; }
        public string? PeriodicidadPago { get; set; }
        public string Observacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string UsuarioIngreso { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public string? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
