using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CS_WindowsForms
{
    public partial class ColorChangeWindow : Form
    {
        public ColorChangeWindow()
        {
            InitializeComponent();
        }

        private void Green_TrackBar_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Red_TrackBar.Value, Green_TrackBar.Value, Blue_TrackBar.Value);
            label3.Text = $"{Green_TrackBar.Value}";
           
        }

        private void Blue_TrackBar_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Red_TrackBar.Value, Green_TrackBar.Value, Blue_TrackBar.Value);
            label2.Text = $"{Blue_TrackBar.Value}";
            
        }

        private void Red_TrackBar_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Red_TrackBar.Value, Green_TrackBar.Value, Blue_TrackBar.Value);
            label1.Text = $"{Red_TrackBar.Value}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
