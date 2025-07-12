namespace Infrastructure.Integrations
{
    public interface INotificationService
    {
        bool SendSystemNotification(int userId, string message);
        bool SendEmailNotification(string to, string subject, string body);
    }
} 