using System;  
using System.Windows;  
using System.Windows.Controls;  

namespace Windows_Device_Manager.UI  
{  
    public partial class NotificationPanel : UserControl  
    {  
        public NotificationPanel()  
        {  
            InitializeComponent();  
        }  

        public void ShowNotification(string message)  
        {  
            // Logic to display notification  
            MessageBox.Show(message, "Notification", MessageBoxButton.OK, MessageBoxImage.Information);  
        }  
    }  
}  

<!-- Add corresponding XAML code in separate file -->  
<!--<UserControl x:Class="Windows_Device_Manager.UI.NotificationPanel"  
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"  
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"  
    Width="300" Height="100">  
    <Grid>  
        <TextBlock Text="Notifications" FontSize="20" Margin="10"/>  
        <Button Content="Clear Notifications" Width="120" Height="30" HorizontalAlignment="Right" VerticalAlignment="Bottom" Click="ClearNotifications_Click"/>  
    </Grid>  
</UserControl>-->  
