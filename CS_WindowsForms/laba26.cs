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
    public partial class laba26 : Form
    {
        public laba26()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0 || textBox3.Text.Length == 0)
            {
                label7.Text = $"Результат: 0";
            }

            else if (radioButton1.Checked)
            {
                label7.Text = $"Результат: {Double.Parse(textBox2.Text) + Double.Parse(textBox3.Text)}";
            }
            else if (radioButton2.Checked)
            {
                label7.Text = $"Результат: {Double.Parse(textBox2.Text) * Double.Parse(textBox3.Text)}";

            }
            else if (radioButton3.Checked)
            {
                label7.Text = $"Результат: {Double.Parse(textBox2.Text) - Double.Parse(textBox3.Text)}";

            }
            else if (radioButton4.Checked)
            {
                if (Double.Parse(textBox3.Text) == 0)
                {
                    label7.Text = $"Результат: Дел 0";
                }
                else
                {
                    label7.Text = $"Результат: {Double.Parse(textBox2.Text) / Double.Parse(textBox3.Text)}";
                }
                

            }
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) && e.KeyChar != ',' || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) && e.KeyChar != ',' || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label10.Enabled=true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                label10.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                MessageBox.Show($"Билет: {dateTimePicker1.Value.Day}.{dateTimePicker1.Value.Month}.{dateTimePicker1.Value.Year} {textBox4.Text}-{textBox5.Text}\nОбратный билет: {dateTimePicker2.Value.Day}.{dateTimePicker2.Value.Month}.{dateTimePicker2.Value.Year} {textBox5.Text}-{textBox4.Text}", "Заказ", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"Билет: {dateTimePicker1.Value.Day}.{dateTimePicker1.Value.Month}.{dateTimePicker1.Value.Year} {textBox4.Text}-{textBox5.Text}", "Заказ", MessageBoxButtons.OK);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
