namespace Infrastructure.Integrations
{
    public class EmailService : IEmailService
    {
        public EmailService(/* inject config here */) { }
        public bool SendEmail(string to, string subject, string body) => true; // implement
    }
} 