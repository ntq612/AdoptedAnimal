using AnimalService.DTOs;
using AnimalService.Entities;
using AutoMapper;

namespace AnimalService.Helpers
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<Animal, AnimalDto>();
            CreateMap<CreateAnimalDto, Animal>();
            CreateMap<AnimalDto, AnimalCreated>();
            CreateMap<Animal, AnimalUpdated>();
        }
    }
}
