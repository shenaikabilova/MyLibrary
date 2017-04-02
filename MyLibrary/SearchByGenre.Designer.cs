namespace MyLibrary
{
    partial class SearchByGenre
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
            this.bSearchGenre = new System.Windows.Forms.Button();
            this.bGenreExit = new System.Windows.Forms.Button();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Въведи жанр";
            // 
            // bSearchGenre
            // 
            this.bSearchGenre.Location = new System.Drawing.Point(58, 135);
            this.bSearchGenre.Name = "bSearchGenre";
            this.bSearchGenre.Size = new System.Drawing.Size(94, 33);
            this.bSearchGenre.TabIndex = 2;
            this.bSearchGenre.Text = "Търсене";
            this.bSearchGenre.UseVisualStyleBackColor = true;
            this.bSearchGenre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchByGenre_click);
            // 
            // bGenreExit
            // 
            this.bGenreExit.Location = new System.Drawing.Point(241, 135);
            this.bGenreExit.Name = "bGenreExit";
            this.bGenreExit.Size = new System.Drawing.Size(94, 33);
            this.bGenreExit.TabIndex = 3;
            this.bGenreExit.Text = "Изход";
            this.bGenreExit.UseVisualStyleBackColor = true;
            this.bGenreExit.Click += new System.EventHandler(this.bGenreExit_Click);
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(153, 47);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(246, 24);
            this.cbGenre.TabIndex = 4;
            // 
            // SearchByGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 238);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.bGenreExit);
            this.Controls.Add(this.bSearchGenre);
            this.Controls.Add(this.label1);
            this.Name = "SearchByGenre";
            this.Text = "Търсене по жанр";
            this.Load += new System.EventHandler(this.SearchByGenre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSearchGenre;
        private System.Windows.Forms.Button bGenreExit;
        private System.Windows.Forms.ComboBox cbGenre;
    }
}