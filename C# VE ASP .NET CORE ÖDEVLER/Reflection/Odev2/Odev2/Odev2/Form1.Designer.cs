namespace Odev2
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
            labelSonuc = new Label();
            btnOdemeYap = new Button();
            labelTutar = new Label();
            textBoxTutar = new TextBox();
            comboBoxOdemeYontemleri = new ComboBox();
            labelOdemeYontemi = new Label();
            SuspendLayout();
            // 
            // labelSonuc
            // 
            labelSonuc.AutoSize = true;
            labelSonuc.Location = new Point(98, 358);
            labelSonuc.Name = "labelSonuc";
            labelSonuc.Size = new Size(56, 20);
            labelSonuc.TabIndex = 0;
            labelSonuc.Text = "Sonuç: ";
            labelSonuc.Click += labelSonuc_Click;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Location = new Point(306, 255);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(151, 54);
            btnOdemeYap.TabIndex = 1;
            btnOdemeYap.Text = "Ödeme Yap";
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // labelTutar
            // 
            labelTutar.AutoSize = true;
            labelTutar.Location = new Point(98, 196);
            labelTutar.Name = "labelTutar";
            labelTutar.Size = new Size(99, 20);
            labelTutar.TabIndex = 2;
            labelTutar.Text = "Tutarı giriniz: ";
            // 
            // textBoxTutar
            // 
            textBoxTutar.Location = new Point(306, 193);
            textBoxTutar.Name = "textBoxTutar";
            textBoxTutar.Size = new Size(151, 27);
            textBoxTutar.TabIndex = 3;
            // 
            // comboBoxOdemeYontemleri
            // 
            comboBoxOdemeYontemleri.FormattingEnabled = true;
            comboBoxOdemeYontemleri.Location = new Point(306, 106);
            comboBoxOdemeYontemleri.Name = "comboBoxOdemeYontemleri";
            comboBoxOdemeYontemleri.Size = new Size(151, 28);
            comboBoxOdemeYontemleri.TabIndex = 4;
            comboBoxOdemeYontemleri.SelectedIndexChanged += comboBoxOdemeYontemleri_SelectedIndexChanged;
            // 
            // labelOdemeYontemi
            // 
            labelOdemeYontemi.AutoSize = true;
            labelOdemeYontemi.Location = new Point(98, 109);
            labelOdemeYontemi.Name = "labelOdemeYontemi";
            labelOdemeYontemi.Size = new Size(185, 20);
            labelOdemeYontemi.TabIndex = 5;
            labelOdemeYontemi.Text = "Ödeme Yöntemini Seçiniz: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelOdemeYontemi);
            Controls.Add(comboBoxOdemeYontemleri);
            Controls.Add(textBoxTutar);
            Controls.Add(labelTutar);
            Controls.Add(btnOdemeYap);
            Controls.Add(labelSonuc);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSonuc;
        private Button btnOdemeYap;
        private Label labelTutar;
        private TextBox textBoxTutar;
        private ComboBox comboBoxOdemeYontemleri;
        private Label labelOdemeYontemi;
    }
}
