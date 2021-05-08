using AutoMapper;
using CodeFirst.Core.DTOs.Request.Persona;
using CodeFirst.Core.Exceptions;
using CodeFirst.Core.Interfaces.Repositories;
using CodeFirst.Core.Interfaces.Services;
using CodeFirst.Core.Wrappers;
using CodeFirst.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFirst.Core.Features.PersonaServices
{
    public class PersonaService : IPersonaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public PersonaService(
            IUnitOfWork unitOfWork,
            IMapper mapper
            )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response<bool>> DeletePersonaAsync(int id)
        {
            await _unitOfWork.PersonaRepositoryAsync.Delete(id).ConfigureAwait(false);
            await _unitOfWork.CommitAsync();
            return new Response<bool>(true);
        }
        public async Task<Response<Persona>> GetPersonaAsync(int id)
        {
            Persona persona = await _unitOfWork.PersonaRepositoryAsync
                                           .GetById(id)
                                           .ConfigureAwait(false);
            if (persona == null) { throw new CoreException("Persona no Encontrado."); }
            return new Response<Persona>(persona);
        }

        public Response<IEnumerable<Persona>> GetPersona()
        {
            Response<IEnumerable<Persona>> ListPersona = new();
            ListPersona.Data = _unitOfWork.PersonaRepositoryAsync.GetAll();

            return ListPersona;
        }
        public async Task<Response<Persona>> InsertPersonaAsync(PersonaAddDtoRequest persona)
        {
            Persona PersonaMap = _mapper.Map<Persona>(persona);
            await _unitOfWork.PersonaRepositoryAsync.Add(PersonaMap).ConfigureAwait(false);
            await _unitOfWork.CommitAsync();
            return new Response<Persona>(PersonaMap);
        }
        public async Task<Response<bool>> UpdatePersonaAsync(PersonaUpdateDtoRequest persona)
        {
            Response<Persona> PersonaUpdate = await GetPersonaAsync(persona.PersonaId).ConfigureAwait(false);
            PersonaUpdate.Data.Nombres = persona.Nombres;
            PersonaUpdate.Data.Apellidos = persona.Apellidos;
            PersonaUpdate.Data.DepartamentoId = persona.DepartamentoId;
            _unitOfWork.PersonaRepositoryAsync.Update(PersonaUpdate.Data);
            await _unitOfWork.CommitAsync();
            return new Response<bool>(PersonaUpdate != null);
        }

    }
}
