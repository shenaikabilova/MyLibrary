namespace MyLibrary
{
    partial class GenreView
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
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.bGenreExit = new System.Windows.Forms.Button();
            this.bBookAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Жанр";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(98, 30);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(147, 22);
            this.tbGenre.TabIndex = 1;
            // 
            // bGenreExit
            // 
            this.bGenreExit.Location = new System.Drawing.Point(134, 106);
            this.bGenreExit.Name = "bGenreExit";
            this.bGenreExit.Size = new System.Drawing.Size(81, 32);
            this.bGenreExit.TabIndex = 3;
            this.bGenreExit.Text = "Изход";
            this.bGenreExit.UseVisualStyleBackColor = true;
            this.bGenreExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exit_click);
            // 
            // bBookAdd
            // 
            this.bBookAdd.Location = new System.Drawing.Point(16, 106);
            this.bBookAdd.Name = "bBookAdd";
            this.bBookAdd.Size = new System.Drawing.Size(75, 31);
            this.bBookAdd.TabIndex = 4;
            this.bBookAdd.Text = "Add";
            this.bBookAdd.UseVisualStyleBackColor = true;
            this.bBookAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bGenreAdd);
            // 
            // GenreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 255);
            this.Controls.Add(this.bBookAdd);
            this.Controls.Add(this.bGenreExit);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.label1);
            this.Name = "GenreView";
            this.Text = "Добави жанр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Button bGenreExit;
        private System.Windows.Forms.Button bBookAdd;
    }
}