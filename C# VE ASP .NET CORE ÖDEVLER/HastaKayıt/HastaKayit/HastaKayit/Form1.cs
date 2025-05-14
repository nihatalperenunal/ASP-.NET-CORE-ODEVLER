using Microsoft.Data.SqlClient;
using System.Data;
using System.Numerics;

namespace HastaKayit
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=ALPEREN\SQLEXPRESS_2019;Initial Catalog=14.05.2025;Integrated Security=SSPI;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Branslar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbBrans.DisplayMember = "BransAdi";
                cmbBrans.ValueMember = "Id";
                cmbBrans.DataSource = dt;

                
                cmbSaat.Items.AddRange(new string[] { "09:00", "10:00", "11:00", "13:00", "14:00" });
            }
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bransID = Convert.ToInt32(cmbBrans.SelectedValue);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, DoktorAdi, DoktorSoyadi FROM Doktorlar WHERE BransID = @bransID", conn);
                da.SelectCommand.Parameters.AddWithValue("@bransID", bransID);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                List<Doctor> doktorlar = new List<Doctor>();
                foreach (DataRow row in dt.Rows)
                {
                    
                    doktorlar.Add(new Doctor
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        DoktorAdi = row["DoktorAdi"].ToString(),
                        DoktorSoyadi = row["DoktorSoyadi"].ToString()
                    });
                }

                
                cmbDoktor.DataSource = doktorlar;
                cmbDoktor.DisplayMember = "FullName";  
                cmbDoktor.ValueMember = "Id";  
            }
        }
        public class Doctor
        {
            public int Id { get; set; }
            public string DoktorAdi { get; set; }
            public string DoktorSoyadi { get; set; }

            
            public string FullName => DoktorAdi + " " + DoktorSoyadi;
        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHastaAdi.Text) || string.IsNullOrWhiteSpace(txtHastaSoyadi.Text))
            {
                MessageBox.Show("Lütfen hasta ad ve soyadýný giriniz.");
                return;
            }

            DateTime seciliTarihSaat = DateTime.Parse($"{DateTimePicker.Value.ToShortDateString()} {cmbSaat.SelectedItem}");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                
                SqlCommand cmdKontrol = new SqlCommand("SELECT COUNT(*) FROM Randevular WHERE DoktorID = @doktorID AND Tarih = @tarih", conn);
                cmdKontrol.Parameters.AddWithValue("@doktorID", cmbDoktor.SelectedValue);  
                cmdKontrol.Parameters.AddWithValue("@tarih", seciliTarihSaat);

                int sayi = (int)cmdKontrol.ExecuteScalar();
                if (sayi > 0)
                {
                    MessageBox.Show("Bu saat için bu doktora zaten bir randevu var.");
                    return;
                }

                
                SqlCommand cmd = new SqlCommand("INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih) VALUES (@adi, @soyadi, @bransID, @doktorID, @tarih)", conn);
                cmd.Parameters.AddWithValue("@adi", txtHastaAdi.Text);
                cmd.Parameters.AddWithValue("@soyadi", txtHastaSoyadi.Text);
                cmd.Parameters.AddWithValue("@bransID", cmbBrans.SelectedValue);
                cmd.Parameters.AddWithValue("@doktorID", cmbDoktor.SelectedValue);
                cmd.Parameters.AddWithValue("@tarih", seciliTarihSaat);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Randevu baþarýyla oluþturuldu.");
            }
        }
    }
}
