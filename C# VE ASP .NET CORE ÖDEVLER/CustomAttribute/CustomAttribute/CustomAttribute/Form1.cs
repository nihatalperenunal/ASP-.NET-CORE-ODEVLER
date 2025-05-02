using CustomAttribute.Attributes;
using CustomAttribute.Classess;
using System.Reflection;

namespace CustomAttribute
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBolum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            var ogrenci = new Ogrenci
            {
                Ad = txtAd.Text.Trim(),
                Soyad = txtSoyad.Text.Trim(),
                Bolum = txtBolum.Text.Trim()
            };

            var hatalar = "";
            foreach (PropertyInfo prop in typeof(Ogrenci).GetProperties())
            {
                var attr = (ZorunluAlanAttribute)prop.GetCustomAttributes(typeof(ZorunluAlanAttribute), false).FirstOrDefault();

                if (attr != null)
                {
                    var value = prop.GetValue(ogrenci) as string;

                    if (string.IsNullOrWhiteSpace(value))
                    {
                        hatalar += $"{attr.HataMesaji}\n";
                    }
                }
            }
            if (!string.IsNullOrEmpty(hatalar))
            {
                MessageBox.Show(hatalar, "Hatalar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblSonuc.Text = $"Ad: {ogrenci.Ad} - Soyad: {ogrenci.Soyad} - Bölüm: {ogrenci.Bolum}";
            }
        }
    }
    }
