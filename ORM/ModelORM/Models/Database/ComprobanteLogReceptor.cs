using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class ComprobanteLogReceptor
    {
        public int IdComprobanteLogReceptor { get; set; }
        public int IdReceptor { get; set; }
        public string NumeroIdentificacion { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public int IdEmpresa { get; set; }
        public string Descripcion { get; set; } = null!;
        public string TipoAccion { get; set; } = null!;
        public string? NumeroComprobante { get; set; }
        public string? TipoComprobante { get; set; }
        public DateTime FechaLog { get; set; }
    }
}
