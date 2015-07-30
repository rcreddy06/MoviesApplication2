namespace MoviesApplication
{
    partial class searchDbForm
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
            this.fromText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.directorText = new System.Windows.Forms.TextBox();
            this.actorText = new System.Windows.Forms.TextBox();
            this.from1Text = new System.Windows.Forms.TextBox();
            this.languageText = new System.Windows.Forms.TextBox();
            this.genreText = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.moviesLabel = new System.Windows.Forms.Label();
            this.toText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Director";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Actor";
            // 
            // fromText
            // 
            this.fromText.AutoSize = true;
            this.fromText.Location = new System.Drawing.Point(50, 145);
            this.fromText.Name = "fromText";
            this.fromText.Size = new System.Drawing.Size(71, 13);
            this.fromText.TabIndex = 2;
            this.fromText.Text = "Release Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Language";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Title";
            // 
            // directorText
            // 
            this.directorText.Location = new System.Drawing.Point(127, 50);
            this.directorText.Name = "directorText";
            this.directorText.Size = new System.Drawing.Size(100, 20);
            this.directorText.TabIndex = 6;
            // 
            // actorText
            // 
            this.actorText.Location = new System.Drawing.Point(127, 95);
            this.actorText.Name = "actorText";
            this.actorText.Size = new System.Drawing.Size(100, 20);
            this.actorText.TabIndex = 7;
            // 
            // from1Text
            // 
            this.from1Text.Location = new System.Drawing.Point(127, 142);
            this.from1Text.Name = "from1Text";
            this.from1Text.Size = new System.Drawing.Size(100, 20);
            this.from1Text.TabIndex = 8;
            // 
            // languageText
            // 
            this.languageText.Location = new System.Drawing.Point(340, 47);
            this.languageText.Name = "languageText";
            this.languageText.Size = new System.Drawing.Size(100, 20);
            this.languageText.TabIndex = 9;
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(340, 92);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(100, 20);
            this.genreText.TabIndex = 10;
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(340, 138);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(100, 20);
            this.titleText.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(495, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // moviesLabel
            // 
            this.moviesLabel.AutoSize = true;
            this.moviesLabel.Location = new System.Drawing.Point(652, 50);
            this.moviesLabel.Name = "moviesLabel";
            this.moviesLabel.Size = new System.Drawing.Size(0, 13);
            this.moviesLabel.TabIndex = 15;
            // 
            // toText
            // 
            this.toText.Location = new System.Drawing.Point(127, 188);
            this.toText.Name = "toText";
            this.toText.Size = new System.Drawing.Size(100, 20);
            this.toText.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "End Year";
            // 
            // searchDbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 253);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.moviesLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.languageText);
            this.Controls.Add(this.from1Text);
            this.Controls.Add(this.actorText);
            this.Controls.Add(this.directorText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fromText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "searchDbForm";
            this.Text = "searchDbForm";
            this.Load += new System.EventHandler(this.searchDbForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fromText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox directorText;
        private System.Windows.Forms.TextBox actorText;
        private System.Windows.Forms.TextBox from1Text;
        private System.Windows.Forms.TextBox languageText;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label moviesLabel;
        private System.Windows.Forms.TextBox toText;
        private System.Windows.Forms.Label label3;
    }
}