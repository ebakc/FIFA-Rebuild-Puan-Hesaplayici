namespace ebakc___FIFA_Rebuild_Puan_Hesaplayıcı
{
    partial class uclForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uclForm));
            this.hesaplaButon = new System.Windows.Forms.Button();
            this.premierLigLabel = new System.Windows.Forms.Label();
            this.ligSiralamaLabel = new System.Windows.Forms.Label();
            this.ligGolLabel = new System.Windows.Forms.Label();
            this.ligAsistLabel = new System.Windows.Forms.Label();
            this.ligKaleciLabel = new System.Windows.Forms.Label();
            this.ligAPLabel = new System.Windows.Forms.Label();
            this.ligVerimLabel = new System.Windows.Forms.Label();
            this.ligSiralamaCB = new System.Windows.Forms.ComboBox();
            this.ligGolCB = new System.Windows.Forms.ComboBox();
            this.ligAsistCB = new System.Windows.Forms.ComboBox();
            this.ligKaleciCB = new System.Windows.Forms.ComboBox();
            this.ligapTB = new System.Windows.Forms.TextBox();
            this.ligverimTB = new System.Windows.Forms.TextBox();
            this.facupLabel = new System.Windows.Forms.Label();
            this.facupCB = new System.Windows.Forms.ComboBox();
            this.carabaocupLabel = new System.Windows.Forms.Label();
            this.carabaocupCB = new System.Windows.Forms.ComboBox();
            this.ligBolusmeLabel = new System.Windows.Forms.Label();
            this.bolusumLigGolTB = new System.Windows.Forms.TextBox();
            this.bolusumLigAsistTB = new System.Windows.Forms.TextBox();
            this.bolusumLigKaleciTB = new System.Windows.Forms.TextBox();
            this.uclLabel = new System.Windows.Forms.Label();
            this.uclKaleciCB = new System.Windows.Forms.ComboBox();
            this.uclAsistCB = new System.Windows.Forms.ComboBox();
            this.uclGolCB = new System.Windows.Forms.ComboBox();
            this.uclBolusmeLabel = new System.Windows.Forms.Label();
            this.bolusumUCLKaleciTB = new System.Windows.Forms.TextBox();
            this.bolusumUCLAsistTB = new System.Windows.Forms.TextBox();
            this.bolusumUCLGolTB = new System.Windows.Forms.TextBox();
            this.uclSiralamaCB = new System.Windows.Forms.ComboBox();
            this.uclGrupSiraCB = new System.Windows.Forms.ComboBox();
            this.ucleltkCB = new System.Windows.Forms.ComboBox();
            this.uclgrupSiraLabel = new System.Windows.Forms.Label();
            this.ucleltkLabel = new System.Windows.Forms.Label();
            this.uyari2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // hesaplaButon
            // 
            this.hesaplaButon.BackColor = System.Drawing.Color.Black;
            this.hesaplaButon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplaButon.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.hesaplaButon.Location = new System.Drawing.Point(674, 453);
            this.hesaplaButon.Name = "hesaplaButon";
            this.hesaplaButon.Size = new System.Drawing.Size(110, 40);
            this.hesaplaButon.TabIndex = 0;
            this.hesaplaButon.Text = "Hesapla";
            this.hesaplaButon.UseVisualStyleBackColor = false;
            this.hesaplaButon.Click += new System.EventHandler(this.hesaplaButon_Click);
            // 
            // premierLigLabel
            // 
            this.premierLigLabel.AutoSize = true;
            this.premierLigLabel.BackColor = System.Drawing.Color.Transparent;
            this.premierLigLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.premierLigLabel.ForeColor = System.Drawing.Color.White;
            this.premierLigLabel.Location = new System.Drawing.Point(20, 100);
            this.premierLigLabel.Name = "premierLigLabel";
            this.premierLigLabel.Size = new System.Drawing.Size(102, 18);
            this.premierLigLabel.TabIndex = 2;
            this.premierLigLabel.Text = "Premier Lig";
            // 
            // ligSiralamaLabel
            // 
            this.ligSiralamaLabel.AutoSize = true;
            this.ligSiralamaLabel.BackColor = System.Drawing.Color.Transparent;
            this.ligSiralamaLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ligSiralamaLabel.ForeColor = System.Drawing.Color.White;
            this.ligSiralamaLabel.Location = new System.Drawing.Point(170, 75);
            this.ligSiralamaLabel.Name = "ligSiralamaLabel";
            this.ligSiralamaLabel.Size = new System.Drawing.Size(52, 14);
            this.ligSiralamaLabel.TabIndex = 3;
            this.ligSiralamaLabel.Text = "Sıralama";
            // 
            // ligGolLabel
            // 
            this.ligGolLabel.AutoSize = true;
            this.ligGolLabel.BackColor = System.Drawing.Color.Transparent;
            this.ligGolLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ligGolLabel.ForeColor = System.Drawing.Color.White;
            this.ligGolLabel.Location = new System.Drawing.Point(270, 75);
            this.ligGolLabel.Name = "ligGolLabel";
            this.ligGolLabel.Size = new System.Drawing.Size(50, 14);
            this.ligGolLabel.TabIndex = 4;
            this.ligGolLabel.Text = "Gol Kralı";
            // 
            // ligAsistLabel
            // 
            this.ligAsistLabel.AutoSize = true;
            this.ligAsistLabel.BackColor = System.Drawing.Color.Transparent;
            this.ligAsistLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ligAsistLabel.ForeColor = System.Drawing.Color.White;
            this.ligAsistLabel.Location = new System.Drawing.Point(370, 75);
            this.ligAsistLabel.Name = "ligAsistLabel";
            this.ligAsistLabel.Size = new System.Drawing.Size(58, 14);
            this.ligAsistLabel.TabIndex = 5;
            this.ligAsistLabel.Text = "Asist Kralı";
            // 
            // ligKaleciLabel
            // 
            this.ligKaleciLabel.AutoSize = true;
            this.ligKaleciLabel.BackColor = System.Drawing.Color.Transparent;
            this.ligKaleciLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ligKaleciLabel.ForeColor = System.Drawing.Color.White;
            this.ligKaleciLabel.Location = new System.Drawing.Point(470, 75);
            this.ligKaleciLabel.Name = "ligKaleciLabel";
            this.ligKaleciLabel.Size = new System.Drawing.Size(63, 14);
            this.ligKaleciLabel.TabIndex = 6;
            this.ligKaleciLabel.Text = "Kaleci Kralı";
            // 
            // ligAPLabel
            // 
            this.ligAPLabel.AutoSize = true;
            this.ligAPLabel.BackColor = System.Drawing.Color.Transparent;
            this.ligAPLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ligAPLabel.ForeColor = System.Drawing.Color.White;
            this.ligAPLabel.Location = new System.Drawing.Point(570, 75);
            this.ligAPLabel.Name = "ligAPLabel";
            this.ligAPLabel.Size = new System.Drawing.Size(76, 14);
            this.ligAPLabel.TabIndex = 7;
            this.ligAPLabel.Text = "Averaj + Puan";
            // 
            // ligVerimLabel
            // 
            this.ligVerimLabel.AutoSize = true;
            this.ligVerimLabel.BackColor = System.Drawing.Color.Transparent;
            this.ligVerimLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ligVerimLabel.ForeColor = System.Drawing.Color.White;
            this.ligVerimLabel.Location = new System.Drawing.Point(670, 75);
            this.ligVerimLabel.Name = "ligVerimLabel";
            this.ligVerimLabel.Size = new System.Drawing.Size(36, 14);
            this.ligVerimLabel.TabIndex = 8;
            this.ligVerimLabel.Text = "Verim";
            // 
            // ligSiralamaCB
            // 
            this.ligSiralamaCB.FormattingEnabled = true;
            this.ligSiralamaCB.Items.AddRange(new object[] {
            "Birinci",
            "İkinci",
            "Üçüncü",
            "Dördüncü",
            "Beşinci+"});
            this.ligSiralamaCB.Location = new System.Drawing.Point(170, 100);
            this.ligSiralamaCB.Name = "ligSiralamaCB";
            this.ligSiralamaCB.Size = new System.Drawing.Size(75, 21);
            this.ligSiralamaCB.TabIndex = 9;
            // 
            // ligGolCB
            // 
            this.ligGolCB.FormattingEnabled = true;
            this.ligGolCB.Items.AddRange(new object[] {
            "Birinci",
            "İkinci",
            "Üçüncü",
            "Dördüncü+"});
            this.ligGolCB.Location = new System.Drawing.Point(270, 100);
            this.ligGolCB.Name = "ligGolCB";
            this.ligGolCB.Size = new System.Drawing.Size(75, 21);
            this.ligGolCB.TabIndex = 10;
            // 
            // ligAsistCB
            // 
            this.ligAsistCB.FormattingEnabled = true;
            this.ligAsistCB.Items.AddRange(new object[] {
            "Birinci",
            "İkinci",
            "Üçüncü",
            "Dördüncü+"});
            this.ligAsistCB.Location = new System.Drawing.Point(370, 100);
            this.ligAsistCB.Name = "ligAsistCB";
            this.ligAsistCB.Size = new System.Drawing.Size(75, 21);
            this.ligAsistCB.TabIndex = 11;
            // 
            // ligKaleciCB
            // 
            this.ligKaleciCB.FormattingEnabled = true;
            this.ligKaleciCB.Items.AddRange(new object[] {
            "Birinci",
            "İkinci",
            "Üçüncü",
            "Dördüncü+"});
            this.ligKaleciCB.Location = new System.Drawing.Point(470, 100);
            this.ligKaleciCB.Name = "ligKaleciCB";
            this.ligKaleciCB.Size = new System.Drawing.Size(75, 21);
            this.ligKaleciCB.TabIndex = 12;
            // 
            // ligapTB
            // 
            this.ligapTB.Location = new System.Drawing.Point(570, 100);
            this.ligapTB.Name = "ligapTB";
            this.ligapTB.Size = new System.Drawing.Size(75, 20);
            this.ligapTB.TabIndex = 13;
            // 
            // ligverimTB
            // 
            this.ligverimTB.Location = new System.Drawing.Point(670, 100);
            this.ligverimTB.Name = "ligverimTB";
            this.ligverimTB.Size = new System.Drawing.Size(75, 20);
            this.ligverimTB.TabIndex = 14;
            // 
            // facupLabel
            // 
            this.facupLabel.AutoSize = true;
            this.facupLabel.BackColor = System.Drawing.Color.Transparent;
            this.facupLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.facupLabel.ForeColor = System.Drawing.Color.White;
            this.facupLabel.Location = new System.Drawing.Point(20, 180);
            this.facupLabel.Name = "facupLabel";
            this.facupLabel.Size = new System.Drawing.Size(66, 18);
            this.facupLabel.TabIndex = 15;
            this.facupLabel.Text = "FA Cup";
            // 
            // facupCB
            // 
            this.facupCB.FormattingEnabled = true;
            this.facupCB.Items.AddRange(new object[] {
            "Birinci",
            "İkinci",
            "Yarı Final",
            "Çeyrek Final",
            "Son16+"});
            this.facupCB.Location = new System.Drawing.Point(170, 180);
            this.facupCB.Name = "facupCB";
            this.facupCB.Size = new System.Drawing.Size(75, 21);
            this.facupCB.TabIndex = 16;
            // 
            // carabaocupLabel
            // 
            this.carabaocupLabel.AutoSize = true;
            this.carabaocupLabel.BackColor = System.Drawing.Color.Transparent;
            this.carabaocupLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carabaocupLabel.ForeColor = System.Drawing.Color.White;
            this.carabaocupLabel.Location = new System.Drawing.Point(20, 220);
            this.carabaocupLabel.Name = "carabaocupLabel";
            this.carabaocupLabel.Size = new System.Drawing.Size(112, 18);
            this.carabaocupLabel.TabIndex = 17;
            this.carabaocupLabel.Text = "Carabao Cup";
            // 
            // carabaocupCB
            // 
            this.carabaocupCB.FormattingEnabled = true;
            this.carabaocupCB.Items.AddRange(new object[] {
            "Birinci",
            "İkinci",
            "Yarı Final",
            "Çeyrek Final",
            "Son16+"});
            this.carabaocupCB.Location = new System.Drawing.Point(170, 220);
            this.carabaocupCB.Name = "carabaocupCB";
            this.carabaocupCB.Size = new System.Drawing.Size(75, 21);
            this.carabaocupCB.TabIndex = 18;
            // 
            // ligBolusmeLabel
            // 
            this.ligBolusmeLabel.AutoSize = true;
            this.ligBolusmeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ligBolusmeLabel.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ligBolusmeLabel.ForeColor = System.Drawing.Color.Lavender;
            this.ligBolusmeLabel.Location = new System.Drawing.Point(100, 140);
            this.ligBolusmeLabel.Name = "ligBolusmeLabel";
            this.ligBolusmeLabel.Size = new System.Drawing.Size(143, 18);
            this.ligBolusmeLabel.TabIndex = 19;
            this.ligBolusmeLabel.Text = "Bölüşme Sayıları";
            // 
            // bolusumLigGolTB
            // 
            this.bolusumLigGolTB.Location = new System.Drawing.Point(270, 140);
            this.bolusumLigGolTB.Name = "bolusumLigGolTB";
            this.bolusumLigGolTB.Size = new System.Drawing.Size(75, 20);
            this.bolusumLigGolTB.TabIndex = 20;
            // 
            // bolusumLigAsistTB
            // 
            this.bolusumLigAsistTB.Location = new System.Drawing.Point(370, 140);
            this.bolusumLigAsistTB.Name = "bolusumLigAsistTB";
            this.bolusumLigAsistTB.Size = new System.Drawing.Size(75, 20);
            this.bolusumLigAsistTB.TabIndex = 21;
            // 
            // bolusumLigKaleciTB
            // 
            this.bolusumLigKaleciTB.Location = new System.Drawing.Point(470, 140);
            this.bolusumLigKaleciTB.Name = "bolusumLigKaleciTB";
            this.bolusumLigKaleciTB.Size = new System.Drawing.Size(75, 20);
            this.bolusumLigKaleciTB.TabIndex = 22;
            // 
            // uclLabel
            // 
            this.uclLabel.AutoSize = true;
            this.uclLabel.BackColor = System.Drawing.Color.Transparent;
            this.uclLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uclLabel.ForeColor = System.Drawing.Color.White;
            this.uclLabel.Location = new System.Drawing.Point(20, 270);
            this.uclLabel.Name = "uclLabel";
            this.uclLabel.Size = new System.Drawing.Size(41, 18);
            this.uclLabel.TabIndex = 23;
            this.uclLabel.Text = "UCL";
            // 
            // uclKaleciCB
            // 
            this.uclKaleciCB.FormattingEnabled = true;
            this.uclKaleciCB.Items.AddRange(new object[] {
            "Birinci",
            "İkinci",
            "Üçüncü",
            "Dördüncü+"});
            this.uclKaleciCB.Location = new System.Drawing.Point(470, 270);
            this.uclKaleciCB.Name = "uclKaleciCB";
            this.uclKaleciCB.Size = new System.Drawing.Size(75, 21);
            this.uclKaleciCB.TabIndex = 27;
            // 
            // uclAsistCB
            // 
            this.uclAsistCB.FormattingEnabled = true;
            this.uclAsistCB.Items.AddRange(new object[] {
            "Birinci",
            "İkinci",
            "Üçüncü",
            "Dördüncü+"});
            this.uclAsistCB.Location = new System.Drawing.Point(370, 270);
            this.uclAsistCB.Name = "uclAsistCB";
            this.uclAsistCB.Size = new System.Drawing.Size(75, 21);
            this.uclAsistCB.TabIndex = 26;
            // 
            // uclGolCB
            // 
            this.uclGolCB.FormattingEnabled = true;
            this.uclGolCB.Items.AddRange(new object[] {
            "Birinci",
            "İkinci",
            "Üçüncü",
            "Dördüncü+"});
            this.uclGolCB.Location = new System.Drawing.Point(270, 270);
            this.uclGolCB.Name = "uclGolCB";
            this.uclGolCB.Size = new System.Drawing.Size(75, 21);
            this.uclGolCB.TabIndex = 25;
            // 
            // uclBolusmeLabel
            // 
            this.uclBolusmeLabel.AutoSize = true;
            this.uclBolusmeLabel.BackColor = System.Drawing.Color.Transparent;
            this.uclBolusmeLabel.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uclBolusmeLabel.ForeColor = System.Drawing.Color.Lavender;
            this.uclBolusmeLabel.Location = new System.Drawing.Point(100, 310);
            this.uclBolusmeLabel.Name = "uclBolusmeLabel";
            this.uclBolusmeLabel.Size = new System.Drawing.Size(143, 18);
            this.uclBolusmeLabel.TabIndex = 32;
            this.uclBolusmeLabel.Text = "Bölüşme Sayıları";
            // 
            // bolusumUCLKaleciTB
            // 
            this.bolusumUCLKaleciTB.Location = new System.Drawing.Point(470, 310);
            this.bolusumUCLKaleciTB.Name = "bolusumUCLKaleciTB";
            this.bolusumUCLKaleciTB.Size = new System.Drawing.Size(75, 20);
            this.bolusumUCLKaleciTB.TabIndex = 35;
            // 
            // bolusumUCLAsistTB
            // 
            this.bolusumUCLAsistTB.Location = new System.Drawing.Point(370, 310);
            this.bolusumUCLAsistTB.Name = "bolusumUCLAsistTB";
            this.bolusumUCLAsistTB.Size = new System.Drawing.Size(75, 20);
            this.bolusumUCLAsistTB.TabIndex = 34;
            // 
            // bolusumUCLGolTB
            // 
            this.bolusumUCLGolTB.Location = new System.Drawing.Point(270, 310);
            this.bolusumUCLGolTB.Name = "bolusumUCLGolTB";
            this.bolusumUCLGolTB.Size = new System.Drawing.Size(75, 20);
            this.bolusumUCLGolTB.TabIndex = 33;
            // 
            // uclSiralamaCB
            // 
            this.uclSiralamaCB.FormattingEnabled = true;
            this.uclSiralamaCB.Items.AddRange(new object[] {
            "Birinci",
            "İkinci",
            "Yarı Final",
            "Çeyrek Final",
            "Son16"});
            this.uclSiralamaCB.Location = new System.Drawing.Point(170, 270);
            this.uclSiralamaCB.Name = "uclSiralamaCB";
            this.uclSiralamaCB.Size = new System.Drawing.Size(75, 21);
            this.uclSiralamaCB.TabIndex = 43;
            // 
            // uclGrupSiraCB
            // 
            this.uclGrupSiraCB.FormattingEnabled = true;
            this.uclGrupSiraCB.Items.AddRange(new object[] {
            "Birinci",
            "Birinci değil"});
            this.uclGrupSiraCB.Location = new System.Drawing.Point(570, 270);
            this.uclGrupSiraCB.Name = "uclGrupSiraCB";
            this.uclGrupSiraCB.Size = new System.Drawing.Size(75, 21);
            this.uclGrupSiraCB.TabIndex = 44;
            // 
            // ucleltkCB
            // 
            this.ucleltkCB.FormattingEnabled = true;
            this.ucleltkCB.Items.AddRange(new object[] {
            "Birinci",
            "Birinci değil"});
            this.ucleltkCB.Location = new System.Drawing.Point(670, 270);
            this.ucleltkCB.Name = "ucleltkCB";
            this.ucleltkCB.Size = new System.Drawing.Size(75, 21);
            this.ucleltkCB.TabIndex = 45;
            // 
            // uclgrupSiraLabel
            // 
            this.uclgrupSiraLabel.AutoSize = true;
            this.uclgrupSiraLabel.BackColor = System.Drawing.Color.Transparent;
            this.uclgrupSiraLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uclgrupSiraLabel.ForeColor = System.Drawing.Color.White;
            this.uclgrupSiraLabel.Location = new System.Drawing.Point(570, 235);
            this.uclgrupSiraLabel.Name = "uclgrupSiraLabel";
            this.uclgrupSiraLabel.Size = new System.Drawing.Size(60, 28);
            this.uclgrupSiraLabel.TabIndex = 46;
            this.uclgrupSiraLabel.Text = "Grup\r\nSıralaması";
            // 
            // ucleltkLabel
            // 
            this.ucleltkLabel.AutoSize = true;
            this.ucleltkLabel.BackColor = System.Drawing.Color.Transparent;
            this.ucleltkLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucleltkLabel.ForeColor = System.Drawing.Color.White;
            this.ucleltkLabel.Location = new System.Drawing.Point(670, 235);
            this.ucleltkLabel.Name = "ucleltkLabel";
            this.ucleltkLabel.Size = new System.Drawing.Size(86, 28);
            this.ucleltkLabel.TabIndex = 47;
            this.ucleltkLabel.Text = "Elendiğin Takım\r\nSıralaması";
            // 
            // uyari2
            // 
            this.uyari2.AutoSize = true;
            this.uyari2.BackColor = System.Drawing.Color.Transparent;
            this.uyari2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.uyari2.ForeColor = System.Drawing.Color.White;
            this.uyari2.Location = new System.Drawing.Point(567, 140);
            this.uyari2.Name = "uyari2";
            this.uyari2.Size = new System.Drawing.Size(186, 32);
            this.uyari2.TabIndex = 48;
            this.uyari2.Text = "Detaylı açıklama için farenizi\r\nyazının üstüne getirin.\r\n";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.AliceBlue;
            this.linkLabel1.Location = new System.Drawing.Point(330, 10);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 15);
            this.linkLabel1.TabIndex = 49;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "github.com/ebakc";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // uclForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(176)))));
            this.BackgroundImage = global::ebakc___FIFA_Rebuild_Puan_Hesaplayıcı.Properties.Resources.uclFoto;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.uyari2);
            this.Controls.Add(this.ucleltkLabel);
            this.Controls.Add(this.uclgrupSiraLabel);
            this.Controls.Add(this.ucleltkCB);
            this.Controls.Add(this.uclGrupSiraCB);
            this.Controls.Add(this.uclSiralamaCB);
            this.Controls.Add(this.bolusumUCLKaleciTB);
            this.Controls.Add(this.bolusumUCLAsistTB);
            this.Controls.Add(this.bolusumUCLGolTB);
            this.Controls.Add(this.uclBolusmeLabel);
            this.Controls.Add(this.uclKaleciCB);
            this.Controls.Add(this.uclAsistCB);
            this.Controls.Add(this.uclGolCB);
            this.Controls.Add(this.uclLabel);
            this.Controls.Add(this.bolusumLigKaleciTB);
            this.Controls.Add(this.bolusumLigAsistTB);
            this.Controls.Add(this.bolusumLigGolTB);
            this.Controls.Add(this.ligBolusmeLabel);
            this.Controls.Add(this.carabaocupCB);
            this.Controls.Add(this.carabaocupLabel);
            this.Controls.Add(this.facupCB);
            this.Controls.Add(this.facupLabel);
            this.Controls.Add(this.ligverimTB);
            this.Controls.Add(this.ligapTB);
            this.Controls.Add(this.ligKaleciCB);
            this.Controls.Add(this.ligAsistCB);
            this.Controls.Add(this.ligGolCB);
            this.Controls.Add(this.ligSiralamaCB);
            this.Controls.Add(this.ligVerimLabel);
            this.Controls.Add(this.ligAPLabel);
            this.Controls.Add(this.ligKaleciLabel);
            this.Controls.Add(this.ligAsistLabel);
            this.Controls.Add(this.ligGolLabel);
            this.Controls.Add(this.ligSiralamaLabel);
            this.Controls.Add(this.premierLigLabel);
            this.Controls.Add(this.hesaplaButon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uclForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ebakc - FIFA Rebuild Puan Hesaplayıcı";
            this.Load += new System.EventHandler(this.uclForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesaplaButon;
        private System.Windows.Forms.Label premierLigLabel;
        private System.Windows.Forms.Label ligSiralamaLabel;
        private System.Windows.Forms.Label ligGolLabel;
        private System.Windows.Forms.Label ligAsistLabel;
        private System.Windows.Forms.Label ligKaleciLabel;
        private System.Windows.Forms.Label ligAPLabel;
        private System.Windows.Forms.Label ligVerimLabel;
        private System.Windows.Forms.ComboBox ligSiralamaCB;
        private System.Windows.Forms.ComboBox ligGolCB;
        private System.Windows.Forms.ComboBox ligAsistCB;
        private System.Windows.Forms.ComboBox ligKaleciCB;
        private System.Windows.Forms.TextBox ligapTB;
        private System.Windows.Forms.TextBox ligverimTB;
        private System.Windows.Forms.Label facupLabel;
        private System.Windows.Forms.ComboBox facupCB;
        private System.Windows.Forms.Label carabaocupLabel;
        private System.Windows.Forms.ComboBox carabaocupCB;
        private System.Windows.Forms.Label ligBolusmeLabel;
        private System.Windows.Forms.TextBox bolusumLigGolTB;
        private System.Windows.Forms.TextBox bolusumLigAsistTB;
        private System.Windows.Forms.TextBox bolusumLigKaleciTB;
        private System.Windows.Forms.Label uclLabel;
        private System.Windows.Forms.ComboBox uclKaleciCB;
        private System.Windows.Forms.ComboBox uclAsistCB;
        private System.Windows.Forms.ComboBox uclGolCB;
        private System.Windows.Forms.Label uclBolusmeLabel;
        private System.Windows.Forms.TextBox bolusumUCLKaleciTB;
        private System.Windows.Forms.TextBox bolusumUCLAsistTB;
        private System.Windows.Forms.TextBox bolusumUCLGolTB;
        private System.Windows.Forms.ComboBox uclSiralamaCB;
        private System.Windows.Forms.ComboBox uclGrupSiraCB;
        private System.Windows.Forms.ComboBox ucleltkCB;
        private System.Windows.Forms.Label uclgrupSiraLabel;
        private System.Windows.Forms.Label ucleltkLabel;
        private System.Windows.Forms.Label uyari2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

