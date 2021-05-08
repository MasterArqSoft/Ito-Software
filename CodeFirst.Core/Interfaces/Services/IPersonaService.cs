using CodeFirst.Core.DTOs.Request.Persona;
using CodeFirst.Core.Wrappers;
using CodeFirst.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFirst.Core.Interfaces.Services
{
    public interface IPersonaService
    {
        Response<IEnumerable<Persona>> GetPersona();

        Task<Response<Persona>> GetPersonaAsync(int id);

        Task<Response<Persona>> InsertPersonaAsync(PersonaAddDtoRequest persona);

        Task<Response<bool>> UpdatePersonaAsync(PersonaUpdateDtoRequest persona);

        Task<Response<bool>> DeletePersonaAsync(int id);
    }
}
