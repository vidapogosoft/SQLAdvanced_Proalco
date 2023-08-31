using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class ReceptorEmpresa
    {
        public int IdEmpresa { get; set; }
        public int IdReceptor { get; set; }
        public bool? EmailBienvenida { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
