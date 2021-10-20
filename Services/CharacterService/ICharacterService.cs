using System.Collections.Generic;
using dotnetRpg.Models;

namespace dotnetRpg.Services.CharacterService
{
    public interface ICharacterService
    {
         List<Character> GetAllCharacters();
         Character GetCharacterById(int id);
         List<Character> AddCharacter(Character newCharacter);
         
    }
}