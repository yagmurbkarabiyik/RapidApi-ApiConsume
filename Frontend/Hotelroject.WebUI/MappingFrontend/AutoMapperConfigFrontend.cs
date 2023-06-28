using AutoMapper;
using HotelProjectEntityLayer.Concrete;
using Hotelroject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;

namespace Hotelroject.WebUI.MappingFrontend
{
    public class AutoMapperConfigFrontend : Profile
    {
        public AutoMapperConfigFrontend()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
        }
    }
}
