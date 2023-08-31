using System;
using System.Collections.Generic;

namespace ModelORM.Models.Database
{
    public partial class EmpresaEmail
    {
        public int IdEmpresaEmail { get; set; }
        public int IdEmpresa { get; set; }
        public string? Remitente { get; set; }
        public string? NombreServidor { get; set; }
        public short? Puerto { get; set; }
        public bool? EsSsl { get; set; }
        public string? Usuario { get; set; }
        public string? Pwd { get; set; }
        public string? RutaBannerSuperior { get; set; }
        public string? RutaBannerInferior { get; set; }
        public string? TextoMailRecepcionComprobante { get; set; }
        public string? TextoMailBienvenida { get; set; }
        public string? Estado { get; set; }
        public string? ClienteUsar { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
    }
}
