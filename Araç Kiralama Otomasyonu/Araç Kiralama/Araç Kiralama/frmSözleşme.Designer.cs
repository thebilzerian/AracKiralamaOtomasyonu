﻿namespace Araç_Kiralama
{
    partial class frmSözleşme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSözleşme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dateDönüş = new System.Windows.Forms.DateTimePicker();
            this.dateÇıkış = new System.Windows.Forms.DateTimePicker();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtGün = new System.Windows.Forms.TextBox();
            this.txtKiraÜcreti = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.comboKiraŞekli = new System.Windows.Forms.ComboBox();
            this.comboAraçlar = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAraçTeslim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtE_Yer = new System.Windows.Forms.TextBox();
            this.txtE_Tarih = new System.Windows.Forms.TextBox();
            this.txtE_No = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.lblE_Yer = new System.Windows.Forms.Label();
            this.lblE_Tarih = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(968, 314);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.btnGüncelle);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.dateDönüş);
            this.groupBox2.Controls.Add(this.dateÇıkış);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.txtGün);
            this.groupBox2.Controls.Add(this.txtKiraÜcreti);
            this.groupBox2.Controls.Add(this.txtRenk);
            this.groupBox2.Controls.Add(this.txtYil);
            this.groupBox2.Controls.Add(this.txtSeri);
            this.groupBox2.Controls.Add(this.txtMarka);
            this.groupBox2.Controls.Add(this.comboKiraŞekli);
            this.groupBox2.Controls.Add(this.comboAraçlar);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(332, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 327);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.White;
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.ImageIndex = 4;
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(395, 262);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(90, 54);
            this.btnTemizle.TabIndex = 25;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ekle.png");
            this.ımageList1.Images.SetKeyName(1, "güncelle1.png");
            this.ımageList1.Images.SetKeyName(2, "teslim.png");
            this.ımageList1.Images.SetKeyName(3, "hesapla.png");
            this.ımageList1.Images.SetKeyName(4, "temizle.png");
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.White;
            this.btnHesapla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapla.ImageIndex = 3;
            this.btnHesapla.ImageList = this.ımageList1;
            this.btnHesapla.Location = new System.Drawing.Point(541, 152);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(103, 54);
            this.btnHesapla.TabIndex = 24;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.White;
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.ImageIndex = 1;
            this.btnGüncelle.ImageList = this.ımageList1;
            this.btnGüncelle.Location = new System.Drawing.Point(174, 262);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(103, 54);
            this.btnGüncelle.TabIndex = 23;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 0;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(39, 262);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 54);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dateDönüş
            // 
            this.dateDönüş.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDönüş.Location = new System.Drawing.Point(395, 222);
            this.dateDönüş.Name = "dateDönüş";
            this.dateDönüş.Size = new System.Drawing.Size(125, 20);
            this.dateDönüş.TabIndex = 21;
            // 
            // dateÇıkış
            // 
            this.dateÇıkış.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateÇıkış.Location = new System.Drawing.Point(395, 185);
            this.dateÇıkış.Name = "dateÇıkış";
            this.dateÇıkış.Size = new System.Drawing.Size(125, 20);
            this.dateÇıkış.TabIndex = 20;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(395, 148);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(125, 20);
            this.txtTutar.TabIndex = 19;
            // 
            // txtGün
            // 
            this.txtGün.Location = new System.Drawing.Point(395, 111);
            this.txtGün.Name = "txtGün";
            this.txtGün.Size = new System.Drawing.Size(125, 20);
            this.txtGün.TabIndex = 18;
            // 
            // txtKiraÜcreti
            // 
            this.txtKiraÜcreti.Location = new System.Drawing.Point(395, 74);
            this.txtKiraÜcreti.Name = "txtKiraÜcreti";
            this.txtKiraÜcreti.Size = new System.Drawing.Size(125, 20);
            this.txtKiraÜcreti.TabIndex = 17;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(116, 207);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(125, 20);
            this.txtRenk.TabIndex = 16;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(116, 164);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(125, 20);
            this.txtYil.TabIndex = 15;
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(116, 121);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(125, 20);
            this.txtSeri.TabIndex = 14;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(116, 78);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(125, 20);
            this.txtMarka.TabIndex = 13;
            // 
            // comboKiraŞekli
            // 
            this.comboKiraŞekli.FormattingEnabled = true;
            this.comboKiraŞekli.Items.AddRange(new object[] {
            "Günlük",
            "Haftalık",
            "Aylık"});
            this.comboKiraŞekli.Location = new System.Drawing.Point(395, 36);
            this.comboKiraŞekli.Name = "comboKiraŞekli";
            this.comboKiraŞekli.Size = new System.Drawing.Size(125, 21);
            this.comboKiraŞekli.TabIndex = 12;
            this.comboKiraŞekli.SelectedIndexChanged += new System.EventHandler(this.txtKiraŞekli_SelectedIndexChanged);
            // 
            // comboAraçlar
            // 
            this.comboAraçlar.FormattingEnabled = true;
            this.comboAraçlar.Location = new System.Drawing.Point(116, 34);
            this.comboAraçlar.Name = "comboAraçlar";
            this.comboAraçlar.Size = new System.Drawing.Size(125, 21);
            this.comboAraçlar.TabIndex = 11;
            this.comboAraçlar.SelectedIndexChanged += new System.EventHandler(this.comboAraçlar_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(312, 229);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Dönüş Tarihi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(312, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Çıkış Tarihi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(312, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Tutar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(312, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Gün";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(312, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Kira Ücreti";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(312, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Kira Şekli";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Renk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Model(Yıl)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Seri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Araçlar";
            // 
            // btnAraçTeslim
            // 
            this.btnAraçTeslim.BackColor = System.Drawing.Color.White;
            this.btnAraçTeslim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAraçTeslim.ImageIndex = 2;
            this.btnAraçTeslim.ImageList = this.ımageList1;
            this.btnAraçTeslim.Location = new System.Drawing.Point(873, 685);
            this.btnAraçTeslim.Name = "btnAraçTeslim";
            this.btnAraçTeslim.Size = new System.Drawing.Size(128, 54);
            this.btnAraçTeslim.TabIndex = 24;
            this.btnAraçTeslim.Text = "Araç Teslim";
            this.btnAraçTeslim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAraçTeslim.UseVisualStyleBackColor = false;
            this.btnAraçTeslim.Click += new System.EventHandler(this.btnAraçTeslim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtTcAra);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtE_Yer);
            this.groupBox1.Controls.Add(this.txtE_Tarih);
            this.groupBox1.Controls.Add(this.txtE_No);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.lblE_Yer);
            this.groupBox1.Controls.Add(this.lblE_Tarih);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 327);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(6, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 16);
            this.label18.TabIndex = 13;
            this.label18.Text = "TC ARA";
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(135, 34);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(125, 20);
            this.txtTcAra.TabIndex = 12;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(135, 111);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(125, 20);
            this.txtAdSoyad.TabIndex = 11;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(135, 152);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(125, 20);
            this.txtTelefon.TabIndex = 10;
            // 
            // txtE_Yer
            // 
            this.txtE_Yer.Location = new System.Drawing.Point(135, 275);
            this.txtE_Yer.Name = "txtE_Yer";
            this.txtE_Yer.Size = new System.Drawing.Size(125, 20);
            this.txtE_Yer.TabIndex = 9;
            // 
            // txtE_Tarih
            // 
            this.txtE_Tarih.Location = new System.Drawing.Point(135, 234);
            this.txtE_Tarih.Name = "txtE_Tarih";
            this.txtE_Tarih.Size = new System.Drawing.Size(125, 20);
            this.txtE_Tarih.TabIndex = 8;
            // 
            // txtE_No
            // 
            this.txtE_No.Location = new System.Drawing.Point(135, 193);
            this.txtE_No.Name = "txtE_No";
            this.txtE_No.Size = new System.Drawing.Size(125, 20);
            this.txtE_No.TabIndex = 7;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(135, 70);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(125, 20);
            this.txtTc.TabIndex = 6;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // lblE_Yer
            // 
            this.lblE_Yer.AutoSize = true;
            this.lblE_Yer.Location = new System.Drawing.Point(6, 278);
            this.lblE_Yer.Name = "lblE_Yer";
            this.lblE_Yer.Size = new System.Drawing.Size(75, 13);
            this.lblE_Yer.TabIndex = 5;
            this.lblE_Yer.Text = "E. Verildiği Yer";
            // 
            // lblE_Tarih
            // 
            this.lblE_Tarih.AutoSize = true;
            this.lblE_Tarih.Location = new System.Drawing.Point(6, 237);
            this.lblE_Tarih.Name = "lblE_Tarih";
            this.lblE_Tarih.Size = new System.Drawing.Size(67, 13);
            this.lblE_Tarih.TabIndex = 4;
            this.lblE_Tarih.Text = "Ehliyet Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ehliyet No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(725, 703);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(125, 20);
            this.txtEkstra.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 706);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alacak/Verecek Durumu";
            // 
            // frmSözleşme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1083, 751);
            this.Controls.Add(this.txtEkstra);
            this.Controls.Add(this.btnAraçTeslim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSözleşme";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sözleşme Sayfası";
            this.Load += new System.EventHandler(this.frmSözleşme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAraçTeslim;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dateDönüş;
        private System.Windows.Forms.DateTimePicker dateÇıkış;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtGün;
        private System.Windows.Forms.TextBox txtKiraÜcreti;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.ComboBox comboKiraŞekli;
        private System.Windows.Forms.ComboBox comboAraçlar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtE_Yer;
        private System.Windows.Forms.TextBox txtE_Tarih;
        private System.Windows.Forms.TextBox txtE_No;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label lblE_Yer;
        private System.Windows.Forms.Label lblE_Tarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.TextBox txtEkstra;
        private System.Windows.Forms.Label label5;
    }
}