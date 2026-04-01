using System;
using System.Windows.Forms;

namespace WindowsDeviceManager
{
    public class MainForm : Form
    {
        private TabControl tabControl;

        public MainForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.tabControl = new TabControl();
            this.tabControl.Dock = DockStyle.Fill;

            // Tab for Device Lockdown
            TabPage lockdownTab = new TabPage("Device Lockdown");
            // Add components for lockdown tab here if needed
            tabControl.TabPages.Add(lockdownTab);

            // Tab for Custom Logon
            TabPage logonTab = new TabPage("Custom Logon");
            // Add components for logon tab here if needed
            tabControl.TabPages.Add(logonTab);

            // Tab for Notifications
            TabPage notificationsTab = new TabPage("Notifications");
            // Add components for notifications tab here if needed
            tabControl.TabPages.Add(notificationsTab);

            this.Controls.Add(tabControl);
            this.Text = "Windows Device Manager";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(800, 600);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}