namespace MyLibrary
{
    partial class SearchByAuthor
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
            this.bSearchByAuthor = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Въведи име на автор";
            // 
            // bSearchByAuthor
            // 
            this.bSearchByAuthor.Location = new System.Drawing.Point(123, 99);
            this.bSearchByAuthor.Name = "bSearchByAuthor";
            this.bSearchByAuthor.Size = new System.Drawing.Size(88, 41);
            this.bSearchByAuthor.TabIndex = 2;
            this.bSearchByAuthor.Text = "Търсене";
            this.bSearchByAuthor.UseVisualStyleBackColor = true;
            this.bSearchByAuthor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchByAuthor_click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(288, 99);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(80, 41);
            this.bExit.TabIndex = 3;
            this.bExit.Text = "Изход";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(167, 55);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(282, 24);
            this.cbAuthor.TabIndex = 4;
            // 
            // SearchByAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 165);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bSearchByAuthor);
            this.Controls.Add(this.label1);
            this.Name = "SearchByAuthor";
            this.Text = "Търсене по автор";
            this.Load += new System.EventHandler(this.SearchByAuthor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSearchByAuthor;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.ComboBox cbAuthor;
    }
}