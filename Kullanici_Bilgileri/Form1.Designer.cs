namespace Kullanici_Bilgileri
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGsm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdYok = new System.Windows.Forms.RadioButton();
            this.rdSehitYakini = new System.Windows.Forms.RadioButton();
            this.rdGazi = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rdIstiyorum = new System.Windows.Forms.RadioButton();
            this.rdIstemiyorum = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdEvet = new System.Windows.Forms.RadioButton();
            this.rdHayir = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdKonusmaGuclugu = new System.Windows.Forms.RadioButton();
            this.rdIsitme = new System.Windows.Forms.RadioButton();
            this.rdSuregen = new System.Windows.Forms.RadioButton();
            this.rdGorme = new System.Windows.Forms.RadioButton();
            this.rdEngelyok = new System.Windows.Forms.RadioButton();
            this.rdOrtopedik = new System.Windows.Forms.RadioButton();
            this.cmbCalisma = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEgitim = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdGaziYakini = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.listBilgiler = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C. No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(357, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(753, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyad";
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTc.Location = new System.Drawing.Point(117, 65);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(150, 28);
            this.txtTc.TabIndex = 4;
            this.txtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadece_sati_girisi);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(450, 65);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(197, 30);
            this.txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(846, 65);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(227, 30);
            this.txtSoyad.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(45, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1099, 124);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGsm);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(45, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1099, 124);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İletişim Bilgileri";
            // 
            // txtGsm
            // 
            this.txtGsm.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGsm.Location = new System.Drawing.Point(157, 65);
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Size = new System.Drawing.Size(202, 30);
            this.txtGsm.TabIndex = 4;
            this.txtGsm.Text = "___ ___-__-__";
            this.txtGsm.Click += new System.EventHandler(this.clean);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gsm Numarası";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(623, 65);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(337, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(526, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "E-Mail";
            // 
            // rdYok
            // 
            this.rdYok.AutoSize = true;
            this.rdYok.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdYok.Location = new System.Drawing.Point(16, 21);
            this.rdYok.Name = "rdYok";
            this.rdYok.Size = new System.Drawing.Size(51, 21);
            this.rdYok.TabIndex = 9;
            this.rdYok.TabStop = true;
            this.rdYok.Text = "Yok";
            this.rdYok.UseVisualStyleBackColor = true;
            // 
            // rdSehitYakini
            // 
            this.rdSehitYakini.AutoSize = true;
            this.rdSehitYakini.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSehitYakini.Location = new System.Drawing.Point(73, 21);
            this.rdSehitYakini.Name = "rdSehitYakini";
            this.rdSehitYakini.Size = new System.Drawing.Size(98, 21);
            this.rdSehitYakini.TabIndex = 10;
            this.rdSehitYakini.TabStop = true;
            this.rdSehitYakini.Text = "Şehit Yakını";
            this.rdSehitYakini.UseVisualStyleBackColor = true;
            // 
            // rdGazi
            // 
            this.rdGazi.AutoSize = true;
            this.rdGazi.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGazi.Location = new System.Drawing.Point(185, 21);
            this.rdGazi.Name = "rdGazi";
            this.rdGazi.Size = new System.Drawing.Size(54, 21);
            this.rdGazi.TabIndex = 11;
            this.rdGazi.TabStop = true;
            this.rdGazi.Text = "Gazi";
            this.rdGazi.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cmbSehir);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtMeslek);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.cmbCalisma);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbEgitim);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(45, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1099, 468);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox7.Controls.Add(this.rdIstiyorum);
            this.groupBox7.Controls.Add(this.rdIstemiyorum);
            this.groupBox7.Location = new System.Drawing.Point(16, 401);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(305, 46);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            // 
            // rdIstiyorum
            // 
            this.rdIstiyorum.AutoSize = true;
            this.rdIstiyorum.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIstiyorum.Location = new System.Drawing.Point(11, 16);
            this.rdIstiyorum.Name = "rdIstiyorum";
            this.rdIstiyorum.Size = new System.Drawing.Size(119, 21);
            this.rdIstiyorum.TabIndex = 9;
            this.rdIstiyorum.TabStop = true;
            this.rdIstiyorum.Text = "Evet, istiyorum";
            this.rdIstiyorum.UseVisualStyleBackColor = true;
            // 
            // rdIstemiyorum
            // 
            this.rdIstemiyorum.AutoSize = true;
            this.rdIstemiyorum.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIstemiyorum.Location = new System.Drawing.Point(149, 16);
            this.rdIstemiyorum.Name = "rdIstemiyorum";
            this.rdIstemiyorum.Size = new System.Drawing.Size(143, 21);
            this.rdIstemiyorum.TabIndex = 10;
            this.rdIstemiyorum.TabStop = true;
            this.rdIstemiyorum.Text = "Hayır, istemiyorum";
            this.rdIstemiyorum.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(666, 358);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(234, 20);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "İBB Bölgesel İstihdam Ofisleri";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(12, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(655, 40);
            this.label14.TabIndex = 26;
            this.label14.Text = "Ücretsiz kariyer danışmanlığı hizmeti almak ve özel sektör iş fırsatları için bil" +
    "gilerinizin \r\nile paylaşılmasını ister misiniz?";
            // 
            // cmbSehir
            // 
            this.cmbSehir.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman ",
            "Diyarbakır",
            "Elazığ",
            "Gaziantep",
            "Hatay",
            "Kahramanmaraş",
            "Kilis",
            "Malatya ",
            "Osmaiye",
            "Şanlıurfa"});
            this.cmbSehir.Location = new System.Drawing.Point(837, 294);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(192, 27);
            this.cmbSehir.TabIndex = 24;
            this.cmbSehir.Text = "Etkilendiğiniz ili seçiniz";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox6.Controls.Add(this.rdEvet);
            this.groupBox6.Controls.Add(this.rdHayir);
            this.groupBox6.Location = new System.Drawing.Point(649, 281);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(141, 47);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            // 
            // rdEvet
            // 
            this.rdEvet.AutoSize = true;
            this.rdEvet.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEvet.Location = new System.Drawing.Point(12, 15);
            this.rdEvet.Name = "rdEvet";
            this.rdEvet.Size = new System.Drawing.Size(55, 21);
            this.rdEvet.TabIndex = 9;
            this.rdEvet.TabStop = true;
            this.rdEvet.Text = "Evet";
            this.rdEvet.UseVisualStyleBackColor = true;
            // 
            // rdHayir
            // 
            this.rdHayir.AutoSize = true;
            this.rdHayir.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHayir.Location = new System.Drawing.Point(75, 15);
            this.rdHayir.Name = "rdHayir";
            this.rdHayir.Size = new System.Drawing.Size(61, 21);
            this.rdHayir.TabIndex = 10;
            this.rdHayir.TabStop = true;
            this.rdHayir.Text = "Hayır";
            this.rdHayir.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(12, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(564, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Şubat 2023\'te gerçekleşen depremlerin etkilediği bir ilden mi geliyorsunuz?";
            // 
            // txtMeslek
            // 
            this.txtMeslek.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMeslek.Location = new System.Drawing.Point(623, 127);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(356, 25);
            this.txtMeslek.TabIndex = 7;
            this.txtMeslek.Text = "Mesleğiniz";
            this.txtMeslek.Click += new System.EventHandler(this.clean2);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(12, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Şehit / Gazi Bilgisi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(461, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mesleğiniz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(461, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Engel Durumu";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Controls.Add(this.rdKonusmaGuclugu);
            this.groupBox5.Controls.Add(this.rdIsitme);
            this.groupBox5.Controls.Add(this.rdSuregen);
            this.groupBox5.Controls.Add(this.rdGorme);
            this.groupBox5.Controls.Add(this.rdEngelyok);
            this.groupBox5.Controls.Add(this.rdOrtopedik);
            this.groupBox5.Location = new System.Drawing.Point(623, 32);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(382, 79);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // rdKonusmaGuclugu
            // 
            this.rdKonusmaGuclugu.AutoSize = true;
            this.rdKonusmaGuclugu.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdKonusmaGuclugu.Location = new System.Drawing.Point(214, 44);
            this.rdKonusmaGuclugu.Name = "rdKonusmaGuclugu";
            this.rdKonusmaGuclugu.Size = new System.Drawing.Size(140, 21);
            this.rdKonusmaGuclugu.TabIndex = 15;
            this.rdKonusmaGuclugu.TabStop = true;
            this.rdKonusmaGuclugu.Text = "Konuşma Güçlüğü";
            this.rdKonusmaGuclugu.UseVisualStyleBackColor = true;
            // 
            // rdIsitme
            // 
            this.rdIsitme.AutoSize = true;
            this.rdIsitme.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdIsitme.Location = new System.Drawing.Point(15, 43);
            this.rdIsitme.Name = "rdIsitme";
            this.rdIsitme.Size = new System.Drawing.Size(66, 21);
            this.rdIsitme.TabIndex = 13;
            this.rdIsitme.TabStop = true;
            this.rdIsitme.Text = "İşitme";
            this.rdIsitme.UseVisualStyleBackColor = true;
            // 
            // rdSuregen
            // 
            this.rdSuregen.AutoSize = true;
            this.rdSuregen.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdSuregen.Location = new System.Drawing.Point(117, 44);
            this.rdSuregen.Name = "rdSuregen";
            this.rdSuregen.Size = new System.Drawing.Size(79, 21);
            this.rdSuregen.TabIndex = 14;
            this.rdSuregen.TabStop = true;
            this.rdSuregen.Text = "Süreğen";
            this.rdSuregen.UseVisualStyleBackColor = true;
            // 
            // rdGorme
            // 
            this.rdGorme.AutoSize = true;
            this.rdGorme.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdGorme.Location = new System.Drawing.Point(214, 17);
            this.rdGorme.Name = "rdGorme";
            this.rdGorme.Size = new System.Drawing.Size(70, 21);
            this.rdGorme.TabIndex = 12;
            this.rdGorme.TabStop = true;
            this.rdGorme.Text = "Görme";
            this.rdGorme.UseVisualStyleBackColor = true;
            // 
            // rdEngelyok
            // 
            this.rdEngelyok.AutoSize = true;
            this.rdEngelyok.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdEngelyok.Location = new System.Drawing.Point(15, 16);
            this.rdEngelyok.Name = "rdEngelyok";
            this.rdEngelyok.Size = new System.Drawing.Size(88, 21);
            this.rdEngelyok.TabIndex = 9;
            this.rdEngelyok.TabStop = true;
            this.rdEngelyok.Text = "Engel Yok";
            this.rdEngelyok.UseVisualStyleBackColor = true;
            // 
            // rdOrtopedik
            // 
            this.rdOrtopedik.AutoSize = true;
            this.rdOrtopedik.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdOrtopedik.Location = new System.Drawing.Point(117, 17);
            this.rdOrtopedik.Name = "rdOrtopedik";
            this.rdOrtopedik.Size = new System.Drawing.Size(90, 21);
            this.rdOrtopedik.TabIndex = 10;
            this.rdOrtopedik.TabStop = true;
            this.rdOrtopedik.Text = "Ortopedik";
            this.rdOrtopedik.UseVisualStyleBackColor = true;
            // 
            // cmbCalisma
            // 
            this.cmbCalisma.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCalisma.FormattingEnabled = true;
            this.cmbCalisma.Items.AddRange(new object[] {
            "Çalışıyor ",
            "Çalışmıyor",
            "Öğrenci",
            "Emekli"});
            this.cmbCalisma.Location = new System.Drawing.Point(204, 128);
            this.cmbCalisma.Name = "cmbCalisma";
            this.cmbCalisma.Size = new System.Drawing.Size(192, 27);
            this.cmbCalisma.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Çalışma Durumu";
            // 
            // cmbEgitim
            // 
            this.cmbEgitim.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbEgitim.FormattingEnabled = true;
            this.cmbEgitim.Items.AddRange(new object[] {
            "Okuma Yazma Bilmiyorum",
            "Okur Yazar",
            "İlkokul",
            "İlköğretim",
            "Lise",
            "Meslek Lisesi",
            "Önlisans",
            "Lisans",
            "Yüksek Lisans",
            "Doktora"});
            this.cmbEgitim.Location = new System.Drawing.Point(204, 53);
            this.cmbEgitim.Name = "cmbEgitim";
            this.cmbEgitim.Size = new System.Drawing.Size(192, 27);
            this.cmbEgitim.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Eğitim Durumu";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.rdGaziYakini);
            this.groupBox4.Controls.Add(this.rdYok);
            this.groupBox4.Controls.Add(this.rdSehitYakini);
            this.groupBox4.Controls.Add(this.rdGazi);
            this.groupBox4.Location = new System.Drawing.Point(204, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(356, 63);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // rdGaziYakini
            // 
            this.rdGaziYakini.AutoSize = true;
            this.rdGaziYakini.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGaziYakini.Location = new System.Drawing.Point(249, 21);
            this.rdGaziYakini.Name = "rdGaziYakini";
            this.rdGaziYakini.Size = new System.Drawing.Size(93, 21);
            this.rdGaziYakini.TabIndex = 12;
            this.rdGaziYakini.TabStop = true;
            this.rdGaziYakini.Text = "Gazi Yakını";
            this.rdGaziYakini.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 36);
            this.label6.TabIndex = 13;
            this.label6.Text = "Diğer Bilgiler";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(929, 792);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(215, 49);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Bilgileri Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBilgiler
            // 
            this.listBilgiler.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBilgiler.FormattingEnabled = true;
            this.listBilgiler.ItemHeight = 20;
            this.listBilgiler.Location = new System.Drawing.Point(1172, 39);
            this.listBilgiler.Name = "listBilgiler";
            this.listBilgiler.Size = new System.Drawing.Size(400, 344);
            this.listBilgiler.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1692, 1052);
            this.Controls.Add(this.listBilgiler);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Kayıt Formu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGsm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdGazi;
        private System.Windows.Forms.RadioButton rdSehitYakini;
        private System.Windows.Forms.RadioButton rdYok;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdGaziYakini;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEgitim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdKonusmaGuclugu;
        private System.Windows.Forms.RadioButton rdIsitme;
        private System.Windows.Forms.RadioButton rdSuregen;
        private System.Windows.Forms.RadioButton rdGorme;
        private System.Windows.Forms.RadioButton rdEngelyok;
        private System.Windows.Forms.RadioButton rdOrtopedik;
        private System.Windows.Forms.ComboBox cmbCalisma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rdIstiyorum;
        private System.Windows.Forms.RadioButton rdIstemiyorum;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rdEvet;
        private System.Windows.Forms.RadioButton rdHayir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox listBilgiler;
    }
}

