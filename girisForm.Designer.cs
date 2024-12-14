namespace ebakc___FIFA_Rebuild_Puan_Hesaplayıcı
{
    partial class girisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisForm));
            this.devamButon1 = new System.Windows.Forms.Button();
            this.uclButton = new System.Windows.Forms.Button();
            this.uelButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // devamButon1
            // 
            this.devamButon1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.devamButon1.Location = new System.Drawing.Point(812, 609);
            this.devamButon1.Name = "devamButon1";
            this.devamButon1.Size = new System.Drawing.Size(110, 40);
            this.devamButon1.TabIndex = 0;
            this.devamButon1.Text = "İleri";
            this.devamButon1.UseVisualStyleBackColor = true;
            // 
            // uclButton
            // 
            this.uclButton.BackColor = System.Drawing.Color.Black;
            this.uclButton.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uclButton.ForeColor = System.Drawing.SystemColors.Control;
            this.uclButton.Location = new System.Drawing.Point(321, 103);
            this.uclButton.Name = "uclButton";
            this.uclButton.Size = new System.Drawing.Size(100, 40);
            this.uclButton.TabIndex = 2;
            this.uclButton.Text = "UCL";
            this.uclButton.UseVisualStyleBackColor = false;
            this.uclButton.Click += new System.EventHandler(this.uclButton_Click);
            // 
            // uelButton
            // 
            this.uelButton.BackColor = System.Drawing.Color.Black;
            this.uelButton.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            this.uelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.uelButton.Location = new System.Drawing.Point(321, 180);
            this.uelButton.Name = "uelButton";
            this.uelButton.Size = new System.Drawing.Size(100, 40);
            this.uelButton.TabIndex = 3;
            this.uelButton.Text = "UEL";
            this.uelButton.UseVisualStyleBackColor = false;
            this.uelButton.Click += new System.EventHandler(this.uelButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(373, 439);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "github.com/ebakc";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Puanlar Neye Göre Hesaplanıyor?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // girisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ebakc___FIFA_Rebuild_Puan_Hesaplayıcı.Properties.Resources.girisFormFoto;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.uelButton);
            this.Controls.Add(this.uclButton);
            this.Controls.Add(this.devamButon1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "girisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ebakc - FIFA Rebuild Puan Hesaplayıcı";
            this.Load += new System.EventHandler(this.girisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button devamButon1;
        private System.Windows.Forms.Button uclButton;
        private System.Windows.Forms.Button uelButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

