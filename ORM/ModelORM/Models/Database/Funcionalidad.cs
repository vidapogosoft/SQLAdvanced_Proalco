using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Funcionalidad
    {
        public int IdFuncionalidad { get; set; }
        public int? IdFuncionalidadPadre { get; set; }
        public string IdTipoFuncionalidad { get; set; } = null!;
        public int IdModulo { get; set; }
        public string? NombreFuncionalidad { get; set; }
        public string? DescripcionFuncionalidad { get; set; }
        public string? FormularioFuncionalidad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public string Estado { get; set; } = null!;

        public virtual Modulo IdModuloNavigation { get; set; } = null!;
    }
}
