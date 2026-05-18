using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hastane_Randevu
{
    public partial class RandevuAl : Form
    {
        public RandevuAl()
        {
            InitializeComponent();
        }

        private void RandevuAl_Load(object sender, EventArgs e)
        {
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RandevuTakip.accdb;";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                // Poliklinikler / Uzmanlıklar
                string queryUzmanlik = "SELECT DISTINCT Uzmanlık FROM Doktorlar WHERE Uzmanlık IS NOT NULL";
                OleDbDataAdapter uzmanlikAdapter = new OleDbDataAdapter(queryUzmanlik, conn);
                DataTable dtUzmanlik = new DataTable();
                uzmanlikAdapter.Fill(dtUzmanlik);
                uzmanlikBox.DataSource = dtUzmanlik;
                uzmanlikBox.DisplayMember = "Uzmanlık";
                uzmanlikBox.ValueMember = "Uzmanlık";
                uzmanlikBox.SelectedIndex = -1;

                // Hastalar
                string queryHastalar = "SELECT HastaID, [Ad] & ' ' & [Soyad] AS AdSoyad FROM Hastalar";
                OleDbDataAdapter hastaAdapter = new OleDbDataAdapter(queryHastalar, conn);
                DataTable dtHastalar = new DataTable();
                hastaAdapter.Fill(dtHastalar);
                hastaAdBox.DataSource = dtHastalar;
                hastaAdBox.DisplayMember = "AdSoyad";
                hastaAdBox.ValueMember = "HastaID";
                hastaAdBox.SelectedIndex = -1;
            }
        }

        private void uzmanlikBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uzmanlikBox.SelectedValue == null) return;

            string secilenUzmanlik = uzmanlikBox.SelectedValue.ToString();
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RandevuTakip.accdb;";
            string query = "SELECT DoktorID, [Ad] & ' ' & [Soyad] AS AdSoyad FROM Doktorlar WHERE [Uzmanlık] = ?";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", secilenUzmanlik);

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                doktorAdıBox.DataSource = dt;
                doktorAdıBox.DisplayMember = "AdSoyad";
                doktorAdıBox.ValueMember = "DoktorID";
                doktorAdıBox.SelectedIndex = -1;
            }
        }

        private void doktorAdıBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaatleriKontrolEt();
        }

        private void randevuTarihi_ValueChanged(object sender, EventArgs e)
        {
            SaatleriKontrolEt();
        }

        private void SaatleriKontrolEt()
        {
            if (doktorAdıBox.SelectedValue == null) return;

            int doktorID = Convert.ToInt32(doktorAdıBox.SelectedValue);
            DateTime secilenTarih = randevuTarihi.Value.Date;

            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RandevuTakip.accdb;";
            List<string> doluSaatler = new List<string>();

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                string query = "SELECT RandevuSaati FROM Randevular WHERE DoktorID = ? AND RandevuTarihi = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", doktorID);
                cmd.Parameters.AddWithValue("?", secilenTarih);

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    doluSaatler.Add(reader["RandevuSaati"].ToString());
                }
            }

            // Panel içindeki saatleri kontrol et
            foreach (Control ctrl in saatPaneli.Controls)
            {
                if (ctrl is RadioButton rb)
                {
                    rb.Enabled = true;
                    if (doluSaatler.Contains(rb.Text))
                    {
                        rb.Enabled = false;
                    }
                }
            }
        }

        private void randevuAlButton_Click(object sender, EventArgs e)
        {
            if (hastaAdBox.SelectedValue == null || doktorAdıBox.SelectedValue == null)
            {
                MessageBox.Show("Lütfen hasta ve doktor seçiniz.");
                return;
            }

            string secilenSaat = "";
            foreach (Control ctrl in saatPaneli.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    secilenSaat = rb.Text;
                    break;
                }
            }

            if (string.IsNullOrEmpty(secilenSaat))
            {
                MessageBox.Show("Lütfen bir saat seçiniz.");
                return;
            }

            int hastaID = Convert.ToInt32(hastaAdBox.SelectedValue);
            int doktorID = Convert.ToInt32(doktorAdıBox.SelectedValue);
            DateTime tarih = randevuTarihi.Value.Date;

            // Randevuyu kaydet
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RandevuTakip.accdb;";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                // Önce aynı saatte randevu var mı kontrol et
                string checkQuery = "SELECT COUNT(*) FROM Randevular WHERE DoktorID = ? AND RandevuTarihi = ? AND RandevuSaati = ?";
                OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("?", doktorID);
                checkCmd.Parameters.AddWithValue("?", tarih);
                checkCmd.Parameters.AddWithValue("?", secilenSaat);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Seçilen saat dolu. Lütfen başka bir saat seçin.");
                    SaatleriKontrolEt();
                    return;
                }

                // Randevuyu ekle
                string insertQuery = "INSERT INTO Randevular (HastaID, DoktorID, RandevuTarihi, RandevuSaati) VALUES (?, ?, ?, ?)";
                OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("?", hastaID);
                insertCmd.Parameters.AddWithValue("?", doktorID);
                insertCmd.Parameters.AddWithValue("?", tarih);
                insertCmd.Parameters.AddWithValue("?", secilenSaat);

                insertCmd.ExecuteNonQuery();
                MessageBox.Show("Randevu başarıyla alındı.");

                SaatleriKontrolEt(); // güncelle
            }
        }
    }
}
