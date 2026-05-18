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
    public partial class Doktor : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RandevuTakip.accdb");

        public Doktor()
        {
            InitializeComponent();
        }

        private void Doktor_Load(object sender, EventArgs e)
        {
            view("Doktorlar", doktorDataGrid);

        }
        public void view(string tabloIsmi, DataGridView grid)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from [{tabloIsmi}]"; // Köşeli parantez güvenli kullanım sağlar

                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);  // Daha kısa kullanım
                dp.Fill(dt);

                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access bağlantı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void temizle_Click(object sender, EventArgs e)
        {
            adText.Text = "";
            soyadText.Text = "";
            uzmanlikBox.Text = "";
            telefonText.Text = "";
            mailText.Text = "";

            view("Doktorlar", doktorDataGrid);
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Doktorlar(Ad, Soyad, Uzmanlık, Telefon, Email)" +
                                  "values('" + adText.Text + "'," +
                                  "'" + soyadText.Text + "'," +
                                  "'" + uzmanlikBox.Text + "'," +
                                  "'" + telefonText.Text + "'," +
                                  "'" + mailText.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doktor bilgileri kaydedildi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();

                view("Doktorlar", doktorDataGrid);
                adText.Text = "";
                soyadText.Text = "";
                uzmanlikBox.Text = "";
                telefonText.Text = "";
                mailText.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            int DoktorID = Convert.ToInt32(doktorDataGrid.SelectedRows[0].Cells[0].Value);

            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update Doktorlar set " +
                                  "Ad = '" + adText.Text + "', " +
                                  "Soyad = '" + soyadText.Text + "', " +
                                  "Uzmanlık = '" + uzmanlikBox.Text + "', " +
                                  "Telefon = '" + telefonText.Text + "', " +
                                  "Email = '" + mailText.Text + "' " +
                                  "where DoktorID = " + DoktorID;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Doktor bilgileri düzenlendi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();

                view("Doktorlar", doktorDataGrid);
                adText.Text = "";
                soyadText.Text = "";
                uzmanlikBox.Text = "";
                telefonText.Text = "";
                mailText.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            int DoktorID = Convert.ToInt32(doktorDataGrid.SelectedRows[0].Cells[0].Value);

            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "delete * from Doktorlar where DoktorID = " + DoktorID;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Doktor bilgileri silindi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
                view("Doktorlar", doktorDataGrid);

                adText.Text = "";
                soyadText.Text = "";
                uzmanlikBox.Text = "";
                telefonText.Text = "";
                mailText.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void doktorDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                adText.Text = doktorDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                soyadText.Text = doktorDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                uzmanlikBox.Text = doktorDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                telefonText.Text = doktorDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                mailText.Text = doktorDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
