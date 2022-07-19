using System;
using ABONAP.Models.Base;

namespace ABONAP.Models
{
	public class Sucursal : ModeloBase
	{
		public string? Descripcion { get; set; }
		public int EmpresaId { get; set; }
		public Empresa? Empresa { get; set; }
	}
}

