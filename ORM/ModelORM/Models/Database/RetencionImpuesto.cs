using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class RetencionImpuesto
    {
        public int IdRetencionDetalle { get; set; }
        public int IdEmpresa { get; set; }
        public int? IdComprobanteRetencion { get; set; }
        public string? Codigo { get; set; }
        public int? CodigoRetencion { get; set; }
        public decimal? BaseImponible { get; set; }
        public string? Porcentaje { get; set; }
        public decimal? Valor { get; set; }
        public string? DocumentoSustentoTipo { get; set; }
        public string? DocumentoSustentoCodigo { get; set; }
        public string? CodDocSustento { get; set; }
        public DateTime? DocumentoSustentoFechaEmision { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
    }
}
