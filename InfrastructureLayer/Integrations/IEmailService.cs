namespace Infrastructure.Integrations
{
    public interface IEmailService
    {
        bool SendEmail(string to, string subject, string body);
    }
} 