using Application.DTOs;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace Presentation.Swagger
{
    public class UnitDtoExample : IExamplesProvider<UnitDto>
    {
        public UnitDto GetExamples() => new UnitDto
        {
            Id = 1,
            TitleAr = "شقة فاخرة",
            TitleEn = "Luxury Apartment",
            DescriptionAr = "شقة واسعة بإطلالة جميلة",
            DescriptionEn = "Spacious apartment with a nice view",
            Price = 900000,
            Area = 120,
            ProjectId = 1,
            Status = 1,
            Floor = 5,
            Building = "A",
            NumberOfRooms = 3,
            Latitude = 24.7136,
            Longitude = 46.6753,
            Images = new List<UnitImageDto> {
                new UnitImageDto { Id = 1, ImageUrl = "https://cloudinary.com/unit.jpg", Caption = "غرفة النوم", Order = 1 }
            },
            FeatureIds = new List<int> { 1, 2 },
            NoteIds = new List<int> { 1 },
            TaskIds = new List<int> { 1 },
            CreatedAt = System.DateTime.Now
        };
    }

    public class UnitCreateDtoExample : IExamplesProvider<UnitCreateDto>
    {
        public UnitCreateDto GetExamples() => new UnitCreateDto
        {
            TitleAr = "شقة جديدة",
            TitleEn = "New Apartment",
            DescriptionAr = "شقة جديدة في مشروع جديد",
            DescriptionEn = "New apartment in a new project",
            Price = 800000,
            Area = 100,
            ProjectId = 2,
            Status = 1,
            Floor = 2,
            Building = "B",
            NumberOfRooms = 2,
            Latitude = 21.4858,
            Longitude = 39.1925,
            FeatureIds = new List<int> { 3 }
        };
    }

    public class UnitUpdateDtoExample : IExamplesProvider<UnitUpdateDto>
    {
        public UnitUpdateDto GetExamples() => new UnitUpdateDto
        {
            Id = 1,
            TitleAr = "شقة محدثة",
            TitleEn = "Updated Apartment",
            DescriptionAr = "شقة تم تحديثها",
            DescriptionEn = "Apartment updated",
            Price = 950000,
            Area = 130,
            ProjectId = 1,
            Status = 2,
            Floor = 6,
            Building = "A",
            NumberOfRooms = 4,
            Latitude = 24.7136,
            Longitude = 46.6753,
            FeatureIds = new List<int> { 1, 2, 3 }
        };
    }
} 