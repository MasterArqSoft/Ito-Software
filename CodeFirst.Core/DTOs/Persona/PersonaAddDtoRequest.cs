using CodeFirst.Domain.Enums;

namespace CodeFirst.Core.DTOs.Request.Persona
{
    public class PersonaAddDtoRequest
    {
        public string NumeroDocumento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int DepartamentoId { get; set; }
        public TipoDocumento TipoDocumentoId { get; set; }
    }
}
