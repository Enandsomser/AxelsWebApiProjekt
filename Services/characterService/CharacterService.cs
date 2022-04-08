using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEST_dotnet.models;

namespace TEST_dotnet.Services.characterService
{
    public class CharacterService : iCharacterService
    {
         private static List<Character> Balls = new List<Character>
        {
            new Character(),
            new Character { Id = 1, Name = "Glanga" }
        };
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            Balls.Add(newCharacter);
            serviceResponse.Data = Balls;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = Balls;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
             serviceResponse.Data = Balls.FirstOrDefault(c => c.Id == id);
             return serviceResponse;
        }
    }
}