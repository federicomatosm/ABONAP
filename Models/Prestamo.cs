using System;
using ABONAP.Models.Base;

namespace ABONAP.Models
{
    public class Prestamo : ModeloBase
    {
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public int SucursalId { get; set; }
        public Sucursal? Sucursal { get; set; }
    }
}

