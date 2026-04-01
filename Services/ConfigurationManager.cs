using System;
using Microsoft.Win32;
using System.IO;

namespace WindowsDeviceManager
{
    public class ConfigurationManager
    {
        private string configFilePath = "config.json";
        
        public void SaveConfiguration(object config)
        {
            // Save to registry
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\WindowsDeviceManager");
            if (key != null)
            {
                key.SetValue("Configuration", Newtonsoft.Json.JsonConvert.SerializeObject(config));
                key.Close();
            }
            
            // Save to file
            File.WriteAllText(configFilePath, Newtonsoft.Json.JsonConvert.SerializeObject(config));
        }
        
        public T LoadConfiguration<T>()
        {
            T config = default(T);
            
            // Load from registry
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\WindowsDeviceManager");
            if (key != null)
            {
                string configJson = key.GetValue("Configuration", "{}").ToString();
                config = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(configJson);
                key.Close();
            }
            
            // Load from file
            if (File.Exists(configFilePath))
            {
                string configJson = File.ReadAllText(configFilePath);
                config = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(configJson);
            }
            
            return config;
        }
    }
}