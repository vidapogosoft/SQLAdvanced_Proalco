using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class ItemSubCategorium
    {
        public int IdItemSubCategoria { get; set; }
        public int IdItemCategoria { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string Estado { get; set; } = null!;

        public virtual ItemCategorium IdItemCategoriaNavigation { get; set; } = null!;
    }
}
