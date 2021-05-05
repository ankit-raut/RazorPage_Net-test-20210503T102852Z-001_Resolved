using AutoMapper;

using StardekkMediorFullstackDeveloper.Model.Models;
using StardekkMediorFullstackDeveloper.Model.ViewModels;
using System.Collections.Generic;

namespace StardekkMediorFullstackDeveloper.BAL.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AmenityViewModel, Amenity>().ReverseMap();
            CreateMap<RoomViewModel, Room>().ReverseMap();
            CreateMap<RoomTypeViewModel, RoomType>().ReverseMap();
        }
    }
}
