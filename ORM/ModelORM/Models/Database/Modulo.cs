using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Modulo
    {
        public Modulo()
        {
            Funcionalidads = new HashSet<Funcionalidad>();
            ModuloEmpresas = new HashSet<ModuloEmpresa>();
        }

        public int IdModulo { get; set; }
        public string CodigoModulo { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModificacion { get; set; }
        public string Estado { get; set; } = null!;

        public virtual ICollection<Funcionalidad> Funcionalidads { get; set; }
        public virtual ICollection<ModuloEmpresa> ModuloEmpresas { get; set; }
    }
}
