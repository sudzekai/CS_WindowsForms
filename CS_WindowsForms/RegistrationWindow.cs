using System;
using System.Drawing;
using System.Windows.Forms;

namespace CS_WindowsForms
{
    public partial class RegistrationWindow : Form
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Country_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void DateOfBirth_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int age = date.Year - DateOfBirth_DateTimePicker.Value.Year;
            Age_Label.Text = $"Возраст: {age}";

        }

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            if (Login_TextBox.Text.Length == 0)
            {
                MessageBox.Show("Поле Логин не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Login_TextBox.BackColor = Color.Red;
            }
            else if (Login_TextBox.Text.IndexOf(" ") > -1)
            {
                MessageBox.Show("Поле Логин не может содержать пробелы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Login_TextBox.BackColor = Color.Red;
            }
            else if (Password_TextBox.Text != RepPassword_TextBox.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RepPassword_TextBox.BackColor = Color.Red;
            }
            else if (Password_TextBox.Text.Length == 0 || RepPassword_TextBox.Text.Length == 0)
            {
                MessageBox.Show("Поле Пароль не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password_TextBox.BackColor = Color.Red;

            }
            else if (Password_TextBox.Text.IndexOf(" ") > -1)
            {
                MessageBox.Show("Поле Пароль не может содержать пробелы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password_TextBox.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show($"{Login_TextBox.Text}, Вы успешно зарегистрировались!", "Регистрация", MessageBoxButtons.OK);
            }
        }

        private void Login_TextBox_TextChanged(object sender, EventArgs e)
        {
            Login_TextBox.BackColor = Color.White;
        }

        private void Password_TextBox_TextChanged(object sender, EventArgs e)
        {
            Password_TextBox.BackColor = Color.White;
        }

        private void RepPassword_TextBox_TextChanged(object sender, EventArgs e)
        {
            RepPassword_TextBox.BackColor = Color.White;
        }
    }
}
