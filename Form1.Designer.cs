namespace Hastane_Randevu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            doktorButton = new Button();
            button3 = new Button();
            button2 = new Button();
            hastaButton = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            mainpanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(doktorButton);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(hastaButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 45);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 636);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Logo_of_Ministry_of_Health__Turkey_;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(0, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 172);
            panel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LimeGreen;
            label2.Font = new Font("Segoe UI", 22F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(5, 192);
            label2.Name = "label2";
            label2.Size = new Size(267, 41);
            label2.TabIndex = 3;
            label2.Text = "RANDEVU SİSTEMİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LimeGreen;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(32, 413);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 3;
            label1.Text = "KAYIT İŞLEMLERİ";
            // 
            // doktorButton
            // 
            doktorButton.BackColor = Color.LimeGreen;
            doktorButton.Font = new Font("Segoe UI", 15F);
            doktorButton.Location = new Point(68, 515);
            doktorButton.Margin = new Padding(3, 2, 3, 2);
            doktorButton.Name = "doktorButton";
            doktorButton.Size = new Size(136, 42);
            doktorButton.TabIndex = 2;
            doktorButton.Text = "DOKTOR";
            doktorButton.UseVisualStyleBackColor = false;
            doktorButton.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LimeGreen;
            button3.Font = new Font("Segoe UI", 15F);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(47, 290);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(169, 71);
            button3.TabIndex = 2;
            button3.Text = "RANDEVULARI GÖRÜNTÜLE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Font = new Font("Segoe UI", 15F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(47, 244);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(169, 42);
            button2.TabIndex = 2;
            button2.Text = "RANDEVU AL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // hastaButton
            // 
            hastaButton.BackColor = Color.LimeGreen;
            hastaButton.Font = new Font("Segoe UI", 15F);
            hastaButton.ForeColor = Color.Black;
            hastaButton.Location = new Point(68, 469);
            hastaButton.Margin = new Padding(3, 2, 3, 2);
            hastaButton.Name = "hastaButton";
            hastaButton.Size = new Size(136, 42);
            hastaButton.TabIndex = 2;
            hastaButton.Text = "HASTA";
            hastaButton.UseVisualStyleBackColor = false;
            hastaButton.Click += hastaButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 45);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(278, 45);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(986, 636);
            panel4.TabIndex = 2;
            // 
            // mainpanel
            // 
            mainpanel.Location = new Point(278, 45);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(986, 636);
            mainpanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Controls.Add(mainpanel);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hastane Randevu Sistemi";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button hastaButton;
        private Button doktorButton;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Panel mainpanel;
        private Label label2;
        private Button button3;
        private Button button2;
    }
}
