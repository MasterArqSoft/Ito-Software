using CodeFirst.Domain.Enums;

namespace CodeFirst.Domain.Entities
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int DepartamentoId { get; set; }
        public TipoDocumento TipoDocumentoId { get; set; }
    }
}
