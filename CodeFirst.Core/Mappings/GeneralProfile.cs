using AutoMapper;
using CodeFirst.Core.DTOs.Request.Persona;
using CodeFirst.Domain.Entities;

namespace CodeFirst.Core.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<PersonaAddDtoRequest, Persona>();
        }
    }
}
