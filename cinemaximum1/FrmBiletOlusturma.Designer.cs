namespace cinemaximum1
{
    partial class FrmBiletOlusturma
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbFilmAdi = new System.Windows.Forms.ComboBox();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbTarih = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblSeansSec = new System.Windows.Forms.Label();
            this.panelSeans = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.koltukSayisi = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.cbSalon = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.koltukPaneli = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gelenKoltuk = new System.Windows.Forms.Label();
            this.listeGelenKoltuk = new System.Windows.Forms.ListBox();
            this.listeBelirlenen = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 40);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(916, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "[BİLET OLUŞTURMA EKRANI]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 51);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AD SOYAD";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdSoyad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtAdSoyad.ForeColor = System.Drawing.Color.Orange;
            this.txtAdSoyad.Location = new System.Drawing.Point(3, 26);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(256, 22);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBarkod);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Orange;
            this.groupBox2.Location = new System.Drawing.Point(12, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 51);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BİLET NO";
            // 
            // txtBarkod
            // 
            this.txtBarkod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarkod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBarkod.ForeColor = System.Drawing.Color.Orange;
            this.txtBarkod.Location = new System.Drawing.Point(3, 26);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(256, 22);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbFilmAdi);
            this.groupBox3.Controls.Add(this.txtFilmAdi);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Orange;
            this.groupBox3.Location = new System.Drawing.Point(12, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 51);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FİLM ADI";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cbFilmAdi
            // 
            this.cbFilmAdi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbFilmAdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbFilmAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilmAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFilmAdi.FormattingEnabled = true;
            this.cbFilmAdi.Location = new System.Drawing.Point(3, 25);
            this.cbFilmAdi.Name = "cbFilmAdi";
            this.cbFilmAdi.Size = new System.Drawing.Size(254, 21);
            this.cbFilmAdi.TabIndex = 1;
            this.cbFilmAdi.SelectedIndexChanged += new System.EventHandler(this.cbFilmAdi_SelectedIndexChanged);
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilmAdi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtFilmAdi.ForeColor = System.Drawing.Color.Orange;
            this.txtFilmAdi.Location = new System.Drawing.Point(3, 26);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(254, 22);
            this.txtFilmAdi.TabIndex = 0;
            this.txtFilmAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbTarih);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.Orange;
            this.groupBox4.Location = new System.Drawing.Point(11, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 51);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TARİH";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // cbTarih
            // 
            this.cbTarih.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTarih.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbTarih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTarih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTarih.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTarih.FormattingEnabled = true;
            this.cbTarih.Location = new System.Drawing.Point(3, 27);
            this.cbTarih.Name = "cbTarih";
            this.cbTarih.Size = new System.Drawing.Size(256, 21);
            this.cbTarih.TabIndex = 3;
            this.cbTarih.SelectedIndexChanged += new System.EventHandler(this.cbTarih_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblSeansSec);
            this.groupBox5.Controls.Add(this.panelSeans);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.Color.Orange;
            this.groupBox5.Location = new System.Drawing.Point(11, 242);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(262, 51);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SEANS";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // lblSeansSec
            // 
            this.lblSeansSec.AutoSize = true;
            this.lblSeansSec.Location = new System.Drawing.Point(200, 1);
            this.lblSeansSec.Name = "lblSeansSec";
            this.lblSeansSec.Size = new System.Drawing.Size(45, 21);
            this.lblSeansSec.TabIndex = 17;
            this.lblSeansSec.Text = "label";
            this.lblSeansSec.Visible = false;
            // 
            // panelSeans
            // 
            this.panelSeans.AutoScroll = true;
            this.panelSeans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSeans.Location = new System.Drawing.Point(3, 25);
            this.panelSeans.Name = "panelSeans";
            this.panelSeans.Size = new System.Drawing.Size(256, 23);
            this.panelSeans.TabIndex = 17;
            this.panelSeans.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSeans_Paint);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.koltukSayisi);
            this.groupBox6.Controls.Add(this.comboBox4);
            this.groupBox6.Controls.Add(this.cbSalon);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.Color.Orange;
            this.groupBox6.Location = new System.Drawing.Point(13, 295);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(261, 51);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SALON";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // koltukSayisi
            // 
            this.koltukSayisi.AutoSize = true;
            this.koltukSayisi.Location = new System.Drawing.Point(198, -2);
            this.koltukSayisi.Name = "koltukSayisi";
            this.koltukSayisi.Size = new System.Drawing.Size(45, 21);
            this.koltukSayisi.TabIndex = 18;
            this.koltukSayisi.Text = "label";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(3, 25);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(255, 21);
            this.comboBox4.TabIndex = 1;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cbSalon
            // 
            this.cbSalon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbSalon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbSalon.ForeColor = System.Drawing.Color.Orange;
            this.cbSalon.Location = new System.Drawing.Point(3, 26);
            this.cbSalon.Name = "cbSalon";
            this.cbSalon.Size = new System.Drawing.Size(255, 22);
            this.cbSalon.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.ForeColor = System.Drawing.Color.Orange;
            this.groupBox7.Location = new System.Drawing.Point(13, 352);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(261, 51);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "SEÇİLEN KOLTUK";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.ForeColor = System.Drawing.Color.Orange;
            this.textBox2.Location = new System.Drawing.Point(3, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 22);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Peru;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(276, 46);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(32, 361);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(554, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "PERDE";
            // 
            // koltukPaneli
            // 
            this.koltukPaneli.AutoScroll = true;
            this.koltukPaneli.Location = new System.Drawing.Point(314, 120);
            this.koltukPaneli.Name = "koltukPaneli";
            this.koltukPaneli.Size = new System.Drawing.Size(565, 221);
            this.koltukPaneli.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::cinemaximum1.Properties.Resources.blue;
            this.pictureBox2.Location = new System.Drawing.Point(717, 347);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cinemaximum1.Properties.Resources.perde1;
            this.pictureBox1.Location = new System.Drawing.Point(314, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::cinemaximum1.Properties.Resources.red;
            this.pictureBox3.Location = new System.Drawing.Point(788, 347);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::cinemaximum1.Properties.Resources.orange;
            this.pictureBox4.Location = new System.Drawing.Point(866, 347);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(714, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "BOŞ KOLTUK";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(785, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "DOLU KOLTUK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(862, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "SEÇİLEN KOLTUK";
            // 
            // gelenKoltuk
            // 
            this.gelenKoltuk.AutoSize = true;
            this.gelenKoltuk.Location = new System.Drawing.Point(386, 352);
            this.gelenKoltuk.Name = "gelenKoltuk";
            this.gelenKoltuk.Size = new System.Drawing.Size(45, 21);
            this.gelenKoltuk.TabIndex = 26;
            this.gelenKoltuk.Text = "label";
            this.gelenKoltuk.Visible = false;
            // 
            // listeGelenKoltuk
            // 
            this.listeGelenKoltuk.FormattingEnabled = true;
            this.listeGelenKoltuk.ItemHeight = 21;
            this.listeGelenKoltuk.Location = new System.Drawing.Point(824, 120);
            this.listeGelenKoltuk.Name = "listeGelenKoltuk";
            this.listeGelenKoltuk.Size = new System.Drawing.Size(120, 88);
            this.listeGelenKoltuk.TabIndex = 27;
            this.listeGelenKoltuk.Visible = false;
            // 
            // listeBelirlenen
            // 
            this.listeBelirlenen.FormattingEnabled = true;
            this.listeBelirlenen.ItemHeight = 21;
            this.listeBelirlenen.Location = new System.Drawing.Point(824, 214);
            this.listeBelirlenen.Name = "listeBelirlenen";
            this.listeBelirlenen.Size = new System.Drawing.Size(120, 88);
            this.listeBelirlenen.TabIndex = 28;
            this.listeBelirlenen.Visible = false;
            this.listeBelirlenen.SelectedIndexChanged += new System.EventHandler(this.listeBelirlenen_SelectedIndexChanged);
            // 
            // FrmBiletOlusturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 412);
            this.Controls.Add(this.listeGelenKoltuk);
            this.Controls.Add(this.listeBelirlenen);
            this.Controls.Add(this.gelenKoltuk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.koltukPaneli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 100);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBiletOlusturma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmBiletOlusturma";
            this.Load += new System.EventHandler(this.FrmBiletOlusturma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.ComboBox cbFilmAdi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox cbSalon;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cbTarih;
        private System.Windows.Forms.FlowLayoutPanel panelSeans;
        public System.Windows.Forms.Label lblSeansSec;
        public System.Windows.Forms.Label koltukSayisi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel koltukPaneli;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label gelenKoltuk;
        private System.Windows.Forms.ListBox listeGelenKoltuk;
        private System.Windows.Forms.ListBox listeBelirlenen;
    }
}