namespace CS_WindowsForms
{
    partial class MainWindow_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogIn_Button = new System.Windows.Forms.Button();
            this.Register_Button = new System.Windows.Forms.Button();
            this.ColorChange_Button = new System.Windows.Forms.Button();
            this.Labs_Button = new System.Windows.Forms.Button();
            this.ADS_Link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LogIn_Button
            // 
            this.LogIn_Button.Location = new System.Drawing.Point(12, 12);
            this.LogIn_Button.Name = "LogIn_Button";
            this.LogIn_Button.Size = new System.Drawing.Size(100, 25);
            this.LogIn_Button.TabIndex = 0;
            this.LogIn_Button.Text = "Войти";
            this.LogIn_Button.UseVisualStyleBackColor = true;
            this.LogIn_Button.Click += new System.EventHandler(this.LogIn_Button_Click);
            // 
            // Register_Button
            // 
            this.Register_Button.Location = new System.Drawing.Point(12, 43);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(100, 25);
            this.Register_Button.TabIndex = 1;
            this.Register_Button.Text = "Регистрация";
            this.Register_Button.UseVisualStyleBackColor = true;
            this.Register_Button.Click += new System.EventHandler(this.Register_Button_Click);
            // 
            // ColorChange_Button
            // 
            this.ColorChange_Button.Location = new System.Drawing.Point(12, 74);
            this.ColorChange_Button.Name = "ColorChange_Button";
            this.ColorChange_Button.Size = new System.Drawing.Size(100, 25);
            this.ColorChange_Button.TabIndex = 2;
            this.ColorChange_Button.Text = "Смена цвета";
            this.ColorChange_Button.UseVisualStyleBackColor = true;
            this.ColorChange_Button.Click += new System.EventHandler(this.ColorChange_Button_Click);
            // 
            // Labs_Button
            // 
            this.Labs_Button.Location = new System.Drawing.Point(12, 105);
            this.Labs_Button.Name = "Labs_Button";
            this.Labs_Button.Size = new System.Drawing.Size(100, 25);
            this.Labs_Button.TabIndex = 3;
            this.Labs_Button.Text = "Лабы";
            this.Labs_Button.UseVisualStyleBackColor = true;
            this.Labs_Button.Click += new System.EventHandler(this.Labs_Button_Click);
            // 
            // ADS_Link
            // 
            this.ADS_Link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ADS_Link.AutoSize = true;
            this.ADS_Link.Location = new System.Drawing.Point(192, 80);
            this.ADS_Link.Name = "ADS_Link";
            this.ADS_Link.Size = new System.Drawing.Size(162, 13);
            this.ADS_Link.TabIndex = 4;
            this.ADS_Link.TabStop = true;
            this.ADS_Link.Text = "Тут могла быть ваша реклама";
            // 
            // MainWindow_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.ADS_Link);
            this.Controls.Add(this.Labs_Button);
            this.Controls.Add(this.ColorChange_Button);
            this.Controls.Add(this.Register_Button);
            this.Controls.Add(this.LogIn_Button);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "MainWindow_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogIn_Button;
        private System.Windows.Forms.Button Register_Button;
        private System.Windows.Forms.Button ColorChange_Button;
        private System.Windows.Forms.Button Labs_Button;
        private System.Windows.Forms.LinkLabel ADS_Link;
    }
}

