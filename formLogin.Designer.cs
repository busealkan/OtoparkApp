namespace H5190059_BuseAlkan
{
    partial class formLogin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.checkBox_BeniHatirla = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_Cikis = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Message = new System.Windows.Forms.Label();
            this.linkLabel_SifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.button_Giris = new System.Windows.Forms.Button();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.txt_KAdiEamil = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_BeniHatirla
            // 
            this.checkBox_BeniHatirla.AutoSize = true;
            this.checkBox_BeniHatirla.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_BeniHatirla.ForeColor = System.Drawing.Color.White;
            this.checkBox_BeniHatirla.Location = new System.Drawing.Point(197, 277);
            this.checkBox_BeniHatirla.Name = "checkBox_BeniHatirla";
            this.checkBox_BeniHatirla.Size = new System.Drawing.Size(137, 23);
            this.checkBox_BeniHatirla.TabIndex = 3;
            this.checkBox_BeniHatirla.Text = "Beni Hatırla ?";
            this.checkBox_BeniHatirla.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(164, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(212, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 108;
            this.pictureBox3.TabStop = false;
            // 
            // label_Cikis
            // 
            this.label_Cikis.AutoSize = true;
            this.label_Cikis.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Cikis.ForeColor = System.Drawing.Color.White;
            this.label_Cikis.Location = new System.Drawing.Point(466, 9);
            this.label_Cikis.Name = "label_Cikis";
            this.label_Cikis.Size = new System.Drawing.Size(34, 34);
            this.label_Cikis.TabIndex = 104;
            this.label_Cikis.Text = "X";
            this.label_Cikis.Click += new System.EventHandler(this.label_Cikis_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(111, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 106;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Message.ForeColor = System.Drawing.Color.Red;
            this.label_Message.Location = new System.Drawing.Point(22, 393);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(134, 19);
            this.label_Message.TabIndex = 111;
            this.label_Message.Text = "label_Message";
            // 
            // linkLabel_SifremiUnuttum
            // 
            this.linkLabel_SifremiUnuttum.AutoSize = true;
            this.linkLabel_SifremiUnuttum.LinkColor = System.Drawing.Color.White;
            this.linkLabel_SifremiUnuttum.Location = new System.Drawing.Point(205, 362);
            this.linkLabel_SifremiUnuttum.Name = "linkLabel_SifremiUnuttum";
            this.linkLabel_SifremiUnuttum.Size = new System.Drawing.Size(116, 17);
            this.linkLabel_SifremiUnuttum.TabIndex = 5;
            this.linkLabel_SifremiUnuttum.TabStop = true;
            this.linkLabel_SifremiUnuttum.Text = "Şifremi Unutum ?";
            this.linkLabel_SifremiUnuttum.Click += new System.EventHandler(this.linkLabel_SifremiUnuttum_Click);
            // 
            // button_Giris
            // 
            this.button_Giris.BackColor = System.Drawing.Color.White;
            this.button_Giris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Giris.FlatAppearance.BorderSize = 0;
            this.button_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Giris.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Giris.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Giris.Location = new System.Drawing.Point(164, 315);
            this.button_Giris.Name = "button_Giris";
            this.button_Giris.Size = new System.Drawing.Size(212, 33);
            this.button_Giris.TabIndex = 4;
            this.button_Giris.Text = "Giriş";
            this.button_Giris.UseVisualStyleBackColor = false;
            this.button_Giris.Click += new System.EventHandler(this.button_Giris_Click);
            // 
            // txt_Parola
            // 
            this.txt_Parola.Location = new System.Drawing.Point(164, 237);
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.PasswordChar = '*';
            this.txt_Parola.Size = new System.Drawing.Size(212, 22);
            this.txt_Parola.TabIndex = 2;
            this.txt_Parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_KAdiEamil
            // 
            this.txt_KAdiEamil.Location = new System.Drawing.Point(164, 182);
            this.txt_KAdiEamil.Name = "txt_KAdiEamil";
            this.txt_KAdiEamil.Size = new System.Drawing.Size(212, 22);
            this.txt_KAdiEamil.TabIndex = 1;
            this.txt_KAdiEamil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_KAdiEamil.Click += new System.EventHandler(this.txt_KAdiEamil_TextChanged);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(512, 436);
            this.Controls.Add(this.checkBox_BeniHatirla);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label_Cikis);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.linkLabel_SifremiUnuttum);
            this.Controls.Add(this.button_Giris);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.txt_KAdiEamil);
            this.Name = "formLogin";
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_BeniHatirla;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_Cikis;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.LinkLabel linkLabel_SifremiUnuttum;
        private System.Windows.Forms.Button button_Giris;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.TextBox txt_KAdiEamil;
    }
}

