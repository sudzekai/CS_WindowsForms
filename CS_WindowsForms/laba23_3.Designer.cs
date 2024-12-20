using System;

namespace CS_WindowsForms
{
    partial class laba23_3
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
            this.TimeLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeLab
            // 
            this.TimeLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLab.AutoSize = true;
            this.TimeLab.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLab.ForeColor = System.Drawing.Color.Black;
            this.TimeLab.Location = new System.Drawing.Point(113, 179);
            this.TimeLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLab.Name = "TimeLab";
            this.TimeLab.Size = new System.Drawing.Size(205, 23);
            this.TimeLab.TabIndex = 3;
            this.TimeLab.Text = "20.12.2024 4:18:12";
            // 
            // laba23_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 211);
            this.Controls.Add(this.TimeLab);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MinimumSize = new System.Drawing.Size(347, 250);
            this.Name = "laba23_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "laba23_3";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.laba23_3_Load);
            this.Controls.SetChildIndex(this.TimeLab, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLab;
    }
}