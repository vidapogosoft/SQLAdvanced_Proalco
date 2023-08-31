using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class PreguntasSeguridad
    {
        public PreguntasSeguridad()
        {
            PreguntasUsuarios = new HashSet<PreguntasUsuario>();
        }

        public int IdPregunta { get; set; }
        public string NombrePregunta { get; set; } = null!;
        public int IdEstado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int UsuarioModificacion { get; set; }

        public virtual ICollection<PreguntasUsuario> PreguntasUsuarios { get; set; }
    }
}
