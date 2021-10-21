using AutoMapper;
using dotnetRpg.Dtos.Character;
using dotnetRpg.Models;

namespace dotnetRpg
{
    public class AutoMapperProfile : Profile
    {
       public AutoMapperProfile()
       {
           CreateMap<Character,GetCharacterDto>();
           CreateMap<AddCharacterDto,Character>();
       } 
    }
}