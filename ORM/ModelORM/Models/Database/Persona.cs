using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Persona
    {
        public Persona()
        {
            GuiaRemisionIdPersonaNavigations = new HashSet<GuiaRemision>();
            GuiaRemisionIdProveedorNavigations = new HashSet<GuiaRemision>();
        }

        public int IdEmpresa { get; set; }
        public int IdPersona { get; set; }
        public string? TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string? Email { get; set; }
        public string? EmailCopias { get; set; }
        public string? Celular { get; set; }
        public string? Convencional { get; set; }
        public string? Extension { get; set; }
        public string? Direccion { get; set; }
        public bool? EmailBienvenida { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;

        public virtual Empleado? Empleado { get; set; }
        public virtual Proveedor? Proveedor { get; set; }
        public virtual ICollection<GuiaRemision> GuiaRemisionIdPersonaNavigations { get; set; }
        public virtual ICollection<GuiaRemision> GuiaRemisionIdProveedorNavigations { get; set; }
    }
}
