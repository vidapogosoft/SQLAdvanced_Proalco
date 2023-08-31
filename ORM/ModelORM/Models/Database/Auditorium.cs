using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Auditorium
    {
        public int IdAuditoria { get; set; }
        public string Descripcion { get; set; } = null!;
        public string NombreTabla { get; set; } = null!;
        public DateTime FechaTransaccion { get; set; }
        public string TipoTransaccion { get; set; } = null!;
        public string Ip { get; set; } = null!;
        public string NombrePc { get; set; } = null!;
    }
}
