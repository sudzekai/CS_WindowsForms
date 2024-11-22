using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CS_WindowsForms
{
    public partial class laba27 : Form
    {
        public laba27()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length != 0)
            {
                MessageBox.Show($"Билет: Архангельск - {comboBox1.Text}", "Заказ",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"Выберите пункт назначения", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                string text = "";
                foreach (string i in checkedListBox1.CheckedItems)
                {
                    text += $"-{i}\n";
                }
                MessageBox.Show($"Вы записались на курсы:\n{text}", "Запись", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Вы не выбрали ни одного курса!", "Ошибка", MessageBoxButtons.OK);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Поле ввода пусто", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = string.Empty;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Text.Length != 0)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox1.Items.Remove(listBox1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach(string i in listBox1.Items)
            {
                listBox2.Items.Add((string)i);
            }
            listBox1.Items.Clear();
        }
    }
}
