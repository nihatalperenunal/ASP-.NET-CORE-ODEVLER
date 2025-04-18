using Microsoft.VisualBasic.ApplicationServices;
using SERIALIZATION_DESERIALIZATION.Classess;
using System.Text.Json;

namespace SERIALIZATION_DESERIALIZATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dosyaYolu = @"C:\Users\nihat\OneDrive\Masaüstü\SERIALIZATION DESERIALIZATION\ODEV1\SERIALIZATION DESERIALIZATION\urunler.json";

            if (File.Exists(dosyaYolu))
            {
                string jsonString = File.ReadAllText(dosyaYolu);
                List<Urun> urunler = JsonSerializer.Deserialize<List<Urun>>(jsonString);

                listBox1.Items.Clear();

                foreach (var urun in urunler)
                {
                    listBox1.Items.Add("Ürün Adý: "+ urun.UrunAdi + " Ürün Fiyatý: " + urun.Fiyat);
                }
            }
            else
            {
                MessageBox.Show("JSON dosyasý bulunamadý:\n" + dosyaYolu);
            }
        }
    }
}
