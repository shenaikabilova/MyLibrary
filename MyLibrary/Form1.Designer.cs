namespace MyLibrary
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жанрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.търсенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поАвторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЖанрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмеНаКнигаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всичкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавиToolStripMenuItem,
            this.търсенеToolStripMenuItem,
            this.изходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавиToolStripMenuItem
            // 
            this.добавиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторToolStripMenuItem,
            this.жанрToolStripMenuItem,
            this.книгаToolStripMenuItem});
            this.добавиToolStripMenuItem.Name = "добавиToolStripMenuItem";
            this.добавиToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.добавиToolStripMenuItem.Text = "Добави";
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.авторToolStripMenuItem.Text = "Автор";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // жанрToolStripMenuItem
            // 
            this.жанрToolStripMenuItem.Name = "жанрToolStripMenuItem";
            this.жанрToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.жанрToolStripMenuItem.Text = "Жанр";
            this.жанрToolStripMenuItem.Click += new System.EventHandler(this.жанрToolStripMenuItem_Click);
            // 
            // книгаToolStripMenuItem
            // 
            this.книгаToolStripMenuItem.Name = "книгаToolStripMenuItem";
            this.книгаToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.книгаToolStripMenuItem.Text = "Книга";
            this.книгаToolStripMenuItem.Click += new System.EventHandler(this.книгаToolStripMenuItem_Click);
            // 
            // търсенеToolStripMenuItem
            // 
            this.търсенеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поАвторToolStripMenuItem,
            this.поЖанрToolStripMenuItem,
            this.поИмеНаКнигаToolStripMenuItem,
            this.всичкиToolStripMenuItem});
            this.търсенеToolStripMenuItem.Name = "търсенеToolStripMenuItem";
            this.търсенеToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.търсенеToolStripMenuItem.Text = "Търсене";
            // 
            // поАвторToolStripMenuItem
            // 
            this.поАвторToolStripMenuItem.Name = "поАвторToolStripMenuItem";
            this.поАвторToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.поАвторToolStripMenuItem.Text = "По автор";
            this.поАвторToolStripMenuItem.Click += new System.EventHandler(this.поАвторToolStripMenuItem_Click);
            // 
            // поЖанрToolStripMenuItem
            // 
            this.поЖанрToolStripMenuItem.Name = "поЖанрToolStripMenuItem";
            this.поЖанрToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.поЖанрToolStripMenuItem.Text = "По жанр ";
            // 
            // поИмеНаКнигаToolStripMenuItem
            // 
            this.поИмеНаКнигаToolStripMenuItem.Name = "поИмеНаКнигаToolStripMenuItem";
            this.поИмеНаКнигаToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.поИмеНаКнигаToolStripMenuItem.Text = "По име на книга";
            // 
            // всичкиToolStripMenuItem
            // 
            this.всичкиToolStripMenuItem.Name = "всичкиToolStripMenuItem";
            this.всичкиToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.всичкиToolStripMenuItem.Text = "Всички ";
            this.всичкиToolStripMenuItem.Click += new System.EventHandler(this.всичкиToolStripMenuItem_Click);
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.изходToolStripMenuItem.Text = "Изход";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 233);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Моята Библиотека";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem търсенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жанрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поАвторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИмеНаКнигаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЖанрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всичкиToolStripMenuItem;
    }
}

