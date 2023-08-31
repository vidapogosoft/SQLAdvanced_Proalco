using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class PersonaContacto
    {
        public int IdPersonaContacto { get; set; }
        public int IdPersona { get; set; }
        public string Nombres { get; set; } = null!;
        public string? Relacion { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public string? Convencional { get; set; }
        public string? Extension { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
    }
}
