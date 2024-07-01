using AutoMapper;
using Practice2.DTO;
using Practice2.Models;

namespace Practice2.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile() 
        {
            CreateMap<Command,CommandReadDTO>();
            CreateMap<CommandCreateDTO, Command>();
            CreateMap<CommandUpdateDTO, Command>();
            CreateMap<Command, CommandUpdateDTO>();
        }
    }
}
