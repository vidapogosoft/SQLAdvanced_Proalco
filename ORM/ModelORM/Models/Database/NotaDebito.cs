using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class NotaDebito
    {
        public NotaDebito()
        {
            NotaDebitoFormaPagos = new HashSet<NotaDebitoFormaPago>();
        }

        public int IdNotaDebito { get; set; }
        public string RucEmpresa { get; set; } = null!;
        public string CodigoEstablecimiento { get; set; } = null!;
        public string PuntotoEmision { get; set; } = null!;
        public string NumeroSecuencial { get; set; } = null!;
        public string NumeroNotaDebito { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string? DirecccionEstablecimiento { get; set; }
        public string TipoIdentificacionComprador { get; set; } = null!;
        public string NumeroIdentificacion { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string? CodigoDocumentoModificado { get; set; }
        public string? NumeroDocumentoModificado { get; set; }
        public DateTime? FechaEmesionDocumentoModificado { get; set; }
        public decimal TotalSinImpuesto { get; set; }
        public decimal ValorTotal { get; set; }
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
        public int IdEmpresa { get; set; }
        public string DirecccionMatriz { get; set; } = null!;
        public string IdSucursal { get; set; } = null!;
        public int? IdReceptor { get; set; }
        public decimal TotalIva { get; set; }
        public string? Email { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioCreacion { get; set; }
        public string? UsuarioModificacion { get; set; }
        public string? Estado { get; set; }

        public virtual ICollection<NotaDebitoFormaPago> NotaDebitoFormaPagos { get; set; }
    }
}
