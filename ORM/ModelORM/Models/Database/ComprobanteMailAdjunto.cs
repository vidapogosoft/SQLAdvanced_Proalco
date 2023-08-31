using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class ComprobanteMailAdjunto
    {
        public int IdComprobanteMailAdjunto { get; set; }
        public int IdEmpresa { get; set; }
        public string TipoComprobante { get; set; } = null!;
        public string SubTipoComprobante { get; set; } = null!;
        public bool Adjunto { get; set; }
        public int UsuarioIngreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int UsuarioModificacion { get; set; }
    }
}
