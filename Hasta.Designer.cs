namespace Hastane_Randevu
{
    partial class Hasta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            cinsiyetBox = new ComboBox();
            hastaDataGrid = new DataGridView();
            duzenle = new Button();
            sil = new Button();
            temizle = new Button();
            ekle = new Button();
            dogumDate = new DateTimePicker();
            mailText = new TextBox();
            telefonText = new TextBox();
            soyadText = new TextBox();
            adText = new TextBox();
            TcKimlikText = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hastaDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(125, 64);
            label2.Name = "label2";
            label2.Size = new Size(48, 32);
            label2.TabIndex = 0;
            label2.Text = "Ad:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(cinsiyetBox);
            panel1.Controls.Add(hastaDataGrid);
            panel1.Controls.Add(duzenle);
            panel1.Controls.Add(sil);
            panel1.Controls.Add(temizle);
            panel1.Controls.Add(ekle);
            panel1.Controls.Add(dogumDate);
            panel1.Controls.Add(mailText);
            panel1.Controls.Add(telefonText);
            panel1.Controls.Add(soyadText);
            panel1.Controls.Add(adText);
            panel1.Controls.Add(TcKimlikText);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 612);
            panel1.TabIndex = 0;
            // 
            // cinsiyetBox
            // 
            cinsiyetBox.Font = new Font("Segoe UI", 16F);
            cinsiyetBox.FormattingEnabled = true;
            cinsiyetBox.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cinsiyetBox.Location = new Point(179, 159);
            cinsiyetBox.Name = "cinsiyetBox";
            cinsiyetBox.Size = new Size(171, 38);
            cinsiyetBox.TabIndex = 5;
            // 
            // hastaDataGrid
            // 
            hastaDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            hastaDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hastaDataGrid.Location = new Point(16, 402);
            hastaDataGrid.Name = "hastaDataGrid";
            hastaDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            hastaDataGrid.Size = new Size(927, 177);
            hastaDataGrid.TabIndex = 4;
            hastaDataGrid.CellClick += hastaDataGrid_CellClick;
            // 
            // duzenle
            // 
            duzenle.Font = new Font("Segoe UI", 14F);
            duzenle.Location = new Point(237, 357);
            duzenle.Name = "duzenle";
            duzenle.Size = new Size(96, 37);
            duzenle.TabIndex = 3;
            duzenle.Text = "Düzenle";
            duzenle.UseVisualStyleBackColor = true;
            duzenle.Click += duzenle_Click;
            // 
            // sil
            // 
            sil.Font = new Font("Segoe UI", 14F);
            sil.Location = new Point(339, 357);
            sil.Name = "sil";
            sil.Size = new Size(96, 37);
            sil.TabIndex = 3;
            sil.Text = "Sil";
            sil.UseVisualStyleBackColor = true;
            sil.Click += sil_Click;
            // 
            // temizle
            // 
            temizle.Font = new Font("Segoe UI", 14F);
            temizle.Location = new Point(33, 357);
            temizle.Name = "temizle";
            temizle.Size = new Size(96, 37);
            temizle.TabIndex = 3;
            temizle.Text = "Temizle";
            temizle.UseVisualStyleBackColor = true;
            temizle.Click += temizle_Click;
            // 
            // ekle
            // 
            ekle.Font = new Font("Segoe UI", 14F);
            ekle.Location = new Point(135, 357);
            ekle.Name = "ekle";
            ekle.Size = new Size(96, 37);
            ekle.TabIndex = 3;
            ekle.Text = "Ekle";
            ekle.UseVisualStyleBackColor = true;
            ekle.Click += ekle_Click;
            // 
            // dogumDate
            // 
            dogumDate.CalendarFont = new Font("Segoe UI", 18F);
            dogumDate.Location = new Point(179, 217);
            dogumDate.Name = "dogumDate";
            dogumDate.Size = new Size(171, 23);
            dogumDate.TabIndex = 2;
            dogumDate.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // mailText
            // 
            mailText.Font = new Font("Segoe UI", 10F);
            mailText.Location = new Point(179, 311);
            mailText.Name = "mailText";
            mailText.Size = new Size(171, 25);
            mailText.TabIndex = 1;
            // 
            // telefonText
            // 
            telefonText.Font = new Font("Segoe UI", 16F);
            telefonText.Location = new Point(179, 252);
            telefonText.Name = "telefonText";
            telefonText.Size = new Size(171, 36);
            telefonText.TabIndex = 1;
            telefonText.KeyPress += telefonText_KeyPress;
            // 
            // soyadText
            // 
            soyadText.Font = new Font("Segoe UI", 16F);
            soyadText.Location = new Point(179, 112);
            soyadText.Name = "soyadText";
            soyadText.Size = new Size(171, 36);
            soyadText.TabIndex = 1;
            // 
            // adText
            // 
            adText.Font = new Font("Segoe UI", 16F);
            adText.Location = new Point(179, 64);
            adText.Name = "adText";
            adText.Size = new Size(171, 36);
            adText.TabIndex = 1;
            // 
            // TcKimlikText
            // 
            TcKimlikText.Font = new Font("Segoe UI", 16F);
            TcKimlikText.Location = new Point(179, 16);
            TcKimlikText.Name = "TcKimlikText";
            TcKimlikText.Size = new Size(171, 36);
            TcKimlikText.TabIndex = 1;
            TcKimlikText.TextChanged += TcKimlikText_TextChanged;
            TcKimlikText.KeyPress += TcKimlikText_KeyPress_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(86, 304);
            label7.Name = "label7";
            label7.Size = new Size(87, 32);
            label7.TabIndex = 0;
            label7.Text = "E-Mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(75, 256);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 0;
            label6.Text = "Telefon:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(11, 208);
            label5.Name = "label5";
            label5.Size = new Size(162, 32);
            label5.TabIndex = 0;
            label5.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(70, 160);
            label4.Name = "label4";
            label4.Size = new Size(103, 32);
            label4.TabIndex = 0;
            label4.Text = "Cinsiyet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(89, 112);
            label3.Name = "label3";
            label3.Size = new Size(84, 32);
            label3.TabIndex = 0;
            label3.Text = "Soyad:";
            // 
            // Hasta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 636);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Hasta";
            Text = "Hasta";
            Load += Hasta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hastaDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TcKimlikText;
        private TextBox mailText;
        private TextBox telefonText;
        private TextBox soyadText;
        private TextBox adText;
        private DateTimePicker dogumDate;
        private Button ekle;
        private DataGridView hastaDataGrid;
        private Button temizle;
        private ComboBox cinsiyetBox;
        private Button sil;
        private Button duzenle;
    }
}