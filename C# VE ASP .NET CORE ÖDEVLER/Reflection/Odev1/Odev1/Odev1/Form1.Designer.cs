namespace Odev1
{
    partial class Form1
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
            textYol = new TextBox();
            butonListele = new Button();
            listBox1 = new ListBox();
            labelYol = new Label();
            labelSonuc = new Label();
            SuspendLayout();
            // 
            // textYol
            // 
            textYol.Location = new Point(281, 76);
            textYol.Name = "textYol";
            textYol.Size = new Size(197, 27);
            textYol.TabIndex = 0;
            // 
            // butonListele
            // 
            butonListele.Location = new Point(281, 194);
            butonListele.Name = "butonListele";
            butonListele.Size = new Size(197, 29);
            butonListele.TabIndex = 1;
            butonListele.Text = "Class ve Klasörleri Listele";
            butonListele.UseVisualStyleBackColor = true;
            butonListele.Click += butonListele_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(281, 262);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(307, 104);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // labelYol
            // 
            labelYol.AutoSize = true;
            labelYol.Location = new Point(74, 79);
            labelYol.Name = "labelYol";
            labelYol.Size = new Size(135, 20);
            labelYol.TabIndex = 3;
            labelYol.Text = "Dosya Yolunu girin:";
            labelYol.Click += label1_Click;
            // 
            // labelSonuc
            // 
            labelSonuc.AutoSize = true;
            labelSonuc.Location = new Point(85, 262);
            labelSonuc.Name = "labelSonuc";
            labelSonuc.Size = new Size(69, 20);
            labelSonuc.TabIndex = 4;
            labelSonuc.Text = "Sonuçlar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSonuc);
            Controls.Add(labelYol);
            Controls.Add(listBox1);
            Controls.Add(butonListele);
            Controls.Add(textYol);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textYol;
        private Button butonListele;
        private ListBox listBox1;
        private Label labelYol;
        private Label labelSonuc;
    }
}
