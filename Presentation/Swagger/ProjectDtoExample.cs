using Application.DTOs;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace Presentation.Swagger
{
    public class ProjectDtoExample : IExamplesProvider<ProjectDto>
    {
        public ProjectDto GetExamples() => new ProjectDto
        {
            Id = 1,
            NameAr = "مشروع سكني فاخر",
            NameEn = "Luxury Residential Project",
            DescriptionAr = "وصف المشروع بالعربية",
            DescriptionEn = "Project description in English",
            LocationAr = "الرياض",
            LocationEn = "Riyadh",
            Region = "الوسطى",
            City = "الرياض",
            District = "العليا",
            Latitude = 24.7136,
            Longitude = 46.6753,
            NumberOfBaths = 3,
            NumberOfBedrooms = 4,
            Cost = 2000000,
            Area = 350,
            DirectLink = "https://balance.com/projects/1",
            AreaUnitAr = "متر مربع",
            AreaUnitEn = "sqm",
            MainImageUrl = "https://cloudinary.com/image.jpg",
            Images = new List<ProjectImageDto> {
                new ProjectImageDto { Id = 1, ImageUrl = "https://cloudinary.com/image.jpg", Caption = "واجهة المشروع", Order = 1 }
            },
            Type = 1,
            Status = 1,
            IsFeatured = true,
            YoutubeVideoUrl = "https://youtube.com/video",
            AssignedEmployeeIds = new List<int> { 2, 3 },
        };
    }

    public class ProjectCreateDtoExample : IExamplesProvider<ProjectCreateDto>
    {
        public ProjectCreateDto GetExamples() => new ProjectCreateDto
        {
            NameAr = "مشروع جديد",
            NameEn = "New Project",
            DescriptionAr = "وصف جديد",
            DescriptionEn = "New description",
            LocationAr = "جدة",
            LocationEn = "Jeddah",
            Region = "الغربية",
            City = "جدة",
            District = "الشاطئ",
            Latitude = 21.4858,
            Longitude = 39.1925,
            NumberOfBaths = 2,
            NumberOfBedrooms = 3,
            Cost = 1500000,
            Area = 250,
            DirectLink = "https://balance.com/projects/2",
            AreaUnitAr = "متر مربع",
            AreaUnitEn = "sqm",
            Type = 2,
            Status = 1,
            IsFeatured = false,
            YoutubeVideoUrl = null,
            AssignedEmployeeIds = new List<int> { 4 },
        };
    }

    public class ProjectUpdateDtoExample : IExamplesProvider<ProjectUpdateDto>
    {
        public ProjectUpdateDto GetExamples() => new ProjectUpdateDto
        {
            Id = 1,
            NameAr = "مشروع محدث",
            NameEn = "Updated Project",
            DescriptionAr = "وصف محدث",
            DescriptionEn = "Updated description",
            LocationAr = "الدمام",
            LocationEn = "Dammam",
            Region = "الشرقية",
            City = "الدمام",
            District = "الخليج",
            Latitude = 26.4207,
            Longitude = 50.0888,
            NumberOfBaths = 2,
            NumberOfBedrooms = 2,
            Cost = 1200000,
            Area = 180,
            DirectLink = "https://balance.com/projects/3",
            AreaUnitAr = "متر مربع",
            AreaUnitEn = "sqm",
            Type = 1,
            Status = 2,
            IsFeatured = false,
            YoutubeVideoUrl = null,
            AssignedEmployeeIds = new List<int> { 5 },
        };
    }
} 