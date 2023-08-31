using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class EmailAdjunto
    {
        public int IdEmailAdjuntos { get; set; }
        public int IdEmpresa { get; set; }
        public string NumeroComprobante { get; set; } = null!;
        public string? DocumentosAdjuntos { get; set; }
        public string? EmailCopia { get; set; }
        public string Estado { get; set; } = null!;
        public bool Activo { get; set; }
        public bool Enviado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
