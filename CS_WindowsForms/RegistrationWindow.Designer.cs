using System.Windows.Forms.VisualStyles;

namespace CS_WindowsForms
{
    partial class RegistrationWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.RepPassword_Label = new System.Windows.Forms.Label();
            this.Email_Label = new System.Windows.Forms.Label();
            this.Country_Label = new System.Windows.Forms.Label();
            this.About_TextBox = new System.Windows.Forms.RichTextBox();
            this.About_Label = new System.Windows.Forms.Label();
            this.DateOfBirth_Label = new System.Windows.Forms.Label();
            this.DateOfBirth_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Age_Label = new System.Windows.Forms.Label();
            this.Registration_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Login_TextBox = new System.Windows.Forms.TextBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.RepPassword_TextBox = new System.Windows.Forms.TextBox();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.Country_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Font = new System.Drawing.Font("Verdana", 10F);
            this.Login_Label.Location = new System.Drawing.Point(12, 9);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(52, 17);
            this.Login_Label.TabIndex = 0;
            this.Login_Label.Text = "Логин";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Verdana", 10F);
            this.Password_Label.Location = new System.Drawing.Point(12, 53);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(61, 17);
            this.Password_Label.TabIndex = 8;
            this.Password_Label.Text = "Пароль";
            // 
            // RepPassword_Label
            // 
            this.RepPassword_Label.AutoSize = true;
            this.RepPassword_Label.Font = new System.Drawing.Font("Verdana", 10F);
            this.RepPassword_Label.Location = new System.Drawing.Point(12, 97);
            this.RepPassword_Label.Name = "RepPassword_Label";
            this.RepPassword_Label.Size = new System.Drawing.Size(179, 17);
            this.RepPassword_Label.TabIndex = 10;
            this.RepPassword_Label.Text = "Подтверждение пароля";
            // 
            // Email_Label
            // 
            this.Email_Label.AutoSize = true;
            this.Email_Label.Font = new System.Drawing.Font("Verdana", 10F);
            this.Email_Label.Location = new System.Drawing.Point(12, 141);
            this.Email_Label.Name = "Email_Label";
            this.Email_Label.Size = new System.Drawing.Size(148, 17);
            this.Email_Label.TabIndex = 12;
            this.Email_Label.Text = "Электронная почта";
            // 
            // Country_Label
            // 
            this.Country_Label.AutoSize = true;
            this.Country_Label.Font = new System.Drawing.Font("Verdana", 10F);
            this.Country_Label.Location = new System.Drawing.Point(12, 185);
            this.Country_Label.Name = "Country_Label";
            this.Country_Label.Size = new System.Drawing.Size(59, 17);
            this.Country_Label.TabIndex = 14;
            this.Country_Label.Text = "Страна";
            // 
            // About_TextBox
            // 
            this.About_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.About_TextBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.About_TextBox.Location = new System.Drawing.Point(9, 249);
            this.About_TextBox.MaxLength = 300;
            this.About_TextBox.Name = "About_TextBox";
            this.About_TextBox.Size = new System.Drawing.Size(463, 93);
            this.About_TextBox.TabIndex = 17;
            this.About_TextBox.Text = "";
            // 
            // About_Label
            // 
            this.About_Label.AutoSize = true;
            this.About_Label.Font = new System.Drawing.Font("Verdana", 10F);
            this.About_Label.Location = new System.Drawing.Point(12, 229);
            this.About_Label.Name = "About_Label";
            this.About_Label.Size = new System.Drawing.Size(57, 17);
            this.About_Label.TabIndex = 16;
            this.About_Label.Text = "О себе";
            // 
            // DateOfBirth_Label
            // 
            this.DateOfBirth_Label.AutoSize = true;
            this.DateOfBirth_Label.Font = new System.Drawing.Font("Verdana", 10F);
            this.DateOfBirth_Label.Location = new System.Drawing.Point(12, 345);
            this.DateOfBirth_Label.Name = "DateOfBirth_Label";
            this.DateOfBirth_Label.Size = new System.Drawing.Size(111, 17);
            this.DateOfBirth_Label.TabIndex = 18;
            this.DateOfBirth_Label.Text = "Год рождения";
            // 
            // DateOfBirth_DateTimePicker
            // 
            this.DateOfBirth_DateTimePicker.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirth_DateTimePicker.Location = new System.Drawing.Point(9, 365);
            this.DateOfBirth_DateTimePicker.Name = "DateOfBirth_DateTimePicker";
            this.DateOfBirth_DateTimePicker.Size = new System.Drawing.Size(170, 23);
            this.DateOfBirth_DateTimePicker.TabIndex = 19;
            this.DateOfBirth_DateTimePicker.Value = new System.DateTime(2024, 11, 22, 0, 0, 0, 0);
            this.DateOfBirth_DateTimePicker.ValueChanged += new System.EventHandler(this.DateOfBirth_DateTimePicker_ValueChanged);
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Font = new System.Drawing.Font("Verdana", 10F);
            this.Age_Label.Location = new System.Drawing.Point(185, 370);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(86, 17);
            this.Age_Label.TabIndex = 20;
            this.Age_Label.Text = "Возраст: 0";
            // 
            // Registration_Button
            // 
            this.Registration_Button.Location = new System.Drawing.Point(9, 526);
            this.Registration_Button.Name = "Registration_Button";
            this.Registration_Button.Size = new System.Drawing.Size(165, 23);
            this.Registration_Button.TabIndex = 21;
            this.Registration_Button.Text = "Зарегистрироваться";
            this.Registration_Button.UseVisualStyleBackColor = true;
            this.Registration_Button.Click += new System.EventHandler(this.Registration_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(378, 526);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(94, 23);
            this.Cancel_Button.TabIndex = 22;
            this.Cancel_Button.Text = "Отмена";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Login_TextBox
            // 
            this.Login_TextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_TextBox.Location = new System.Drawing.Point(9, 29);
            this.Login_TextBox.MaxLength = 24;
            this.Login_TextBox.Name = "Login_TextBox";
            this.Login_TextBox.Size = new System.Drawing.Size(463, 21);
            this.Login_TextBox.TabIndex = 24;
            this.Login_TextBox.TextChanged += new System.EventHandler(this.Login_TextBox_TextChanged);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_TextBox.Location = new System.Drawing.Point(9, 73);
            this.Password_TextBox.MaxLength = 24;
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(463, 21);
            this.Password_TextBox.TabIndex = 28;
            this.Password_TextBox.UseSystemPasswordChar = true;
            this.Password_TextBox.TextChanged += new System.EventHandler(this.Password_TextBox_TextChanged);
            // 
            // RepPassword_TextBox
            // 
            this.RepPassword_TextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepPassword_TextBox.Location = new System.Drawing.Point(9, 117);
            this.RepPassword_TextBox.MaxLength = 24;
            this.RepPassword_TextBox.Name = "RepPassword_TextBox";
            this.RepPassword_TextBox.Size = new System.Drawing.Size(463, 21);
            this.RepPassword_TextBox.TabIndex = 29;
            this.RepPassword_TextBox.UseSystemPasswordChar = true;
            this.RepPassword_TextBox.TextChanged += new System.EventHandler(this.RepPassword_TextBox_TextChanged);
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email_TextBox.Location = new System.Drawing.Point(9, 161);
            this.Email_TextBox.MaxLength = 24;
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(463, 21);
            this.Email_TextBox.TabIndex = 30;
            // 
            // Country_TextBox
            // 
            this.Country_TextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Country_TextBox.Location = new System.Drawing.Point(9, 205);
            this.Country_TextBox.MaxLength = 20;
            this.Country_TextBox.Name = "Country_TextBox";
            this.Country_TextBox.Size = new System.Drawing.Size(463, 21);
            this.Country_TextBox.TabIndex = 31;
            this.Country_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Country_TextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.Location = new System.Drawing.Point(12, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Пол";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 411);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(34, 17);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "М";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(49, 411);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(36, 17);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ж";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Country_TextBox);
            this.Controls.Add(this.Email_TextBox);
            this.Controls.Add(this.RepPassword_TextBox);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Login_TextBox);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Registration_Button);
            this.Controls.Add(this.Age_Label);
            this.Controls.Add(this.DateOfBirth_DateTimePicker);
            this.Controls.Add(this.DateOfBirth_Label);
            this.Controls.Add(this.About_TextBox);
            this.Controls.Add(this.About_Label);
            this.Controls.Add(this.Country_Label);
            this.Controls.Add(this.Email_Label);
            this.Controls.Add(this.RepPassword_Label);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Login_Label);
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "RegistrationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label RepPassword_Label;
        private System.Windows.Forms.Label Email_Label;
        private System.Windows.Forms.Label Country_Label;
        private System.Windows.Forms.RichTextBox About_TextBox;
        private System.Windows.Forms.Label About_Label;
        private System.Windows.Forms.Label DateOfBirth_Label;
        private System.Windows.Forms.DateTimePicker DateOfBirth_DateTimePicker;
        private System.Windows.Forms.Label Age_Label;
        private System.Windows.Forms.Button Registration_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.TextBox Login_TextBox;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.TextBox RepPassword_TextBox;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.TextBox Country_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}