using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class Receptor
    {
        public int IdReceptor { get; set; }
        public string? TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; } = null!;
        public string? Password { get; set; }
        public string? RazonSocial { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public bool? RecibirSms { get; set; }
        public bool? CambiarClave { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? IdEmpresa { get; set; }
        public string? EmailCopias { get; set; }
        public string? Convencional { get; set; }
        public string? Extension { get; set; }
        public string? Direccion { get; set; }
        public bool? EmailBienvenida { get; set; }
        public bool? Estado { get; set; }
    }
}
