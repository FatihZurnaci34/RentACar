using AutoMapper;
using Entities.Concrete;
using Entities.ViewModels;

namespace RentACarMVC.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<Car, VMCarAdd>();
            CreateMap<Car, VMCarUpdate>();
            CreateMap<Color, VMColorList>();
            CreateMap<Color, VMColorAdd>();
            CreateMap<Color, VMColorDelete>();
            CreateMap<Color, VMColorUpdate>();

            // Resource to Domain
            CreateMap<VMCarAdd, Car>();
            CreateMap<VMCarUpdate, Car>();
            CreateMap<VMColorList, Color>();
            CreateMap<VMColorDelete, Color>();
            CreateMap<VMColorAdd, Color>();
            CreateMap<VMColorUpdate, Color>();

        }
    }
}
