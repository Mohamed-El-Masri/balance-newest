using Application.DTOs;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;
using System;

namespace Presentation.Swagger
{
    public class UserDtoExample : IExamplesProvider<UserDto>
    {
        public UserDto GetExamples() => new UserDto
        {
            Id = 1,
            UserName = "mourad",
            Email = "mourad@example.com",
            PhoneNumber = "+966500000000",
            FirstName = "مراد",
            LastName = "العتيبي",
            ProfilePictureUrl = "https://cloudinary.com/profile.jpg",
            IsActive = true,
            LastLoginAt = DateTime.UtcNow,
            Phones = new List<UserPhoneDto> {
                new UserPhoneDto { Id = 1, PhoneNumber = "+966500000000", IsPrimary = true }
            },
            RoleIds = new List<int> { 1 },
            Favorites = new List<FavoriteDto> {
                new FavoriteDto { Id = 1, ProjectId = 1, UnitId = null }
            }
        };
    }

    public class UserCreateDtoExample : IExamplesProvider<UserCreateDto>
    {
        public UserCreateDto GetExamples() => new UserCreateDto
        {
            UserName = "newuser",
            Email = "newuser@example.com",
            PhoneNumber = "+966511111111",
            FirstName = "جديد",
            LastName = "مستخدم",
            ProfilePictureUrl = null,
            RoleIds = new List<int> { 1 },
            Phones = new List<UserPhoneDto> {
                new UserPhoneDto { Id = 0, PhoneNumber = "+966511111111", IsPrimary = true }
            }
        };
    }

    public class UserUpdateDtoExample : IExamplesProvider<UserUpdateDto>
    {
        public UserUpdateDto GetExamples() => new UserUpdateDto
        {
            Id = 1,
            UserName = "mourad-updated",
            Email = "mourad2@example.com",
            PhoneNumber = "+966522222222",
            FirstName = "مراد",
            LastName = "محدث",
            ProfilePictureUrl = "https://cloudinary.com/profile2.jpg",
            RoleIds = new List<int> { 1 },
            Phones = new List<UserPhoneDto> {
                new UserPhoneDto { Id = 2, PhoneNumber = "+966522222222", IsPrimary = true }
            }
        };
    }

    public class UserPhoneDtoExample : IExamplesProvider<UserPhoneDto>
    {
        public UserPhoneDto GetExamples() => new UserPhoneDto
        {
            Id = 1,
            PhoneNumber = "+966500000000",
            IsPrimary = true
        };
    }

    public class FavoriteDtoExample : IExamplesProvider<FavoriteDto>
    {
        public FavoriteDto GetExamples() => new FavoriteDto
        {
            Id = 1,
            ProjectId = 1,
            UnitId = null
        };
    }
} 