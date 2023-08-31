using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class NotaDebitoFormaPago
    {
        public int IdNotaDebitoFormaPago { get; set; }
        public int IdNotaDebito { get; set; }
        public string FormaPago { get; set; } = null!;
        public double Total { get; set; }
        public string Plazo { get; set; } = null!;
        public string UnidadTiempo { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModificacion { get; set; }

        public virtual NotaDebito IdNotaDebitoNavigation { get; set; } = null!;
    }
}
