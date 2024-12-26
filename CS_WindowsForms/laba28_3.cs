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
    public partial class laba28_3 : Form
    {
        private string[] Names = { "хлеб", "молоко", "кукуруза", "вода", "сметана", "мороженое", "сухарики хрустим со вкусом королевского краба", "энергетический напиток FLASH ENERGY 'KIWI Carambola'", "пельмени", "оптимус прайм" };

        public laba28_3()
        {
            InitializeComponent();
        }


        private void laba28_3_Load(object sender, EventArgs e)
        {
            label1.Text = "Итог:\n";
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add(i, Names[i], rand.Next(50, 250), false);
            }
        }

        private void AgreeBtn_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            label1.Text = "Итог:\n";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[3,i].Value != null && (bool)dataGridView1[3,i].Value == true)
                {
                    label1.Text += $"{dataGridView1[1, i].Value} {dataGridView1[2, i].Value}₽ \n";
                }
            }
            if (label1.Text == "Итог:\n")
            {
                MessageBox.Show("Ни одна позиция не выбрана", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
