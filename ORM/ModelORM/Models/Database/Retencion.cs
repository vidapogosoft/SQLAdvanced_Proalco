using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Retencion
    {
        public int IdComprobanteRetencion { get; set; }
        public string NumeroComprobanteRetencion { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public int IdEmpresa { get; set; }
        public string? DirecccionEstablecimiento { get; set; }
        public string? TipoIdentificacionComprador { get; set; }
        public string? RazonSocial { get; set; }
        public string? NumeroIdentificacion { get; set; }
        public string? PeriodoFiscal { get; set; }
        public bool Procesado { get; set; }
        public string? Atributo1 { get; set; }
        public string? Atributo2 { get; set; }
        public string? Atributo3 { get; set; }
        public string? Atributo4 { get; set; }
        public string? Atributo5 { get; set; }
        public string? DetaAdic1 { get; set; }
        public string? DetaAdic2 { get; set; }
        public string? DetaAdic3 { get; set; }
        public string? DetaAdic4 { get; set; }
        public string? DetaAdic5 { get; set; }
        public string NumeroSecuencial { get; set; } = null!;
        public int IdSucursal { get; set; }
        public string? Email { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
        public virtual Sucursal IdSucursalNavigation { get; set; } = null!;
    }
}
