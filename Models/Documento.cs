using System;
using ABONAP.Models.Base;

namespace ABONAP.Models
{
    public class Documento : ModeloBase
    {
        public string? Descripcion { get; set; }
        public int TipoDocumentoId { get; set; }
        public TipoDocumento? TipoDocumento { get; set; }
    }
}

