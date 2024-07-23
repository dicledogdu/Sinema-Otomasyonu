namespace cinemaximum1
{
    partial class yonetmenListesi
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pBresimDetay = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnYukle = new System.Windows.Forms.Button();
            this.pBcinsiyet = new System.Windows.Forms.PictureBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBresimDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBcinsiyet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 59);
            this.panel1.TabIndex = 0;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Orange;
            this.lblAdSoyad.Location = new System.Drawing.Point(119, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(61, 25);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "label1";
            this.lblAdSoyad.Click += new System.EventHandler(this.lblAdSoyad_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.Orange;
            this.lblID.Location = new System.Drawing.Point(119, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 25);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "label1";
            this.lblID.Visible = false;
            // 
            // pBresimDetay
            // 
            this.pBresimDetay.Image = global::cinemaximum1.Properties.Resources.NOPİC;
            this.pBresimDetay.Location = new System.Drawing.Point(15, 0);
            this.pBresimDetay.Name = "pBresimDetay";
            this.pBresimDetay.Size = new System.Drawing.Size(64, 52);
            this.pBresimDetay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBresimDetay.TabIndex = 3;
            this.pBresimDetay.TabStop = false;
            this.pBresimDetay.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(27, 15);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnYukle
            // 
            this.btnYukle.BackColor = System.Drawing.Color.Peru;
            this.btnYukle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYukle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYukle.ForeColor = System.Drawing.Color.White;
            this.btnYukle.Location = new System.Drawing.Point(693, 20);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(143, 33);
            this.btnYukle.TabIndex = 6;
            this.btnYukle.Text = "DETAY";
            this.btnYukle.UseVisualStyleBackColor = false;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // pBcinsiyet
            // 
            this.pBcinsiyet.Image = global::cinemaximum1.Properties.Resources.ERKEK;
            this.pBcinsiyet.Location = new System.Drawing.Point(85, 4);
            this.pBcinsiyet.Name = "pBcinsiyet";
            this.pBcinsiyet.Size = new System.Drawing.Size(27, 21);
            this.pBcinsiyet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBcinsiyet.TabIndex = 7;
            this.pBcinsiyet.TabStop = false;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.ForeColor = System.Drawing.Color.Orange;
            this.lblCinsiyet.Location = new System.Drawing.Point(446, 17);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(61, 25);
            this.lblCinsiyet.TabIndex = 8;
            this.lblCinsiyet.Text = "label1";
            this.lblCinsiyet.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(852, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yonetmenListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 7F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.pBcinsiyet);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pBresimDetay);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "yonetmenListesi";
            this.Size = new System.Drawing.Size(952, 59);
            this.Load += new System.EventHandler(this.yonetmenListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBresimDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBcinsiyet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblAdSoyad;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.PictureBox pBresimDetay;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.PictureBox pBcinsiyet;
        public System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Button button1;
    }
}
