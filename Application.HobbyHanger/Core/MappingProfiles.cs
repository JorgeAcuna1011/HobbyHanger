using AutoMapper;
using Domain.HobbyHanger;

namespace Application.HobbyHanger.Core;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Clothes, Clothes>();
    }
}