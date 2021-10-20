using System.Collections.Generic;
using System.Linq;
using dotnetRpg.Models;
using dotnetRpg.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace dotnetRpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(CharacterService characterService)//ShortCut - ctor
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {

            return Ok(_characterService.GetAllCharacters());
        }
        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharater)
        {
            return Ok(_characterService.AddCharacter(newCharater));
        }

    }
}