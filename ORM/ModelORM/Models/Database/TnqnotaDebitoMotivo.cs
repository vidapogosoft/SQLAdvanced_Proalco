using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class TnqnotaDebitoMotivo
    {
        public string RucEmpresa { get; set; } = null!;
        public string IdNotaDebito { get; set; } = null!;
        public int SecuencialMotivo { get; set; }
        public string Razon { get; set; } = null!;
        public double Valor { get; set; }
    }
}
