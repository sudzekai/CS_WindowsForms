namespace CS_WindowsForms
{
    partial class laba30
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTextBox = new System.Windows.Forms.RichTextBox();
            this.Openfile = new System.Windows.Forms.OpenFileDialog();
            this.Savefile = new System.Windows.Forms.SaveFileDialog();
            this.NightTheme = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(384, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCreate,
            this.MenuOpen,
            this.MenuSave,
            this.MenuClose});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "Файл";
            // 
            // MenuCreate
            // 
            this.MenuCreate.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.MenuCreate.Name = "MenuCreate";
            this.MenuCreate.Size = new System.Drawing.Size(133, 22);
            this.MenuCreate.Text = "Создать";
            this.MenuCreate.Click += new System.EventHandler(this.MenuCreate_Click);
            // 
            // MenuOpen
            // 
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(133, 22);
            this.MenuOpen.Text = "Открыть";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // MenuSave
            // 
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Size = new System.Drawing.Size(133, 22);
            this.MenuSave.Text = "Сохранить";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // MenuClose
            // 
            this.MenuClose.Name = "MenuClose";
            this.MenuClose.Size = new System.Drawing.Size(133, 22);
            this.MenuClose.Text = "Закрыть";
            this.MenuClose.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // MainTextBox
            // 
            this.MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTextBox.BackColor = System.Drawing.Color.White;
            this.MainTextBox.Location = new System.Drawing.Point(0, 27);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(384, 185);
            this.MainTextBox.TabIndex = 1;
            this.MainTextBox.Text = "";
            // 
            // Openfile
            // 
            this.Openfile.Filter = "Текстовый документ (*.txt)|*.txt|Текстовый документ с форматированием (*.rtf)|*.r" +
    "tf|Все файлы (*.*)|*.*";
            // 
            // Savefile
            // 
            this.Savefile.Filter = "Текстовый документ (*.txt)|*.txt|Текстовый документ с форматированием (*.rtf)|*.r" +
    "tf|Все файлы (*.*)|*.*";
            // 
            // NightTheme
            // 
            this.NightTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NightTheme.AutoSize = true;
            this.NightTheme.Location = new System.Drawing.Point(285, 4);
            this.NightTheme.Name = "NightTheme";
            this.NightTheme.Size = new System.Drawing.Size(93, 17);
            this.NightTheme.TabIndex = 2;
            this.NightTheme.Text = "Темная тема";
            this.NightTheme.UseVisualStyleBackColor = true;
            this.NightTheme.CheckedChanged += new System.EventHandler(this.NightTheme_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(236, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "5.3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // laba30
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NightTheme);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.Name = "laba30";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Лабораторная работа 30";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuCreate;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuClose;
        private System.Windows.Forms.RichTextBox MainTextBox;
        private System.Windows.Forms.OpenFileDialog Openfile;
        private System.Windows.Forms.SaveFileDialog Savefile;
        private System.Windows.Forms.CheckBox NightTheme;
        private System.Windows.Forms.Button button1;
    }
}