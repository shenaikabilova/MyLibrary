namespace MyLibrary
{
    partial class BookView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.cbBookAuthor = new System.Windows.Forms.ComboBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.bBookExit = new System.Windows.Forms.Button();
            this.lTimeRead = new System.Windows.Forms.Label();
            this.tbTimeRead = new System.Windows.Forms.TextBox();
            this.bBookAdd = new System.Windows.Forms.Button();
            this.tbBookYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Година на издаване";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Автор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Жанр";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(164, 44);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(257, 22);
            this.tbBookName.TabIndex = 4;
            // 
            // cbBookAuthor
            // 
            this.cbBookAuthor.FormattingEnabled = true;
            this.cbBookAuthor.Location = new System.Drawing.Point(164, 115);
            this.cbBookAuthor.Name = "cbBookAuthor";
            this.cbBookAuthor.Size = new System.Drawing.Size(177, 24);
            this.cbBookAuthor.TabIndex = 6;
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(164, 153);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(177, 24);
            this.cbGenre.TabIndex = 7;
            // 
            // bBookExit
            // 
            this.bBookExit.Location = new System.Drawing.Point(122, 236);
            this.bBookExit.Name = "bBookExit";
            this.bBookExit.Size = new System.Drawing.Size(73, 29);
            this.bBookExit.TabIndex = 10;
            this.bBookExit.Text = "Изход";
            this.bBookExit.UseVisualStyleBackColor = true;
            this.bBookExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bookExit_click);
            // 
            // lTimeRead
            // 
            this.lTimeRead.AutoSize = true;
            this.lTimeRead.Location = new System.Drawing.Point(16, 195);
            this.lTimeRead.Name = "lTimeRead";
            this.lTimeRead.Size = new System.Drawing.Size(100, 17);
            this.lTimeRead.TabIndex = 11;
            this.lTimeRead.Text = "Брой четения";
            // 
            // tbTimeRead
            // 
            this.tbTimeRead.Location = new System.Drawing.Point(164, 195);
            this.tbTimeRead.Name = "tbTimeRead";
            this.tbTimeRead.Size = new System.Drawing.Size(59, 22);
            this.tbTimeRead.TabIndex = 12;
            // 
            // bBookAdd
            // 
            this.bBookAdd.Location = new System.Drawing.Point(16, 236);
            this.bBookAdd.Name = "bBookAdd";
            this.bBookAdd.Size = new System.Drawing.Size(80, 29);
            this.bBookAdd.TabIndex = 13;
            this.bBookAdd.Text = "Add";
            this.bBookAdd.UseVisualStyleBackColor = true;
            this.bBookAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bookAdd_click);
            // 
            // tbBookYear
            // 
            this.tbBookYear.Location = new System.Drawing.Point(162, 79);
            this.tbBookYear.Name = "tbBookYear";
            this.tbBookYear.Size = new System.Drawing.Size(61, 22);
            this.tbBookYear.TabIndex = 14;
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 305);
            this.Controls.Add(this.tbBookYear);
            this.Controls.Add(this.bBookAdd);
            this.Controls.Add(this.tbTimeRead);
            this.Controls.Add(this.lTimeRead);
            this.Controls.Add(this.bBookExit);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.cbBookAuthor);
            this.Controls.Add(this.tbBookName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookView";
            this.Text = "Добави книга";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.ComboBox cbBookAuthor;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Button bBookExit;
        private System.Windows.Forms.Label lTimeRead;
        private System.Windows.Forms.TextBox tbTimeRead;
        private System.Windows.Forms.Button bBookAdd;
        private System.Windows.Forms.TextBox tbBookYear;
    }
}