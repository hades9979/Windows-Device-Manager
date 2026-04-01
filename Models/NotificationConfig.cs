namespace WindowsDeviceManager.Models
{
    public class NotificationConfig
    {
        public bool EnableToastNotifications { get; set; }
        public bool EnableWindowsUpdateNotifications { get; set; }
        public string ToastNotificationSound { get; set; }
        public string WindowsUpdateFrequency { get; set; }
        public string CustomNotificationMessage { get; set; }
    }
}