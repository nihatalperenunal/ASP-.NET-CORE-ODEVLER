using Odev2.Interfaces;

namespace Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxOdemeYontemleri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelSonuc_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Type baseType = typeof(IOdemeYontemi);
            var odemeSiniflari = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(asm => asm.GetTypes())
                .Where(t => baseType.IsAssignableFrom(t) && t.IsClass);
            foreach (var sinif in odemeSiniflari)
            {
                comboBoxOdemeYontemleri.Items.Add(sinif.Name);
            }
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (comboBoxOdemeYontemleri.SelectedItem != null && decimal.TryParse(textBoxTutar.Text, out decimal tutar))
            {
                string secilenYontem = comboBoxOdemeYontemleri.SelectedItem.ToString();

                Type sinifTipi = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(asm => asm.GetTypes())
                    .FirstOrDefault(t => t.Name == secilenYontem);

                if (sinifTipi != null)
                {
                    var odemeNesnesi = Activator.CreateInstance(sinifTipi) as IOdemeYontemi;
                    labelSonuc.Text = odemeNesnesi?.Ode(tutar);
                }
                else
                {
                    MessageBox.Show("Se�ilen �deme y�ntemi bulunamad�.");
                }
            }
            else
            {
                MessageBox.Show("L�tfen �deme y�ntemi se�in ve ge�erli bir tutar girin!");
            }
        }
    }
}
