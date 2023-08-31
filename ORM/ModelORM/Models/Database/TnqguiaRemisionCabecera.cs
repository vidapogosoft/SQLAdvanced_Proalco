using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class TnqguiaRemisionCabecera
    {
        public string RucEmpresa { get; set; } = null!;
        public string IdGuiaRemision { get; set; } = null!;
        public string CodigoEstablecimiento { get; set; } = null!;
        public string PuntoEmision { get; set; } = null!;
        public string NumeroGuia { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string DireccionEstablecimiento { get; set; } = null!;
        public string DireccionPartida { get; set; } = null!;
        public string RazonSocialTransportista { get; set; } = null!;
        public string TipoIdentificacionTransportista { get; set; } = null!;
        public string NumeroIdentificacionTransportista { get; set; } = null!;
        public DateTime FechaInicioTransporte { get; set; }
        public DateTime FechaFinTransporte { get; set; }
        public string Placa { get; set; } = null!;
        public bool Procesado { get; set; }
        public string? DetaAdic1 { get; set; }
        public string? DetaAdic2 { get; set; }
        public string? DetaAdic3 { get; set; }
        public string? Email { get; set; }
    }
}
