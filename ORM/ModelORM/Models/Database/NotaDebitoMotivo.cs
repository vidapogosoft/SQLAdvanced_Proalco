using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class NotaDebitoMotivo
    {
        public int IdNotaDebitoMotivo { get; set; }
        public int IdNotaDebito { get; set; }
        public string RucEmpresa { get; set; } = null!;
        public int IdEmpresa { get; set; }
        public int? IdItem { get; set; }
        public string? Razon { get; set; }
        public double PrecioUnitario { get; set; }
        public string Iva { get; set; } = null!;
        public double PorcentajeIva { get; set; }
        public double ValorIva { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
    }
}
