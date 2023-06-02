namespace Ucak_Savasi
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblsonuc_player = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblsonuc_yapay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.hedef_oyuncu = new System.Windows.Forms.Label();
            this.hedef_goruntu = new System.Windows.Forms.Label();
            this.can_player = new System.Windows.Forms.Label();
            this.can_yapay = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel_info = new System.Windows.Forms.Panel();
            this.kazanan = new System.Windows.Forms.Label();
            this.kazanilan_puan = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bomb = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.ulti = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.carpma = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.mermi = new System.Windows.Forms.PictureBox();
            this.bucak = new System.Windows.Forms.PictureBox();
            this.heart = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.ducak3 = new System.Windows.Forms.PictureBox();
            this.ducak2 = new System.Windows.Forms.PictureBox();
            this.ducak1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.ducak_yapay_3 = new System.Windows.Forms.PictureBox();
            this.ducak_yapay_2 = new System.Windows.Forms.PictureBox();
            this.ducak_yapay_1 = new System.Windows.Forms.PictureBox();
            this.ducak_mermi_yapay_3 = new System.Windows.Forms.PictureBox();
            this.ducak_mermi_yapay_2 = new System.Windows.Forms.PictureBox();
            this.ducak_mermi_yapay_1 = new System.Windows.Forms.PictureBox();
            this.carpma_yapay = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.bucak_goruntu = new System.Windows.Forms.PictureBox();
            this.mermi_yapay_ = new System.Windows.Forms.PictureBox();
            this.ducak_mermi_1 = new System.Windows.Forms.PictureBox();
            this.ducak_mermi_2 = new System.Windows.Forms.PictureBox();
            this.ducak_mermi_3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_yapay_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_yapay_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_yapay_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_mermi_yapay_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_mermi_yapay_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_mermi_yapay_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpma_yapay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucak_goruntu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi_yapay_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_mermi_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_mermi_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_mermi_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblsonuc_player
            // 
            this.lblsonuc_player.AutoSize = true;
            this.lblsonuc_player.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc_player.ForeColor = System.Drawing.Color.White;
            this.lblsonuc_player.Location = new System.Drawing.Point(950, 61);
            this.lblsonuc_player.Name = "lblsonuc_player";
            this.lblsonuc_player.Size = new System.Drawing.Size(79, 23);
            this.lblsonuc_player.TabIndex = 2;
            this.lblsonuc_player.Text = "Puan : 0";
            this.lblsonuc_player.Click += new System.EventHandler(this.lblsonuc_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(635, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 800);
            this.panel2.TabIndex = 10;
            // 
            // lblsonuc_yapay
            // 
            this.lblsonuc_yapay.AutoSize = true;
            this.lblsonuc_yapay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc_yapay.ForeColor = System.Drawing.Color.White;
            this.lblsonuc_yapay.Location = new System.Drawing.Point(225, 63);
            this.lblsonuc_yapay.Name = "lblsonuc_yapay";
            this.lblsonuc_yapay.Size = new System.Drawing.Size(79, 23);
            this.lblsonuc_yapay.TabIndex = 2;
            this.lblsonuc_yapay.Text = "Puan : 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(442, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Artificial Intelligence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(644, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Player";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(643, 24);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.RightToLeftLayout = true;
            this.progressBar1.Size = new System.Drawing.Size(402, 32);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Value = 100;
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.ForeColor = System.Drawing.Color.Red;
            this.progressBar2.Location = new System.Drawing.Point(225, 24);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar2.RightToLeftLayout = true;
            this.progressBar2.Size = new System.Drawing.Size(404, 32);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 24;
            this.progressBar2.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(323, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "label1";
            // 
            // hedef_oyuncu
            // 
            this.hedef_oyuncu.AutoSize = true;
            this.hedef_oyuncu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hedef_oyuncu.ForeColor = System.Drawing.Color.Snow;
            this.hedef_oyuncu.Location = new System.Drawing.Point(644, 1);
            this.hedef_oyuncu.Name = "hedef_oyuncu";
            this.hedef_oyuncu.Size = new System.Drawing.Size(142, 19);
            this.hedef_oyuncu.TabIndex = 27;
            this.hedef_oyuncu.Text = "Vurulan Uçak Sayısı : ";
            // 
            // hedef_goruntu
            // 
            this.hedef_goruntu.AutoSize = true;
            this.hedef_goruntu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hedef_goruntu.ForeColor = System.Drawing.Color.Snow;
            this.hedef_goruntu.Location = new System.Drawing.Point(221, 1);
            this.hedef_goruntu.Name = "hedef_goruntu";
            this.hedef_goruntu.Size = new System.Drawing.Size(142, 19);
            this.hedef_goruntu.TabIndex = 28;
            this.hedef_goruntu.Text = "Vurulan Uçak Sayısı : ";
            // 
            // can_player
            // 
            this.can_player.AutoSize = true;
            this.can_player.BackColor = System.Drawing.Color.Transparent;
            this.can_player.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.can_player.ForeColor = System.Drawing.Color.Transparent;
            this.can_player.Location = new System.Drawing.Point(979, -3);
            this.can_player.Name = "can_player";
            this.can_player.Size = new System.Drawing.Size(66, 23);
            this.can_player.TabIndex = 29;
            this.can_player.Text = "% 100";
            // 
            // can_yapay
            // 
            this.can_yapay.AutoSize = true;
            this.can_yapay.BackColor = System.Drawing.Color.Transparent;
            this.can_yapay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.can_yapay.ForeColor = System.Drawing.Color.Transparent;
            this.can_yapay.Location = new System.Drawing.Point(563, -3);
            this.can_yapay.Name = "can_yapay";
            this.can_yapay.Size = new System.Drawing.Size(66, 23);
            this.can_yapay.TabIndex = 30;
            this.can_yapay.Text = "% 100";
            // 
            // timer2
            // 
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel_info
            // 
            this.panel_info.BackColor = System.Drawing.Color.Transparent;
            this.panel_info.Controls.Add(this.kazanan);
            this.panel_info.Controls.Add(this.pictureBox1);
            this.panel_info.Controls.Add(this.kazanilan_puan);
            this.panel_info.ForeColor = System.Drawing.Color.Transparent;
            this.panel_info.Location = new System.Drawing.Point(480, 267);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(306, 228);
            this.panel_info.TabIndex = 31;
            this.panel_info.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_info_Paint);
            // 
            // kazanan
            // 
            this.kazanan.AutoSize = true;
            this.kazanan.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kazanan.ForeColor = System.Drawing.Color.White;
            this.kazanan.Location = new System.Drawing.Point(60, -5);
            this.kazanan.Name = "kazanan";
            this.kazanan.Size = new System.Drawing.Size(192, 73);
            this.kazanan.TabIndex = 14;
            this.kazanan.Text = "Player";
            // 
            // kazanilan_puan
            // 
            this.kazanilan_puan.AutoSize = true;
            this.kazanilan_puan.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kazanilan_puan.ForeColor = System.Drawing.Color.White;
            this.kazanilan_puan.Location = new System.Drawing.Point(86, 189);
            this.kazanilan_puan.Name = "kazanilan_puan";
            this.kazanilan_puan.Size = new System.Drawing.Size(102, 36);
            this.kazanilan_puan.TabIndex = 15;
            this.kazanilan_puan.Text = "Puan : ";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // timer4
            // 
            this.timer4.Interval = 1500;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 774);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Artificial Intelligence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(644, 774);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Player";
            // 
            // bomb
            // 
            this.bomb.Image = global::Ucak_Savasi.Properties.Resources.nuclear_bomb;
            this.bomb.Location = new System.Drawing.Point(1182, 697);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(55, 58);
            this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bomb.TabIndex = 37;
            this.bomb.TabStop = false;
            this.bomb.Visible = false;
            // 
            // ulti
            // 
            this.ulti.Image = global::Ucak_Savasi.Properties.Resources.explosion;
            this.ulti.Location = new System.Drawing.Point(644, 98);
            this.ulti.Name = "ulti";
            this.ulti.Size = new System.Drawing.Size(593, 593);
            this.ulti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ulti.TabIndex = 36;
            this.ulti.TabStop = false;
            this.ulti.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ucak_Savasi.Properties.Resources.gamepad;
            this.pictureBox1.Location = new System.Drawing.Point(59, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // carpma
            // 
            this.carpma.Image = global::Ucak_Savasi.Properties.Resources.explosion;
            this.carpma.Location = new System.Drawing.Point(701, 245);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(70, 70);
            this.carpma.TabIndex = 25;
            this.carpma.TabStop = false;
            // 
            // mermi
            // 
            this.mermi.Image = global::Ucak_Savasi.Properties.Resources.füze_kirmizi;
            this.mermi.Location = new System.Drawing.Point(945, 654);
            this.mermi.Name = "mermi";
            this.mermi.Size = new System.Drawing.Size(23, 37);
            this.mermi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mermi.TabIndex = 0;
            this.mermi.TabStop = false;
            // 
            // bucak
            // 
            this.bucak.Image = global::Ucak_Savasi.Properties.Resources.bizim;
            this.bucak.Location = new System.Drawing.Point(904, 697);
            this.bucak.Name = "bucak";
            this.bucak.Size = new System.Drawing.Size(107, 83);
            this.bucak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bucak.TabIndex = 0;
            this.bucak.TabStop = false;
            this.bucak.Click += new System.EventHandler(this.bucak_Click);
            // 
            // heart
            // 
            this.heart.Image = global::Ucak_Savasi.Properties.Resources.green_love;
            this.heart.Location = new System.Drawing.Point(1157, 240);
            this.heart.Name = "heart";
            this.heart.Size = new System.Drawing.Size(55, 50);
            this.heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heart.TabIndex = 33;
            this.heart.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Ucak_Savasi.Properties.Resources.Başlıksız_3;
            this.pictureBox3.Location = new System.Drawing.Point(1051, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(227, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(-18, 89);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1327, 3);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // ducak3
            // 
            this.ducak3.Image = global::Ucak_Savasi.Properties.Resources.savas_3;
            this.ducak3.Location = new System.Drawing.Point(1076, 118);
            this.ducak3.Name = "ducak3";
            this.ducak3.Size = new System.Drawing.Size(100, 84);
            this.ducak3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducak3.TabIndex = 3;
            this.ducak3.TabStop = false;
            // 
            // ducak2
            // 
            this.ducak2.Image = global::Ucak_Savasi.Properties.Resources.savas_3;
            this.ducak2.Location = new System.Drawing.Point(858, 118);
            this.ducak2.Name = "ducak2";
            this.ducak2.Size = new System.Drawing.Size(100, 84);
            this.ducak2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducak2.TabIndex = 0;
            this.ducak2.TabStop = false;
            // 
            // ducak1
            // 
            this.ducak1.Image = global::Ucak_Savasi.Properties.Resources.savas_3;
            this.ducak1.Location = new System.Drawing.Point(671, 118);
            this.ducak1.Name = "ducak1";
            this.ducak1.Size = new System.Drawing.Size(100, 84);
            this.ducak1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducak1.TabIndex = 2;
            this.ducak1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Ucak_Savasi.Properties.Resources.Başlıksız_3;
            this.pictureBox8.Location = new System.Drawing.Point(-8, -1);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(227, 82);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 18;
            this.pictureBox8.TabStop = false;
            // 
            // ducak_yapay_3
            // 
            this.ducak_yapay_3.Image = global::Ucak_Savasi.Properties.Resources.savas_3;
            this.ducak_yapay_3.Location = new System.Drawing.Point(436, 118);
            this.ducak_yapay_3.Name = "ducak_yapay_3";
            this.ducak_yapay_3.Size = new System.Drawing.Size(100, 84);
            this.ducak_yapay_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducak_yapay_3.TabIndex = 9;
            this.ducak_yapay_3.TabStop = false;
            // 
            // ducak_yapay_2
            // 
            this.ducak_yapay_2.Image = global::Ucak_Savasi.Properties.Resources.savas_3;
            this.ducak_yapay_2.Location = new System.Drawing.Point(258, 118);
            this.ducak_yapay_2.Name = "ducak_yapay_2";
            this.ducak_yapay_2.Size = new System.Drawing.Size(100, 84);
            this.ducak_yapay_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducak_yapay_2.TabIndex = 7;
            this.ducak_yapay_2.TabStop = false;
            // 
            // ducak_yapay_1
            // 
            this.ducak_yapay_1.Image = global::Ucak_Savasi.Properties.Resources.savas_3;
            this.ducak_yapay_1.Location = new System.Drawing.Point(71, 118);
            this.ducak_yapay_1.Name = "ducak_yapay_1";
            this.ducak_yapay_1.Size = new System.Drawing.Size(100, 84);
            this.ducak_yapay_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducak_yapay_1.TabIndex = 8;
            this.ducak_yapay_1.TabStop = false;
            // 
            // ducak_mermi_yapay_3
            // 
            this.ducak_mermi_yapay_3.Image = global::Ucak_Savasi.Properties.Resources.füze_ters_kirmizi;
            this.ducak_mermi_yapay_3.Location = new System.Drawing.Point(474, 75);
            this.ducak_mermi_yapay_3.Name = "ducak_mermi_yapay_3";
            this.ducak_mermi_yapay_3.Size = new System.Drawing.Size(23, 37);
            this.ducak_mermi_yapay_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducak_mermi_yapay_3.TabIndex = 20;
            this.ducak_mermi_yapay_3.TabStop = false;
            // 
            // ducak_mermi_yapay_2
            // 
            this.ducak_mermi_yapay_2.Image = global::Ucak_Savasi.Properties.Resources.füze_ters_kirmizi;
            this.ducak_mermi_yapay_2.Location = new System.Drawing.Point(295, 75);
            this.ducak_mermi_yapay_2.Name = "ducak_mermi_yapay_2";
            this.ducak_mermi_yapay_2.Size = new System.Drawing.Size(23, 37);
            this.ducak_mermi_yapay_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducak_mermi_yapay_2.TabIndex = 20;
            this.ducak_mermi_yapay_2.TabStop = false;
            // 
            // ducak_mermi_yapay_1
            // 
            this.ducak_mermi_yapay_1.Image = global::Ucak_Savasi.Properties.Resources.füze_ters_kirmizi;
            this.ducak_mermi_yapay_1.Location = new System.Drawing.Point(108, 75);
            this.ducak_mermi_yapay_1.Name = "ducak_mermi_yapay_1";
            this.ducak_mermi_yapay_1.Size = new System.Drawing.Size(23, 37);
            this.ducak_mermi_yapay_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducak_mermi_yapay_1.TabIndex = 20;
            this.ducak_mermi_yapay_1.TabStop = false;
            // 
            // carpma_yapay
            // 
            this.carpma_yapay.Image = global::Ucak_Savasi.Properties.Resources.explosion;
            this.carpma_yapay.Location = new System.Drawing.Point(288, 245);
            this.carpma_yapay.Name = "carpma_yapay";
            this.carpma_yapay.Size = new System.Drawing.Size(70, 70);
            this.carpma_yapay.TabIndex = 25;
            this.carpma_yapay.TabStop = false;
            this.carpma_yapay.Click += new System.EventHandler(this.carpma_yapay_Click);
            // 
            // bucak_goruntu
            // 
            this.bucak_goruntu.Image = global::Ucak_Savasi.Properties.Resources.bizim;
            this.bucak_goruntu.Location = new System.Drawing.Point(211, 697);
            this.bucak_goruntu.Name = "bucak_goruntu";
            this.bucak_goruntu.Size = new System.Drawing.Size(107, 83);
            this.bucak_goruntu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bucak_goruntu.TabIndex = 5;
            this.bucak_goruntu.TabStop = false;
            // 
            // mermi_yapay_
            // 
            this.mermi_yapay_.Image = global::Ucak_Savasi.Properties.Resources.füze_kirmizi;
            this.mermi_yapay_.Location = new System.Drawing.Point(252, 654);
            this.mermi_yapay_.Name = "mermi_yapay_";
            this.mermi_yapay_.Size = new System.Drawing.Size(23, 37);
            this.mermi_yapay_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mermi_yapay_.TabIndex = 6;
            this.mermi_yapay_.TabStop = false;
            // 
            // ducak_mermi_1
            // 
            this.ducak_mermi_1.Image = global::Ucak_Savasi.Properties.Resources.füze_ters_kirmizi;
            this.ducak_mermi_1.Location = new System.Drawing.Point(709, 75);
            this.ducak_mermi_1.Name = "ducak_mermi_1";
            this.ducak_mermi_1.Size = new System.Drawing.Size(23, 37);
            this.ducak_mermi_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducak_mermi_1.TabIndex = 20;
            this.ducak_mermi_1.TabStop = false;
            this.ducak_mermi_1.Click += new System.EventHandler(this.ducak_mermi_1_Click);
            // 
            // ducak_mermi_2
            // 
            this.ducak_mermi_2.Image = global::Ucak_Savasi.Properties.Resources.füze_ters_kirmizi;
            this.ducak_mermi_2.Location = new System.Drawing.Point(894, 75);
            this.ducak_mermi_2.Name = "ducak_mermi_2";
            this.ducak_mermi_2.Size = new System.Drawing.Size(23, 37);
            this.ducak_mermi_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducak_mermi_2.TabIndex = 20;
            this.ducak_mermi_2.TabStop = false;
            // 
            // ducak_mermi_3
            // 
            this.ducak_mermi_3.Image = global::Ucak_Savasi.Properties.Resources.füze_ters_kirmizi;
            this.ducak_mermi_3.Location = new System.Drawing.Point(1116, 75);
            this.ducak_mermi_3.Name = "ducak_mermi_3";
            this.ducak_mermi_3.Size = new System.Drawing.Size(23, 37);
            this.ducak_mermi_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducak_mermi_3.TabIndex = 20;
            this.ducak_mermi_3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ucak_Savasi.Properties.Resources.savas_2_kopya;
            this.pictureBox2.Location = new System.Drawing.Point(593, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(653, 704);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.bucak);
            this.Controls.Add(this.bomb);
            this.Controls.Add(this.ulti);
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.carpma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mermi);
            this.Controls.Add(this.heart);
            this.Controls.Add(this.lblsonuc_player);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.can_yapay);
            this.Controls.Add(this.can_player);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.lblsonuc_yapay);
            this.Controls.Add(this.hedef_goruntu);
            this.Controls.Add(this.hedef_oyuncu);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ducak3);
            this.Controls.Add(this.ducak2);
            this.Controls.Add(this.ducak1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.ducak_yapay_3);
            this.Controls.Add(this.ducak_yapay_2);
            this.Controls.Add(this.ducak_yapay_1);
            this.Controls.Add(this.ducak_mermi_yapay_3);
            this.Controls.Add(this.ducak_mermi_yapay_2);
            this.Controls.Add(this.ducak_mermi_yapay_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carpma_yapay);
            this.Controls.Add(this.bucak_goruntu);
            this.Controls.Add(this.mermi_yapay_);
            this.Controls.Add(this.ducak_mermi_1);
            this.Controls.Add(this.ducak_mermi_2);
            this.Controls.Add(this.ducak_mermi_3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_yapay_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_yapay_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_yapay_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_mermi_yapay_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_mermi_yapay_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_mermi_yapay_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpma_yapay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucak_goruntu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi_yapay_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_mermi_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_mermi_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak_mermi_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ducak2;
        private System.Windows.Forms.PictureBox mermi;
        private System.Windows.Forms.PictureBox bucak;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ducak1;
        private System.Windows.Forms.PictureBox ducak3;
        private System.Windows.Forms.Label lblsonuc_player;
        private System.Windows.Forms.PictureBox ducak_yapay_3;
        private System.Windows.Forms.PictureBox ducak_yapay_1;
        private System.Windows.Forms.PictureBox bucak_goruntu;
        private System.Windows.Forms.PictureBox mermi_yapay_;
        private System.Windows.Forms.PictureBox ducak_yapay_2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblsonuc_yapay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox ducak_mermi_1;
        private System.Windows.Forms.PictureBox ducak_mermi_2;
        private System.Windows.Forms.PictureBox ducak_mermi_3;
        private System.Windows.Forms.PictureBox ducak_mermi_yapay_1;
        private System.Windows.Forms.PictureBox ducak_mermi_yapay_2;
        private System.Windows.Forms.PictureBox ducak_mermi_yapay_3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private OpenCvSharp.UserInterface.PictureBoxIpl carpma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hedef_oyuncu;
        private System.Windows.Forms.Label hedef_goruntu;
        private System.Windows.Forms.Label can_player;
        private System.Windows.Forms.Label can_yapay;
        private OpenCvSharp.UserInterface.PictureBoxIpl carpma_yapay;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Label kazanilan_puan;
        private System.Windows.Forms.Label kazanan;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private OpenCvSharp.UserInterface.PictureBoxIpl heart;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private OpenCvSharp.UserInterface.PictureBoxIpl ulti;
        private OpenCvSharp.UserInterface.PictureBoxIpl bomb;
    }
}

