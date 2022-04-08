using Microsoft.AspNetCore.Mvc;
using TEST_dotnet.models;
using System.Collections.Generic;
using System.Linq;
using TEST_dotnet.Services.characterService;
using System.Threading.Tasks;

namespace TEST_dotnet.Controllers
{
    [ApiController]
    [Route("controller")]
    public class CharacterControler : ControllerBase
    {
        private readonly iCharacterService _characterService;

        public CharacterControler(iCharacterService characterService)
        {
            _characterService = characterService;

        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetSingel(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}