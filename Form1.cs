using System;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hastane_Randevu
{
    public partial class Form1 : Form
    {
        int index;

        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RandevuTakip.accdb");
        public Form1()
        {
            InitializeComponent();

        }

        public void view(string tabloIsmi, DataGridView grid)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from [{tabloIsmi}]"; // Köþeli parantez güvenli kullaným saðlar

                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);  // Daha kýsa kullaným
                dp.Fill(dt);

                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access baðlantý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.Clear();
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Doktor());
        }

        private void hastaButton_Click(object sender, EventArgs e)
        {
            loadform(new Hasta());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            loadform(new RandevuAl());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new RandevuListeleVeSil());
        }
    }
}
