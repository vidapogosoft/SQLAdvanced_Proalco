using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Contingencia
    {
        public int IdContingencia { get; set; }
        public int IdEmpresa { get; set; }
        public string RucEmpresa { get; set; } = null!;
        public string NumeroContingencia { get; set; } = null!;
        public bool Utilizado { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
