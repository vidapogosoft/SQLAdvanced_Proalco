using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Usuario
    {
        public Usuario()
        {
            EmpresaUsuarios = new HashSet<EmpresaUsuario>();
            PreguntasUsuarios = new HashSet<PreguntasUsuario>();
        }

        public int IdUsuario { get; set; }
        public string Cedula { get; set; } = null!;
        public string NombreUsuario { get; set; } = null!;
        public string ClaveUsuario { get; set; } = null!;
        public int IdEstado { get; set; }
        public string IdTipoAut { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public int UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int UsuarioModificacion { get; set; }

        public virtual UsuarioDetalle? UsuarioDetalle { get; set; }
        public virtual ICollection<EmpresaUsuario> EmpresaUsuarios { get; set; }
        public virtual ICollection<PreguntasUsuario> PreguntasUsuarios { get; set; }
    }
}
