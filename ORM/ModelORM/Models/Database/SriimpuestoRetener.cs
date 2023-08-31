using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class SriimpuestoRetener
    {
        public int IdImpuestoRetener { get; set; }
        public string ImpuestoRetener { get; set; } = null!;
        public string CodigoImpuestoRetener { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string UsuarioIngreso { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public string? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
