using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class GuiaRemisionDetalle
    {
        public int IdGuiaRemisionDetalle { get; set; }
        public int IdEmpresa { get; set; }
        public int IdGuiaRemision { get; set; }
        public int? IdItem { get; set; }
        public string? OtroConcepto { get; set; }
        public double Cantidad { get; set; }
        public string? Atributo1 { get; set; }
        public string? DescripcionAtributo1 { get; set; }
        public string? Atributo2 { get; set; }
        public string? DescripcionAtributo2 { get; set; }
        public string? Atributo3 { get; set; }
        public string? DescripcionAtributo3 { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModificacion { get; set; }
        public string Estado { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
        public virtual Item? IdItemNavigation { get; set; }
    }
}
