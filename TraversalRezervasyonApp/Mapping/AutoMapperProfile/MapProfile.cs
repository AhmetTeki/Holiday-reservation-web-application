using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.CityDTOs;
using EntityLayer.Concrete;

namespace TraversalRezervasyonApp.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDTOs, Announcement>().ReverseMap();
            CreateMap<AppUserRegisterDTOs, AppUser>().ReverseMap();
            CreateMap<AppUserLoginDTOs, AppUser>().ReverseMap();
            CreateMap<AnnouncementListDTO, Announcement>().ReverseMap();
            CreateMap<AnnouncementUpdateDto, Announcement>().ReverseMap();
           
        }
    }
}
