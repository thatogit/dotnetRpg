using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetRpg.Models;

namespace dotnetRpg.Services.CharacterService
{
    public interface ICharacterService
    {
         Task <ServiceResponse<List<Character>>> GetAllCharacters();
         Task <ServiceResponse<Character>> GetCharacterById(int id);
         Task <ServiceResponse<List<Character>>> AddCharacter(Character newCharact);
         
    }
}