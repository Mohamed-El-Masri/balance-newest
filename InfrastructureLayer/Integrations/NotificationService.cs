namespace Infrastructure.Integrations
{
    public class NotificationService : INotificationService
    {
        public NotificationService(/* inject config here */) { }
        public bool SendSystemNotification(int userId, string message) => true; // implement
        public bool SendEmailNotification(string to, string subject, string body) => true; // implement
    }
} 