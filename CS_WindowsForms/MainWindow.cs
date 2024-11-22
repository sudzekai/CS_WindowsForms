using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_WindowsForms
{
    public partial class MainWindow_Form : template
    {
        public MainWindow_Form()
        {
            InitializeComponent();
        }

        private void LogIn_Button_Click(object sender, EventArgs e)
        {
            LogInWindow form = new LogInWindow();
            Navigate(this, form);
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            RegistrationWindow form = new RegistrationWindow();
            Navigate(this, form);
        }

        private void ColorChange_Button_Click(object sender, EventArgs e)
        {
            ColorChangeWindow form = new ColorChangeWindow();
            Navigate(this, form);
        }

        private void Labs_Button_Click(object sender, EventArgs e)
        {
            LabsWindow form = new LabsWindow();
            Navigate(this, form);
        }
    }
}
