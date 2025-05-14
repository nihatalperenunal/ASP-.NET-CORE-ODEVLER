namespace HastaKayit
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
            lblBrans = new Label();
            cmbBrans = new ComboBox();
            lblDoktor = new Label();
            cmbDoktor = new ComboBox();
            lblTarih = new Label();
            DateTimePicker = new DateTimePicker();
            lblSaat = new Label();
            cmbSaat = new ComboBox();
            lblHastaAdi = new Label();
            txtHastaAdi = new TextBox();
            lblHastaSoyadi = new Label();
            txtHastaSoyadi = new TextBox();
            btnRandevuOlustur = new Button();
            SuspendLayout();
            // 
            // lblBrans
            // 
            lblBrans.AutoSize = true;
            lblBrans.Location = new Point(110, 50);
            lblBrans.Name = "lblBrans";
            lblBrans.Size = new Size(52, 20);
            lblBrans.TabIndex = 0;
            lblBrans.Text = "Branş: ";
            // 
            // cmbBrans
            // 
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(250, 47);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(250, 28);
            cmbBrans.TabIndex = 1;
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
            // 
            // lblDoktor
            // 
            lblDoktor.AutoSize = true;
            lblDoktor.Location = new Point(110, 109);
            lblDoktor.Name = "lblDoktor";
            lblDoktor.Size = new Size(62, 20);
            lblDoktor.TabIndex = 2;
            lblDoktor.Text = "Doktor: ";
            // 
            // cmbDoktor
            // 
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(250, 106);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(250, 28);
            cmbDoktor.TabIndex = 3;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(110, 173);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(47, 20);
            lblTarih.TabIndex = 4;
            lblTarih.Text = "Tarih: ";
            lblTarih.Click += label1_Click;
            // 
            // DateTimePicker
            // 
            DateTimePicker.Location = new Point(250, 168);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(250, 27);
            DateTimePicker.TabIndex = 5;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Location = new Point(110, 236);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(45, 20);
            lblSaat.TabIndex = 6;
            lblSaat.Text = "Saat: ";
            // 
            // cmbSaat
            // 
            cmbSaat.FormattingEnabled = true;
            cmbSaat.Location = new Point(250, 233);
            cmbSaat.Name = "cmbSaat";
            cmbSaat.Size = new Size(250, 28);
            cmbSaat.TabIndex = 7;
            // 
            // lblHastaAdi
            // 
            lblHastaAdi.AutoSize = true;
            lblHastaAdi.Location = new Point(110, 295);
            lblHastaAdi.Name = "lblHastaAdi";
            lblHastaAdi.Size = new Size(81, 20);
            lblHastaAdi.TabIndex = 8;
            lblHastaAdi.Text = "Hasta Adı: ";
            // 
            // txtHastaAdi
            // 
            txtHastaAdi.Location = new Point(250, 292);
            txtHastaAdi.Name = "txtHastaAdi";
            txtHastaAdi.Size = new Size(250, 27);
            txtHastaAdi.TabIndex = 9;
            // 
            // lblHastaSoyadi
            // 
            lblHastaSoyadi.AutoSize = true;
            lblHastaSoyadi.Location = new Point(110, 359);
            lblHastaSoyadi.Name = "lblHastaSoyadi";
            lblHastaSoyadi.Size = new Size(103, 20);
            lblHastaSoyadi.TabIndex = 10;
            lblHastaSoyadi.Text = "Hasta Soyadı: ";
            // 
            // txtHastaSoyadi
            // 
            txtHastaSoyadi.Location = new Point(250, 356);
            txtHastaSoyadi.Name = "txtHastaSoyadi";
            txtHastaSoyadi.Size = new Size(250, 27);
            txtHastaSoyadi.TabIndex = 11;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(594, 391);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(194, 47);
            btnRandevuOlustur.TabIndex = 12;
            btnRandevuOlustur.Text = "Randevu Oluştur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRandevuOlustur);
            Controls.Add(txtHastaSoyadi);
            Controls.Add(lblHastaSoyadi);
            Controls.Add(txtHastaAdi);
            Controls.Add(lblHastaAdi);
            Controls.Add(cmbSaat);
            Controls.Add(lblSaat);
            Controls.Add(DateTimePicker);
            Controls.Add(lblTarih);
            Controls.Add(cmbDoktor);
            Controls.Add(lblDoktor);
            Controls.Add(cmbBrans);
            Controls.Add(lblBrans);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrans;
        private ComboBox cmbBrans;
        private Label lblDoktor;
        private ComboBox cmbDoktor;
        private Label lblTarih;
        private DateTimePicker DateTimePicker;
        private Label lblSaat;
        private ComboBox cmbSaat;
        private Label lblHastaAdi;
        private TextBox txtHastaAdi;
        private Label lblHastaSoyadi;
        private TextBox txtHastaSoyadi;
        private Button btnRandevuOlustur;
    }
}
