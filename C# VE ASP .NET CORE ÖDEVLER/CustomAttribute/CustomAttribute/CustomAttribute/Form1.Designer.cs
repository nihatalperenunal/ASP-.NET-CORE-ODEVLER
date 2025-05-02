namespace CustomAttribute
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblBolum = new Label();
            txtAd = new TextBox();
            txtBolum = new TextBox();
            txtSoyad = new TextBox();
            btnDogrula = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(118, 35);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(91, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Öğrenci Adı:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(118, 84);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(113, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Öğrenci Soyadı:";
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Location = new Point(118, 131);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(63, 20);
            lblBolum.TabIndex = 2;
            lblBolum.Text = "Bölümü:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(312, 35);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 3;
            txtAd.TextChanged += txtAd_TextChanged;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(312, 131);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(125, 27);
            txtBolum.TabIndex = 4;
            txtBolum.TextChanged += txtBolum_TextChanged;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(312, 84);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 5;
            // 
            // btnDogrula
            // 
            btnDogrula.Location = new Point(118, 191);
            btnDogrula.Name = "btnDogrula";
            btnDogrula.Size = new Size(178, 72);
            btnDogrula.TabIndex = 6;
            btnDogrula.Text = "Bilgileri Doğrula";
            btnDogrula.UseVisualStyleBackColor = true;
            btnDogrula.Click += btnDogrula_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(118, 312);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(56, 20);
            lblSonuc.TabIndex = 7;
            lblSonuc.Text = "Sonuç: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnDogrula);
            Controls.Add(txtSoyad);
            Controls.Add(txtBolum);
            Controls.Add(txtAd);
            Controls.Add(lblBolum);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblBolum;
        private TextBox txtAd;
        private TextBox txtBolum;
        private TextBox txtSoyad;
        private Button btnDogrula;
        private Label lblSonuc;
    }
}
