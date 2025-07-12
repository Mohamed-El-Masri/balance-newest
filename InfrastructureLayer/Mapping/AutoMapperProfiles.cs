using AutoMapper;
using Domain.Entities;
using Application.DTOs;

namespace Infrastructure.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            // Project mappings
            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<ProjectCreateDto, Project>();
            CreateMap<ProjectUpdateDto, Project>();
            CreateMap<ProjectImage, ProjectImageDto>().ReverseMap();
            
            // Unit mappings
            CreateMap<Unit, UnitDto>().ReverseMap();
            CreateMap<UnitCreateDto, Unit>();
            CreateMap<UnitUpdateDto, Unit>();
            
            // User mappings
            CreateMap<ApplicationUser, UserDto>().ReverseMap();
            CreateMap<UserCreateDto, ApplicationUser>();
            CreateMap<UserUpdateDto, ApplicationUser>();
            CreateMap<UserPhone, UserPhoneDto>().ReverseMap();
            CreateMap<Favorite, FavoriteDto>().ReverseMap();
            
            // Task mappings
            CreateMap<TaskItem, TaskItemDto>().ReverseMap();
            CreateMap<TaskItemCreateDto, TaskItem>();
            CreateMap<TaskItemUpdateDto, TaskItem>();
            
            // Notification mappings
            CreateMap<Notification, NotificationDto>().ReverseMap();
            CreateMap<NotificationCreateDto, Notification>();
            
            // ContentComponent mappings
            CreateMap<ContentComponent, ContentComponentDto>().ReverseMap();
            CreateMap<ContentComponentCreateDto, ContentComponent>();
            CreateMap<ContentComponentUpdateDto, ContentComponent>();
        }
    }
}