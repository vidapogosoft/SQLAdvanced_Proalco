using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class EmpresaUsuario
    {
        public int IdEmpresaUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public int IdUsuario { get; set; }
        public int IdEstado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int UsuarioModificacion { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}
