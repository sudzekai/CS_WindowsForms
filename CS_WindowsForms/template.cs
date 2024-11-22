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
    public partial class template : Form
    {
        public template()
        {
            InitializeComponent();
        }
        public void Navigate(Form formfrom, Form formto)
        {
            formfrom.Hide();
            formto.ShowDialog();
            formfrom.Show();
        }
    }
}
