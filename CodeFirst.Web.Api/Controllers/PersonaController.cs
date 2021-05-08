using AutoMapper;
using CodeFirst.Core.DTOs.Request.Persona;
using CodeFirst.Core.Interfaces.Services;
using CodeFirst.Core.Wrappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CodeFirst.Web.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _persona;
        private readonly IMapper _mapper;

        public PersonaController(
            IPersonaService persona,
            IMapper mapper
            )
        {
            _persona = persona;
            _mapper = mapper;
        }

        /// <summary>
        /// Obtiene el listado persona.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     Get api/persona/
        ///
        /// </remarks>
        /// <returns>Retorna Objeto persona solicitado</returns>
        /// <response code="500">InternalServerError. Ha ocurrido una exception no controlada.</response>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [HttpGet(Name = nameof(GetAll))]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public IActionResult GetAll()
        {

            return Ok(_persona.GetPersona());
        }

        /// <summary>
        /// Obtiene un objeto persona por su Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     Get api/persona/1
        ///
        /// </remarks>
        /// <returns>Retorna Objeto persona solicitado</returns>
        /// <param name="id">Identificador del objeto persona.</param>
        /// <response code="500">InternalServerError. Ha ocurrido una exception no controlada.</response>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _persona.GetPersonaAsync(id).ConfigureAwait(false));
        }

        /// <summary>
        /// Crea un nuevo objeto persona.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     Post api/persona/
        ///
        /// </remarks>
        /// <returns>Retorna el Objeto persona solicitado</returns>
        /// <param name="persona">El objeto persona.</param>
        /// <response code="500">InternalServerError. Ha ocurrido una exception no controlada.</response>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [HttpPost]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Post(PersonaAddDtoRequest persona)
        {
            return Ok(await _persona.InsertPersonaAsync(persona));
        }

        /// <summary>
        /// Actualiza el objeto persona.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     Put api/persona/
        ///
        /// </remarks>
        /// <returns>Retorna el Objeto persona solicitado</returns>
        /// <param name="persona">El objeto persona.</param>
        /// <response code="500">InternalServerError. Ha ocurrido una exception no controlada.</response>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [HttpPut]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Put(PersonaUpdateDtoRequest persona)
        {
            return Ok(await _persona.UpdatePersonaAsync(persona));
        }

        /// <summary>
        /// Elimina el objeto persona.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     Put api/persona/
        ///
        /// </remarks>
        /// <returns>Retorna el Objeto persona solicitado</returns>
        /// <param name="id">El objeto persona.</param>
        /// <response code="500">InternalServerError. Ha ocurrido una exception no controlada.</response>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>
        /// <response code="404">NotFound. No se ha encontrado el objeto solicitado.</response>
        [HttpDelete]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _persona.DeletePersonaAsync(id));
        }
    }
}