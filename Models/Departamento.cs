using System;
using ABONAP.Models.Base;

namespace ABONAP.Models
{
    public class Departamento : ModeloBase
    {
        public string? Descripcion { get; set; }
        public int SucursalId { get; set; }
        public Sucursal? Sucursal { get; set; }


    }
}

