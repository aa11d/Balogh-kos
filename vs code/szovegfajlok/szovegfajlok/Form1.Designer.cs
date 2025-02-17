namespace szovegfajlok
{
    partial class FoAblak
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FileNevText = new TextBox();
            button1 = new Button();
            label1 = new Label();
            megjelen = new TextBox();
            SuspendLayout();
            // 
            // FileNevText
            // 
            FileNevText.Location = new Point(81, 6);
            FileNevText.Name = "FileNevText";
            FileNevText.Size = new Size(100, 23);
            FileNevText.TabIndex = 0;
            FileNevText.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(208, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Beolvas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "szoveg:";
            label1.Click += label1_Click_1;
            // 
            // megjelen
            // 
            megjelen.Location = new Point(12, 60);
            megjelen.Multiline = true;
            megjelen.Name = "megjelen";
            megjelen.Size = new Size(776, 353);
            megjelen.TabIndex = 4;
            megjelen.TextChanged += megjelen_TextChanged;
            // 
            // FoAblak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(megjelen);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(FileNevText);
            Name = "FoAblak";
            Text = "Szövegfájlok";
            Load += FoAblak_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FileNevText;
        private Button button1;
        private Label label1;
        private TextBox megjelen;
    }
}
