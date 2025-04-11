namespace ARABA_BILGI_FORMU
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
            labelMarka = new Label();
            textBoxMarka = new TextBox();
            button1 = new Button();
            labelModel = new Label();
            labelRenk = new Label();
            labelKapiSayisi = new Label();
            labelPencereSayisi = new Label();
            label100km = new Label();
            textBoxModel = new TextBox();
            textBoxRenk = new TextBox();
            textBoxKapi = new TextBox();
            textBoxPencere = new TextBox();
            textBoxKm = new TextBox();
            SuspendLayout();
            // 
            // labelMarka
            // 
            labelMarka.AutoSize = true;
            labelMarka.Location = new Point(85, 81);
            labelMarka.Name = "labelMarka";
            labelMarka.Size = new Size(53, 20);
            labelMarka.TabIndex = 0;
            labelMarka.Text = "Marka:";
            labelMarka.Click += label1_Click;
            // 
            // textBoxMarka
            // 
            textBoxMarka.Location = new Point(270, 78);
            textBoxMarka.Name = "textBoxMarka";
            textBoxMarka.Size = new Size(125, 27);
            textBoxMarka.TabIndex = 1;
            textBoxMarka.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(70, 353);
            button1.Name = "button1";
            button1.Size = new Size(156, 69);
            button1.TabIndex = 2;
            button1.Text = "Bilgileri Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(85, 124);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(55, 20);
            labelModel.TabIndex = 3;
            labelModel.Text = "Model:";
            labelModel.Click += labelModel_Click;
            // 
            // labelRenk
            // 
            labelRenk.AutoSize = true;
            labelRenk.Location = new Point(85, 163);
            labelRenk.Name = "labelRenk";
            labelRenk.Size = new Size(44, 20);
            labelRenk.TabIndex = 4;
            labelRenk.Text = "Renk:";
            labelRenk.Click += labelRenk_Click;
            // 
            // labelKapiSayisi
            // 
            labelKapiSayisi.AutoSize = true;
            labelKapiSayisi.Location = new Point(85, 200);
            labelKapiSayisi.Name = "labelKapiSayisi";
            labelKapiSayisi.Size = new Size(83, 20);
            labelKapiSayisi.TabIndex = 5;
            labelKapiSayisi.Text = "Kapı Sayısı:";
            // 
            // labelPencereSayisi
            // 
            labelPencereSayisi.AutoSize = true;
            labelPencereSayisi.Location = new Point(85, 237);
            labelPencereSayisi.Name = "labelPencereSayisi";
            labelPencereSayisi.Size = new Size(104, 20);
            labelPencereSayisi.TabIndex = 6;
            labelPencereSayisi.Text = "Pencere Sayısı:";
            // 
            // label100km
            // 
            label100km.AutoSize = true;
            label100km.Location = new Point(85, 278);
            label100km.Name = "label100km";
            label100km.Size = new Size(165, 20);
            label100km.TabIndex = 7;
            label100km.Text = "100 Km'de Yaktığı Yakıt:";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(270, 121);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(125, 27);
            textBoxModel.TabIndex = 8;
            // 
            // textBoxRenk
            // 
            textBoxRenk.Location = new Point(270, 160);
            textBoxRenk.Name = "textBoxRenk";
            textBoxRenk.Size = new Size(125, 27);
            textBoxRenk.TabIndex = 9;
            // 
            // textBoxKapi
            // 
            textBoxKapi.Location = new Point(270, 197);
            textBoxKapi.Name = "textBoxKapi";
            textBoxKapi.Size = new Size(125, 27);
            textBoxKapi.TabIndex = 10;
            // 
            // textBoxPencere
            // 
            textBoxPencere.Location = new Point(270, 234);
            textBoxPencere.Name = "textBoxPencere";
            textBoxPencere.Size = new Size(125, 27);
            textBoxPencere.TabIndex = 11;
            // 
            // textBoxKm
            // 
            textBoxKm.Location = new Point(270, 275);
            textBoxKm.Name = "textBoxKm";
            textBoxKm.Size = new Size(125, 27);
            textBoxKm.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxKm);
            Controls.Add(textBoxPencere);
            Controls.Add(textBoxKapi);
            Controls.Add(textBoxRenk);
            Controls.Add(textBoxModel);
            Controls.Add(label100km);
            Controls.Add(labelPencereSayisi);
            Controls.Add(labelKapiSayisi);
            Controls.Add(labelRenk);
            Controls.Add(labelModel);
            Controls.Add(button1);
            Controls.Add(textBoxMarka);
            Controls.Add(labelMarka);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMarka;
        private TextBox textBoxMarka;
        private Button button1;
        private Label labelModel;
        private Label labelRenk;
        private Label labelKapiSayisi;
        private Label labelPencereSayisi;
        private Label label100km;
        private TextBox textBoxModel;
        private TextBox textBoxRenk;
        private TextBox textBoxKapi;
        private TextBox textBoxPencere;
        private TextBox textBoxKm;
    }
}
