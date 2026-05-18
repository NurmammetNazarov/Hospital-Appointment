namespace Hastane_Randevu
{
    partial class RandevuListeleVeSil
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
            comboBoxDoktor = new ComboBox();
            dateTimePickerTarih = new DateTimePicker();
            btnListele = new Button();
            dataGridViewRandevular = new DataGridView();
            btnSil = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRandevular).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxDoktor
            // 
            comboBoxDoktor.FormattingEnabled = true;
            comboBoxDoktor.Location = new Point(98, 67);
            comboBoxDoktor.Name = "comboBoxDoktor";
            comboBoxDoktor.Size = new Size(200, 23);
            comboBoxDoktor.TabIndex = 0;
            // 
            // dateTimePickerTarih
            // 
            dateTimePickerTarih.Location = new Point(348, 67);
            dateTimePickerTarih.Name = "dateTimePickerTarih";
            dateTimePickerTarih.Size = new Size(200, 23);
            dateTimePickerTarih.TabIndex = 1;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(98, 118);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(75, 23);
            btnListele.TabIndex = 2;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // dataGridViewRandevular
            // 
            dataGridViewRandevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRandevular.Location = new Point(86, 135);
            dataGridViewRandevular.Name = "dataGridViewRandevular";
            dataGridViewRandevular.Size = new Size(450, 412);
            dataGridViewRandevular.TabIndex = 3;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(223, 118);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridViewRandevular);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 612);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(336, 27);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 0;
            label2.Text = "Tarih";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(86, 27);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Doktor";
            // 
            // RandevuListeleVeSil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 636);
            Controls.Add(btnSil);
            Controls.Add(btnListele);
            Controls.Add(dateTimePickerTarih);
            Controls.Add(comboBoxDoktor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RandevuListeleVeSil";
            Text = "RandevuListeleVeSil";
            Load += RandevuListeleVeSil_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRandevular).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxDoktor;
        private DateTimePicker dateTimePickerTarih;
        private Button btnListele;
        private DataGridView dataGridViewRandevular;
        private Button btnSil;
        private Panel panel1;
        private Label label2;
        private Label label1;
    }
}