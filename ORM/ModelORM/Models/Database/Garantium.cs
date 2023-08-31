using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Garantium
    {
        public int IdGarantia { get; set; }
        public int IdEmpresa { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? TextoGarantia { get; set; }
        public string Estado { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
    }
}
