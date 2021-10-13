using Api.Dtos;
using AutoMapper;
using Core.Entities.Identity;

namespace Api.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}