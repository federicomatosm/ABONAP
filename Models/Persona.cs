using ABONAP.Models.Base;

namespace ABONAP.Models
{
    public class Persona : ModeloBase
    {
        public string? Nombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }

    }
}