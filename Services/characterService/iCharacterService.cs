using System.Collections.Generic;
using System.Threading.Tasks;
using TEST_dotnet.models;

namespace TEST_dotnet.Services.characterService
{
    public interface iCharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);

        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}