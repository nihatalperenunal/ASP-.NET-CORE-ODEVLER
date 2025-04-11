namespace ARABA_BILGI_FORMU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Marka: "+textBoxMarka.Text + "\n" + "Model: " + textBoxModel.Text + "\n" + "Renk: " + textBoxRenk.Text + "\n" + "Kapý Sayýsý: " + textBoxKapi.Text + "\n" + "Pencere Sayýsý: " + textBoxPencere.Text + "\n" + "100 Km'de yaktýðý yakýt: " + textBoxKm.Text);
        }

        private void labelRenk_Click(object sender, EventArgs e)
        {

        }

        private void labelModel_Click(object sender, EventArgs e)
        {

        }
    }
}
