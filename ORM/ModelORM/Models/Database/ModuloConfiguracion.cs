using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class ModuloConfiguracion
    {
        public int IdModuloConfiguracion { get; set; }
        public int IdModulo { get; set; }
        public int IdEmpresa { get; set; }
        public string CodigoParametro { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Valor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModificacion { get; set; }
        public string Estado { get; set; } = null!;

        public virtual ModuloEmpresa Id { get; set; } = null!;
    }
}
