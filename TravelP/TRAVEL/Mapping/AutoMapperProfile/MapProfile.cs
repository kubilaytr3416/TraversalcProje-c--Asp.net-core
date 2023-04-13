using AutoMapper;
using BusinessLayer.ValidationRules.ContactUs;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOS;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;

namespace TRAVEL.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDTOs, Announcement>();
            CreateMap<Announcement, AnnouncementAddDTOs>();
              
            CreateMap<AppUserRegisterDTOs, AppUser>();
            CreateMap<AppUser, AnnouncementAddDTOs>();
            
            CreateMap<AppUserLoginDTOs, AppUser>();
            CreateMap<AppUser, AppUserLoginDTOs>();

            CreateMap<AnnouncementListDTOs,Announcement>();
            CreateMap<Announcement,AnnouncementListDTOs>();

            CreateMap<AnnouncementUpdateDTOs, Announcement>();
            CreateMap<Announcement, AnnouncementUpdateDTOs>();

            CreateMap<SendMessageDto, ContactUs>().ReverseMap();






        }
    }
}
