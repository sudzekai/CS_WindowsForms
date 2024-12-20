namespace CS_WindowsForms
{
    partial class laba23
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
            this.Task2btn = new System.Windows.Forms.Button();
            this.Task4btn = new System.Windows.Forms.Button();
            this.Task3btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task2btn
            // 
            this.Task2btn.Location = new System.Drawing.Point(80, 12);
            this.Task2btn.Name = "Task2btn";
            this.Task2btn.Size = new System.Drawing.Size(75, 23);
            this.Task2btn.TabIndex = 0;
            this.Task2btn.Text = "Задание 2";
            this.Task2btn.UseVisualStyleBackColor = true;
            this.Task2btn.Click += new System.EventHandler(this.Task2btn_Click);
            // 
            // Task4btn
            // 
            this.Task4btn.Location = new System.Drawing.Point(80, 70);
            this.Task4btn.Name = "Task4btn";
            this.Task4btn.Size = new System.Drawing.Size(75, 23);
            this.Task4btn.TabIndex = 1;
            this.Task4btn.Text = "Задание 4";
            this.Task4btn.UseVisualStyleBackColor = true;
            this.Task4btn.Click += new System.EventHandler(this.Task4btn_Click);
            // 
            // Task3btn
            // 
            this.Task3btn.Location = new System.Drawing.Point(80, 41);
            this.Task3btn.Name = "Task3btn";
            this.Task3btn.Size = new System.Drawing.Size(75, 23);
            this.Task3btn.TabIndex = 2;
            this.Task3btn.Text = "Задание 3";
            this.Task3btn.UseVisualStyleBackColor = true;
            this.Task3btn.Click += new System.EventHandler(this.Task3btn_Click);
            // 
            // laba23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.Task3btn);
            this.Controls.Add(this.Task4btn);
            this.Controls.Add(this.Task2btn);
            this.Name = "laba23";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.laba23_FormClosing);
            this.Load += new System.EventHandler(this.laba23_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Task2btn;
        private System.Windows.Forms.Button Task4btn;
        private System.Windows.Forms.Button Task3btn;
    }
}