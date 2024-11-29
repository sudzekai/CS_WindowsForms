using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Schema;

namespace CS_WindowsForms
{
    public partial class laba30 : template
    {
        public laba30()
        {
            InitializeComponent();
        }

        private void MenuCreate_Click(object sender, EventArgs e)
        {
            this.Text = "Безымянный";
            MainTextBox.Text = String.Empty;
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            Openfile.ShowDialog();
            string ext = Path.GetExtension(Openfile.FileName);
            if (ext == ".rtf")
            {
                MainTextBox.LoadFile(Openfile.FileName);
            }
            else
            {

                MainTextBox.Text = File.ReadAllText(Openfile.FileName);
            }
            this.Text = $"{Openfile.SafeFileName}";
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            Savefile.ShowDialog();
            string ext = Path.GetExtension(Savefile.FileName);
            if (ext == ".rtf")
            {
                MainTextBox.SaveFile(Savefile.FileName);

            }
            else
            {
                File.WriteAllText(Savefile.FileName, MainTextBox.Text);
            }
            this.Text = string.Empty;
            MainTextBox.Text = String.Empty;

        }

        private void MenuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NightTheme_CheckedChanged(object sender, EventArgs e)
        {
            var converter = new ColorConverter();
            if (NightTheme.Checked == true)
            {
                MainTextBox.BackColor = (Color)converter.ConvertFrom("#1e1e1e");
                MainTextBox.ForeColor = Color.White;
                this.BackColor = (Color)converter.ConvertFrom("#1e1e1e");
                Menu.BackColor = (Color)converter.ConvertFrom("#1e1e1e");
                Menu.ForeColor = Color.White;
                NightTheme.ForeColor = Color.White;
                button1.BackColor = (Color)converter.ConvertFrom("#1e1e1e");
                button1.ForeColor = Color.White;
            }
            else
            {
                MainTextBox.BackColor = Color.White;
                MainTextBox.ForeColor = Color.Black;
                this.BackColor = Color.White;
                Menu.BackColor = Color.White;
                Menu.ForeColor = Color.Black;
                NightTheme.ForeColor = Color.Black;
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Navigate(this, form);
        }
    }
}
