using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Presentation.Hubs
{
    public class NotificationHub : Hub
    {
        // إرسال إشعار لمستخدم معين
        public async Task SendNotificationToUser(string userId, string message)
        {
            await Clients.User(userId).SendAsync("ReceiveNotification", message);
        }

        // إرسال إشعار لكل المستخدمين
        public async Task BroadcastNotification(string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", message);
        }
    }
} 