using System;
using System.Collections.Generic;

namespace Application.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public List<UserPhoneDto> Phones { get; set; }
        public List<int> RoleIds { get; set; }
        public List<FavoriteDto> Favorites { get; set; }
    }

    public class UserCreateDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public List<int> RoleIds { get; set; }
        public List<UserPhoneDto> Phones { get; set; }
    }

    public class UserUpdateDto : UserCreateDto
    {
        public int Id { get; set; }
    }

    public class UserFilterDto
    {
        public string? Search { get; set; }
        public int? RoleId { get; set; }
        public bool? IsActive { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }

    public class UserPhoneDto
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsPrimary { get; set; }
    }

    public class FavoriteDto
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? UnitId { get; set; }
    }
} 