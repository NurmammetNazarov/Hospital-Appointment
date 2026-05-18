using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Hastane_Randevu
{
    public partial class Hasta : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RandevuTakip.accdb");
        public Hasta()
        {
            InitializeComponent();
        }
        private void TcKimlikText_TextChanged(object sender, EventArgs e)
        {
            TcKimlikText.MaxLength = 11;

        }

        private void TcKimlikText_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public void view(string tabloIsmi, DataGridView grid)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from [{tabloIsmi}]"; 

                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);  
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

        private void telefonText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Hastalar(TCKimlik, Ad, Soyad, DogumTarihi, Cinsiyet, Telefon, Email)" +
                                  "values('" + TcKimlikText.Text + "'," +
                                  "'" + adText.Text + "'," +
                                  "'" + soyadText.Text + "'," +
                                  "'" + dogumDate.Value.Date + "'," +
                                  "'" + cinsiyetBox.Text + "'," +
                                  "'" + telefonText.Text + "', " +
                                  "'" + mailText.Text + "' )";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hasta kaydedildi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();

                view("Hastalar", hastaDataGrid);
                TcKimlikText.Text = "";
                adText.Text = "";
                soyadText.Text = "";
                dogumDate.ResetText();
                cinsiyetBox.Text = "";
                telefonText.Text = "";
                mailText.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }

        }

        private void Hasta_Load(object sender, EventArgs e)
        {

            view("Hastalar", hastaDataGrid);

        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            int HastaID = Convert.ToInt32(hastaDataGrid.SelectedRows[0].Cells[0].Value);

            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update Hastalar set " +
                                  "TCKimlik = '" + TcKimlikText.Text + "', " +
                                  "Ad = '" + adText.Text + "', " +
                                  "Soyad = '" + soyadText.Text + "', " +
                                  "DogumTarihi = '" + dogumDate.Value.Date + "'," +
                                  "Cinsiyet = '" + cinsiyetBox.Text + "', " +
                                  "Telefon = '" + telefonText.Text + "', " +
                                  "Email = '" + mailText.Text + "' " +
                                  "where HastaID = " + HastaID;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Hasta bilgileri düzenlendi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
                view("Hastalar", hastaDataGrid);

                TcKimlikText.Text = "";
                adText.Text = "";
                soyadText.Text = "";
                dogumDate.ResetText();
                cinsiyetBox.Text = "";
                telefonText.Text = "";
                mailText.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }


        private void hastaDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TcKimlikText.Text = hastaDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                adText.Text = hastaDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                soyadText.Text = hastaDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                dogumDate.Value = Convert.ToDateTime(hastaDataGrid.SelectedRows[0].Cells[4].Value);
                cinsiyetBox.Text = hastaDataGrid.SelectedRows[0].Cells[5].Value.ToString();
                telefonText.Text = hastaDataGrid.SelectedRows[0].Cells[6].Value.ToString();
                mailText.Text = hastaDataGrid.SelectedRows[0].Cells[7].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            int HastaID = Convert.ToInt32(hastaDataGrid.SelectedRows[0].Cells[0].Value);

            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "delete * from Hastalar where HastaID = " + HastaID;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Hasta bilgileri silindi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
                view("Hastalar", hastaDataGrid);

                TcKimlikText.Text = "";
                adText.Text = "";
                soyadText.Text = "";
                dogumDate.ResetText();
                cinsiyetBox.Text = "";
                telefonText.Text = "";
                mailText.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            TcKimlikText.Text = "";
            adText.Text = "";
            soyadText.Text = "";
            dogumDate.ResetText();
            cinsiyetBox.Text = "";
            telefonText.Text = "";
            mailText.Text = "";

            view("Hastalar", hastaDataGrid);
        }
    }
}
