using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class TnqguiaRemisionDetalle
    {
        public string RucEmpresa { get; set; } = null!;
        public string IdGuiaRemision { get; set; } = null!;
        public int SecDestinatario { get; set; }
        public string CodigoInterno { get; set; } = null!;
        public string? CodigoAdicional { get; set; }
        public string Descripcion { get; set; } = null!;
        public double Cantidad { get; set; }
        public string? DetalleAdicional1 { get; set; }
        public string? DetalleAdicional2 { get; set; }
        public string? DetalleAdicional3 { get; set; }
    }
}
