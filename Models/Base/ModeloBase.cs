using System;
namespace ABONAP.Models.Base
{
	public class ModeloBase
	{
		public int Id { get; set; }
		public DateTime? FechaCreacion { get; set; }
		public DateTime? FechaActualizacion { get; set; }
		public string? Codigo { get; set; }
		public bool Estado { get; set; }
	}
}

