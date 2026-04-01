using System;

namespace WindowsDeviceManager.Models
{
    public class LogonConfig
    {
        public bool ShowWelcomeScreen { get; set; }
        public bool ShowPowerButton { get; set; }
        public bool ShowLanguageButton { get; set; }
        public bool ShowEaseOfAccessButton { get; set; }
        public bool ShowSwitchUserButton { get; set; }
        public string BootSettings { get; set; }
    }
}