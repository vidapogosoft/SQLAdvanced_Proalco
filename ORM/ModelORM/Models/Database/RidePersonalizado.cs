using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class RidePersonalizado
    {
        public int IdRidePersonalizado { get; set; }
        public string TipoComprobante { get; set; } = null!;
        public string SubTipoComprobante { get; set; } = null!;
        public int IdEmpresa { get; set; }
        public string NombreRide { get; set; } = null!;
        public string FormularioRide { get; set; } = null!;
        public bool Estado { get; set; }
        public int UsuarioIngreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
