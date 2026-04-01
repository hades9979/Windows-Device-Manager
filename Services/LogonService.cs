using System;
using System.Diagnostics;

namespace WindowsDeviceManager.Services
{
    public class LogonService
    {
        // Method to enable the logon screen
        public void EnableLogonScreen()
        {
            // Code to enable the Windows logon screen configuration
            Process.Start(new ProcessStartInfo("cmd.exe", "/c reg add \\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI /v LogonBoxEnabled /t REG_DWORD /d 1 /f") { CreateNoWindow = true, UseShellExecute = false, RedirectStandardOutput = true });
        }

        // Method to disable the logon screen
        public void DisableLogonScreen()
        {
            // Code to disable the Windows logon screen configuration
            Process.Start(new ProcessStartInfo("cmd.exe", "/c reg add \\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI /v LogonBoxEnabled /t REG_DWORD /d 0 /f") { CreateNoWindow = true, UseShellExecute = false, RedirectStandardOutput = true });
        }

        // Method to set the logon screen background image
        public void SetLogonScreenBackground(string imagePath)
        {
            // Code to change the logon screen background image
            Process.Start(new ProcessStartInfo("cmd.exe", "/c reg add \\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI /v BackgroundImagePath /t REG_SZ /d " + imagePath + " /f") { CreateNoWindow = true, UseShellExecute = false, RedirectStandardOutput = true });
        }

        // Method to get the current logon screen configuration
        public string GetLogonScreenConfiguration()
        {
            // Code to get the current logon screen configuration
            return "Logon Screen Configuration Details"; // Placeholder for actual implementation
        }
    }
}