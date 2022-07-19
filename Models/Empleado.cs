using System;
using ABONAP.Models.Base;

namespace ABONAP.Models
{
	public class Empleado : ModeloBase
	{
		public int PersonaId { get; set; }
		public int SucursalId { get; set; }

		public Persona? Persona { get; set; }
		public Sucursal? Sucursal { get; set; }
	}
}

