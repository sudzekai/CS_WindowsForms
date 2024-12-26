using System.Drawing;
using System.Windows.Forms;

namespace CS_WindowsForms
{
    partial class laba28
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.Task2Btn = new System.Windows.Forms.Button();
            this.Task3Btn = new System.Windows.Forms.Button();
=======
>>>>>>> 25ca522a66923695677b882e91011da938a9e1ac
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
<<<<<<< HEAD
=======
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> 25ca522a66923695677b882e91011da938a9e1ac
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
<<<<<<< HEAD
            this.dataGridView1.Size = new System.Drawing.Size(520, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // Task2Btn
            // 
            this.Task2Btn.Location = new System.Drawing.Point(12, 337);
            this.Task2Btn.Name = "Task2Btn";
            this.Task2Btn.Size = new System.Drawing.Size(75, 23);
            this.Task2Btn.TabIndex = 1;
            this.Task2Btn.Text = "2";
            this.Task2Btn.UseVisualStyleBackColor = true;
            this.Task2Btn.Click += new System.EventHandler(this.Task2Btn_Click);
            // 
            // Task3Btn
            // 
            this.Task3Btn.Location = new System.Drawing.Point(93, 337);
            this.Task3Btn.Name = "Task3Btn";
            this.Task3Btn.Size = new System.Drawing.Size(75, 23);
            this.Task3Btn.TabIndex = 2;
            this.Task3Btn.Text = "3";
            this.Task3Btn.UseVisualStyleBackColor = true;
            this.Task3Btn.Click += new System.EventHandler(this.Task3Btn_Click);
            // 
=======

            this.dataGridView1.Size = new System.Drawing.Size(776, 241);
            this.dataGridView1.TabIndex = 0;
            // 
>>>>>>> 25ca522a66923695677b882e91011da938a9e1ac
            // laba28
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(633, 378);
            this.Controls.Add(this.Task3Btn);
            this.Controls.Add(this.Task2Btn);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(0, 0);
=======
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
>>>>>>> 25ca522a66923695677b882e91011da938a9e1ac
            this.Name = "laba28";
            this.Text = "laba28";
            this.Load += new System.EventHandler(this.laba28_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
<<<<<<< HEAD
        private Button Task2Btn;
        private Button Task3Btn;
=======
>>>>>>> 25ca522a66923695677b882e91011da938a9e1ac
    }
}