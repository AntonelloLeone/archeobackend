using AutoMapper;
using WebApplication1.Dtos;
using WebApplication1.Models;

namespace WebApplication1.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<DrawTypeDto, DrawType>();
            CreateMap<DrawType, DrawTypeDto>();
        }
    }
}
