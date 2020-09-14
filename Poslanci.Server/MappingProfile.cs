using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace Poslanci.Server
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Poslanec, PoslanecDto>();

            CreateMap<Osoba, OsobaDto>();

            CreateMap<Organ, OrganDto>();
        }
    }
}
