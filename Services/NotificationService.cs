using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Notifications;

namespace WindowsDeviceManager.Services
{
    public class NotificationService
    {
        // Method to show an application notification
        public void ShowAppNotification(string title, string content)
        {
            var toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText02);
            var textNodes = toastXml.GetElementsByTagName("text");
            textNodes[0].AppendChild(toastXml.CreateTextNode(title));
            textNodes[1].AppendChild(toastXml.CreateTextNode(content));

            var toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

        // Method to show a system notification
        public void ShowSystemNotification(string message)
        {
            // Implementation for system notification, can vary based on the platform
            Console.WriteLine("System Notification: " + message);
        }

        // Method to manage notifications (like clear or dismiss)
        public void ClearNotification()
        {
            // Logic to clear notifications
            Console.WriteLine("Notifications cleared.");
        }
    }
}