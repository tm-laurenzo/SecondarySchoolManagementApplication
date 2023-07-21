using AutoMapper;
using SSMA.DTOs.PrincipalDTOs;
using SSMA.Models.Models;

namespace SSMA.Utilities
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Principal, AddPrincipalDTO>().ReverseMap();
            CreateMap<Principal, UpdatePrincipalDTO>().ReverseMap();
        }
    }
}
