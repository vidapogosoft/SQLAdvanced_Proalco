using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class ModuloEmpresa
    {
        public ModuloEmpresa()
        {
            ModuloConfiguracions = new HashSet<ModuloConfiguracion>();
        }

        public int IdModulo { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModificacion { get; set; }
        public string Estado { get; set; } = null!;

        public virtual Modulo IdModulo1 { get; set; } = null!;
        public virtual Empresa IdModuloNavigation { get; set; } = null!;
        public virtual ICollection<ModuloConfiguracion> ModuloConfiguracions { get; set; }
    }
}
