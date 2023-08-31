using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class NotaDebitoImpuesto
    {
        public string RucEmpresa { get; set; } = null!;
        public int IdNotaDebito { get; set; }
        public int NumeroSecuencial { get; set; }
        public int IdImpuesto { get; set; }
        public int IdPorcentaje { get; set; }
        public string Tarifa { get; set; } = null!;
        public string CodigoTarifa { get; set; } = null!;
        public double BaseImponible { get; set; }
        public double Valor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
    }
}
