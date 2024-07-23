namespace cinemaximum1
{
    partial class filmListesi
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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnFilm = new System.Windows.Forms.Button();
            this.pBResim = new System.Windows.Forms.PictureBox();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.lblIdNo = new System.Windows.Forms.Label();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBResim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblIdNo);
            this.groupBox9.Controls.Add(this.lblFilmAdi);
            this.groupBox9.Controls.Add(this.btnFilm);
            this.groupBox9.Controls.Add(this.pBResim);
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox9.ForeColor = System.Drawing.Color.Orange;
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(113, 186);
            this.groupBox9.TabIndex = 17;
            this.groupBox9.TabStop = false;
            // 
            // btnFilm
            // 
            this.btnFilm.BackColor = System.Drawing.Color.Peru;
            this.btnFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilm.ForeColor = System.Drawing.Color.White;
            this.btnFilm.Location = new System.Drawing.Point(1, 150);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(106, 33);
            this.btnFilm.TabIndex = 6;
            this.btnFilm.Text = "DETAY";
            this.btnFilm.UseVisualStyleBackColor = false;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // pBResim
            // 
            this.pBResim.Image = global::cinemaximum1.Properties.Resources.NOPİC;
            this.pBResim.Location = new System.Drawing.Point(6, 24);
            this.pBResim.Name = "pBResim";
            this.pBResim.Size = new System.Drawing.Size(99, 120);
            this.pBResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBResim.TabIndex = 5;
            this.pBResim.TabStop = false;
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Location = new System.Drawing.Point(29, 0);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(51, 21);
            this.lblFilmAdi.TabIndex = 7;
            this.lblFilmAdi.Text = "label1";
            // 
            // lblIdNo
            // 
            this.lblIdNo.AutoSize = true;
            this.lblIdNo.Location = new System.Drawing.Point(6, 123);
            this.lblIdNo.Name = "lblIdNo";
            this.lblIdNo.Size = new System.Drawing.Size(51, 21);
            this.lblIdNo.TabIndex = 8;
            this.lblIdNo.Text = "label1";
            // 
            // filmListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox9);
            this.Name = "filmListesi";
            this.Size = new System.Drawing.Size(123, 196);
            this.Load += new System.EventHandler(this.filmListesi_Load);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnFilm;
        public System.Windows.Forms.Label lblFilmAdi;
        public System.Windows.Forms.PictureBox pBResim;
        public System.Windows.Forms.Label lblIdNo;
    }
}
