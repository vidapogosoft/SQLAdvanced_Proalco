using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class SucursalSecuencial
    {
        public int IdSecuencial { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string? TipoComprobante { get; set; }
        public int? NumeroSecuencial { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
    }
}
