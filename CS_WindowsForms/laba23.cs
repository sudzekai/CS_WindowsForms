using Microsoft.SqlServer.Server;
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
    public partial class laba23 : template
    {
        public laba23()
        {
            InitializeComponent();
        }

        private void laba23_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Приветствие", $"Добро пожаловать\n{DateTime.Now}");
        }

        private void laba23_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult mb = MessageBox.Show("Закрытие", "",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mb == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Task2btn_Click(object sender, EventArgs e)
        {
            laba23_2 form = new laba23_2();
            Navigate(this, form);
        }

        private void Task3btn_Click(object sender, EventArgs e)
        {
            laba23_3 form = new laba23_3();
            Navigate(this, form);
        }

        private void Task4btn_Click(object sender, EventArgs e)
        {
            Laba23_4 form = new Laba23_4();
            Navigate(this, form);
        }
    }
}
