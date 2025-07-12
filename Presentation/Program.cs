using Presentation.Extensions;
using Presentation.Middleware;
using Infrastructure.DependencyInjection;
using Application.DependencyInjection;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.AspNetCore.HttpsPolicy;

var builder = WebApplication.CreateBuilder(args);

// Configure HTTPS
builder.Services.AddHttpsRedirection(options =>
{
    options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
    options.HttpsPort = 5001;
});

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // استخدام AddSwaggerGen البسيط بدلاً من AddSwaggerDocumentation
// builder.Services.AddLocalizationServices();
// builder.Services.AddPresentationServices();
// builder.Services.AddSwaggerExamplesFromAssemblyOf<Presentation.Swagger.ProjectDtoExample>();
// builder.Services.AddApplicationServices();
// builder.Services.AddInfrastructure(builder.Configuration.GetConnectionString("DefaultConnection") ?? "Server=(localdb)\\mssqllocaldb;Database=BalanceDb;Trusted_Connection=True;");

// Authentication - معلق مؤقتاً للاختبار
/*
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = "JwtBearer";
    options.DefaultChallengeScheme = "JwtBearer";
})
.AddJwtBearer("JwtBearer", options =>
{
    var jwtConfig = builder.Configuration.GetSection("Jwt");
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtConfig["Issuer"],
        ValidAudience = jwtConfig["Audience"],
        IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(jwtConfig["Key"]!)),
        ClockSkew = System.TimeSpan.Zero
    };
});
*/

// SignalR - معلق مؤقتاً للاختبار
// builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
// app.UseMiddleware<ErrorHandlingMiddleware>(); // معلق مؤقتاً
// app.UseMiddleware<LocalizationMiddleware>(); // معلق مؤقتاً
// app.UseMiddleware<JwtMiddleware>(); // سيتم تفعيله لاحقاً

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

// Map SignalR Hub - temporarily commented out to isolate path base issue
// app.MapHub<NotificationHub>("/hubs/notification");

app.MapControllers();

app.Run();
