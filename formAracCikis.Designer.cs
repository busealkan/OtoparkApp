namespace H5190059_BuseAlkan
{
    partial class formAracCikis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_AracCikisYap = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_ToplamSaat = new System.Windows.Forms.Label();
            this.label_Message = new System.Windows.Forms.Label();
            this.label_ToplamUcret = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Plaka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_AracCikisYap);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.textBox_Plaka);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 341);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // button_AracCikisYap
            // 
            this.button_AracCikisYap.BackColor = System.Drawing.Color.White;
            this.button_AracCikisYap.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_AracCikisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AracCikisYap.ImageIndex = 0;
            this.button_AracCikisYap.Location = new System.Drawing.Point(114, 94);
            this.button_AracCikisYap.Name = "button_AracCikisYap";
            this.button_AracCikisYap.Size = new System.Drawing.Size(260, 33);
            this.button_AracCikisYap.TabIndex = 3;
            this.button_AracCikisYap.Text = "Araç Çıkış Yap";
            this.button_AracCikisYap.UseVisualStyleBackColor = false;
            this.button_AracCikisYap.Click += new System.EventHandler(this.button_AracCikisYap_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_ToplamSaat);
            this.groupBox3.Controls.Add(this.label_Message);
            this.groupBox3.Controls.Add(this.label_ToplamUcret);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Location = new System.Drawing.Point(3, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 174);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // label_ToplamSaat
            // 
            this.label_ToplamSaat.AutoSize = true;
            this.label_ToplamSaat.Location = new System.Drawing.Point(208, 89);
            this.label_ToplamSaat.Name = "label_ToplamSaat";
            this.label_ToplamSaat.Size = new System.Drawing.Size(59, 20);
            this.label_ToplamSaat.TabIndex = 7;
            this.label_ToplamSaat.Text = "label8";
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Message.ForeColor = System.Drawing.Color.Red;
            this.label_Message.Location = new System.Drawing.Point(16, 128);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(157, 23);
            this.label_Message.TabIndex = 4;
            this.label_Message.Text = "label_Message";
            // 
            // label_ToplamUcret
            // 
            this.label_ToplamUcret.AutoSize = true;
            this.label_ToplamUcret.Location = new System.Drawing.Point(208, 48);
            this.label_ToplamUcret.Name = "label_ToplamUcret";
            this.label_ToplamUcret.Size = new System.Drawing.Size(59, 20);
            this.label_ToplamUcret.TabIndex = 6;
            this.label_ToplamUcret.Text = "label7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Toplam Ücret:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Toplam Park Saati:";
            // 
            // textBox_Plaka
            // 
            this.textBox_Plaka.Location = new System.Drawing.Point(114, 41);
            this.textBox_Plaka.Name = "textBox_Plaka";
            this.textBox_Plaka.Size = new System.Drawing.Size(260, 22);
            this.textBox_Plaka.TabIndex = 1;
            this.textBox_Plaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Plaka.TextChanged += new System.EventHandler(this.textBox_Plaka_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Plaka";
            // 
            // formAracCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(406, 341);
            this.Controls.Add(this.groupBox1);
            this.Name = "formAracCikis";
            this.Text = "Araç Çıkış";
            this.Load += new System.EventHandler(this.formAracCikis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Plaka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_AracCikisYap;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Label label_ToplamSaat;
        private System.Windows.Forms.Label label_ToplamUcret;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}