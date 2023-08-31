using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Errore
    {
        public int IdError { get; set; }
        public string? DescripcionError { get; set; }
        public int IdEstado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int UsuarioModificacion { get; set; }
    }
}
