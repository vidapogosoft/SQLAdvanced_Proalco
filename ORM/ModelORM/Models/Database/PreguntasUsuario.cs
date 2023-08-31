using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class PreguntasUsuario
    {
        public int IdpreguntaUsuario { get; set; }
        public int IdPregunta { get; set; }
        public int IdUsuario { get; set; }
        public string Respuesta { get; set; } = null!;
        public int IdEstado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int UsuarioModificacion { get; set; }

        public virtual PreguntasSeguridad IdPreguntaNavigation { get; set; } = null!;
        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}
