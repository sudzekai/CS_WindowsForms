namespace CS_WindowsForms
{
    partial class ColorChangeWindow
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
            this.Red_TrackBar = new System.Windows.Forms.TrackBar();
            this.Blue_TrackBar = new System.Windows.Forms.TrackBar();
            this.Green_TrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Red_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green_TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Red_TrackBar
            // 
            this.Red_TrackBar.Location = new System.Drawing.Point(12, 12);
            this.Red_TrackBar.Maximum = 255;
            this.Red_TrackBar.Name = "Red_TrackBar";
            this.Red_TrackBar.Size = new System.Drawing.Size(688, 45);
            this.Red_TrackBar.TabIndex = 1;
            this.Red_TrackBar.TickFrequency = 25;
            this.Red_TrackBar.Scroll += new System.EventHandler(this.Red_TrackBar_Scroll);
            // 
            // Blue_TrackBar
            // 
            this.Blue_TrackBar.Location = new System.Drawing.Point(12, 63);
            this.Blue_TrackBar.Maximum = 255;
            this.Blue_TrackBar.Name = "Blue_TrackBar";
            this.Blue_TrackBar.Size = new System.Drawing.Size(688, 45);
            this.Blue_TrackBar.TabIndex = 2;
            this.Blue_TrackBar.TickFrequency = 25;
            this.Blue_TrackBar.Scroll += new System.EventHandler(this.Blue_TrackBar_Scroll);
            // 
            // Green_TrackBar
            // 
            this.Green_TrackBar.Location = new System.Drawing.Point(12, 114);
            this.Green_TrackBar.Maximum = 255;
            this.Green_TrackBar.Name = "Green_TrackBar";
            this.Green_TrackBar.Size = new System.Drawing.Size(688, 45);
            this.Green_TrackBar.TabIndex = 3;
            this.Green_TrackBar.TickFrequency = 25;
            this.Green_TrackBar.Scroll += new System.EventHandler(this.Green_TrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(706, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(706, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(706, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColorChangeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Green_TrackBar);
            this.Controls.Add(this.Blue_TrackBar);
            this.Controls.Add(this.Red_TrackBar);
            this.MaximumSize = new System.Drawing.Size(800, 300);
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "ColorChangeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Смена цвета";
            ((System.ComponentModel.ISupportInitialize)(this.Red_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green_TrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Red_TrackBar;
        private System.Windows.Forms.TrackBar Blue_TrackBar;
        private System.Windows.Forms.TrackBar Green_TrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}