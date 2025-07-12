using Swashbuckle.AspNetCore.Filters;

namespace Presentation.Swagger
{
    public class InterestRequestDtoExample : IExamplesProvider<object>
    {
        public object GetExamples() => new
        {
            Id = 1,
            Name = "ضيف مهتم",
            Email = "guest@example.com",
            Phone = "+966533333333",
            ProjectId = 1,
            UnitId = (int?)null,
            Message = "أرغب في معرفة المزيد عن المشروع"
        };
    }

    public class InterestRequestCreateDtoExample : IExamplesProvider<object>
    {
        public object GetExamples() => new
        {
            Name = "ضيف جديد",
            Email = "newguest@example.com",
            Phone = "+966544444444",
            ProjectId = 2,
            UnitId = (int?)null,
            Message = "هل المشروع متاح؟"
        };
    }
} 