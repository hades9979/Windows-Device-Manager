using System.Windows.Forms;

namespace WindowsDeviceManager.UI
{
    public partial class CustomLogonPanel : UserControl
    {
        public CustomLogonPanel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CustomLogonPanel
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.Name = "CustomLogonPanel";
            this.Size = new System.Drawing.Size(400, 300);
            this.ResumeLayout(false);
        }
    }
}