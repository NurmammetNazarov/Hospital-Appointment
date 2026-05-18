using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Randevu
{
    public partial class RandevuListeleVeSil : Form
    {
        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RandevuTakip.accdb;";

        public RandevuListeleVeSil()
        {
            InitializeComponent();
        }

        private void RandevuListeleVeSil_Load(object sender, EventArgs e)
        {
            // Doktorları combobox'a yükle
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                string query = "SELECT DoktorID, [Ad] & ' ' & [Soyad] AS AdSoyad FROM Doktorlar";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBoxDoktor.DataSource = dt;
                comboBoxDoktor.DisplayMember = "AdSoyad";
                comboBoxDoktor.ValueMember = "DoktorID";
                comboBoxDoktor.SelectedIndex = -1;
            }
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            if (comboBoxDoktor.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir doktor seçin.");
                return;
            }

            int doktorID = Convert.ToInt32(comboBoxDoktor.SelectedValue);
            DateTime seciliTarih = dateTimePickerTarih.Value.Date;

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string query = "SELECT RandevuID, HastaID, RandevuTarihi, RandevuSaati FROM Randevular WHERE DoktorID = ? AND RandevuTarihi = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", doktorID);
                cmd.Parameters.AddWithValue("?", seciliTarih);

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewRandevular.DataSource = dt;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewRandevular.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir randevu seçin.");
                return;
            }

            int randevuID = Convert.ToInt32(dataGridViewRandevular.SelectedRows[0].Cells["RandevuID"].Value);

            DialogResult sonuc = MessageBox.Show("Bu randevuyu silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string query = "DELETE FROM Randevular WHERE RandevuID = ?";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", randevuID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Randevu silindi.");
                btnListele.PerformClick(); // Listeyi güncelle
            }
        }
    }
}
