namespace MyLibrary
{
    partial class AuthorView
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
            this.lAuthorName = new System.Windows.Forms.Label();
            this.lAuthorFamily = new System.Windows.Forms.Label();
            this.tbAuthorName = new System.Windows.Forms.TextBox();
            this.tbAuthorFamily = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lAuthorName
            // 
            this.lAuthorName.AutoSize = true;
            this.lAuthorName.Location = new System.Drawing.Point(13, 41);
            this.lAuthorName.Name = "lAuthorName";
            this.lAuthorName.Size = new System.Drawing.Size(35, 17);
            this.lAuthorName.TabIndex = 0;
            this.lAuthorName.Text = "Име";
            // 
            // lAuthorFamily
            // 
            this.lAuthorFamily.AutoSize = true;
            this.lAuthorFamily.Location = new System.Drawing.Point(13, 78);
            this.lAuthorFamily.Name = "lAuthorFamily";
            this.lAuthorFamily.Size = new System.Drawing.Size(70, 17);
            this.lAuthorFamily.TabIndex = 1;
            this.lAuthorFamily.Text = "Фамилия";
            // 
            // tbAuthorName
            // 
            this.tbAuthorName.Location = new System.Drawing.Point(89, 41);
            this.tbAuthorName.Name = "tbAuthorName";
            this.tbAuthorName.Size = new System.Drawing.Size(181, 22);
            this.tbAuthorName.TabIndex = 2;
            // 
            // tbAuthorFamily
            // 
            this.tbAuthorFamily.Location = new System.Drawing.Point(89, 77);
            this.tbAuthorFamily.Name = "tbAuthorFamily";
            this.tbAuthorFamily.Size = new System.Drawing.Size(181, 22);
            this.tbAuthorFamily.TabIndex = 3;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(16, 133);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 28);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Добави";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bAuthorAdd);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(113, 133);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(74, 28);
            this.bExit.TabIndex = 5;
            this.bExit.Text = "Изход";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exit_click);
            // 
            // AuthorView
            // 
            this.ClientSize = new System.Drawing.Size(350, 223);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbAuthorFamily);
            this.Controls.Add(this.tbAuthorName);
            this.Controls.Add(this.lAuthorFamily);
            this.Controls.Add(this.lAuthorName);
            this.Name = "AuthorView";
            this.Text = "Добави автор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authorName;
        private System.Windows.Forms.TextBox authorFamily;
        private System.Windows.Forms.Button addAuthor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lAuthorName;
        private System.Windows.Forms.Label lAuthorFamily;
        private System.Windows.Forms.TextBox tbAuthorName;
        private System.Windows.Forms.TextBox tbAuthorFamily;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bExit;
    }
}