
namespace otomasyonodev
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gotocalisan = new System.Windows.Forms.Button();
            this.gotomarket = new System.Windows.Forms.Button();
            this.gotourun = new System.Windows.Forms.Button();
            this.indirimyap = new System.Windows.Forms.Button();
            this.calisanupdate = new System.Windows.Forms.Button();
            this.gototedarikci = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gotocalisan
            // 
            this.gotocalisan.Location = new System.Drawing.Point(12, 12);
            this.gotocalisan.Name = "gotocalisan";
            this.gotocalisan.Size = new System.Drawing.Size(372, 291);
            this.gotocalisan.TabIndex = 0;
            this.gotocalisan.Text = "Çalışan Bilgileri";
            this.gotocalisan.UseVisualStyleBackColor = true;
            this.gotocalisan.Click += new System.EventHandler(this.gotocalisan_Click);
            // 
            // gotomarket
            // 
            this.gotomarket.Location = new System.Drawing.Point(390, 12);
            this.gotomarket.Name = "gotomarket";
            this.gotomarket.Size = new System.Drawing.Size(366, 291);
            this.gotomarket.TabIndex = 0;
            this.gotomarket.Text = "Market Bilgileri";
            this.gotomarket.UseVisualStyleBackColor = true;
            this.gotomarket.Click += new System.EventHandler(this.gotomarket_Click);
            // 
            // gotourun
            // 
            this.gotourun.Location = new System.Drawing.Point(762, 12);
            this.gotourun.Name = "gotourun";
            this.gotourun.Size = new System.Drawing.Size(356, 291);
            this.gotourun.TabIndex = 1;
            this.gotourun.Text = "Ürün Bilgileri";
            this.gotourun.UseVisualStyleBackColor = true;
            this.gotourun.Click += new System.EventHandler(this.gotourun_Click);
            // 
            // indirimyap
            // 
            this.indirimyap.Location = new System.Drawing.Point(12, 309);
            this.indirimyap.Name = "indirimyap";
            this.indirimyap.Size = new System.Drawing.Size(372, 139);
            this.indirimyap.TabIndex = 0;
            this.indirimyap.Text = "İndirim Yap";
            this.indirimyap.UseVisualStyleBackColor = true;
            this.indirimyap.Click += new System.EventHandler(this.indirimyap_Click);
            // 
            // calisanupdate
            // 
            this.calisanupdate.Location = new System.Drawing.Point(762, 309);
            this.calisanupdate.Name = "calisanupdate";
            this.calisanupdate.Size = new System.Drawing.Size(356, 293);
            this.calisanupdate.TabIndex = 1;
            this.calisanupdate.Text = "Çalışan Bilgilerini Değiştir";
            this.calisanupdate.UseVisualStyleBackColor = true;
            this.calisanupdate.Click += new System.EventHandler(this.calisanupdate_Click);
            // 
            // gototedarikci
            // 
            this.gototedarikci.Location = new System.Drawing.Point(390, 309);
            this.gototedarikci.Name = "gototedarikci";
            this.gototedarikci.Size = new System.Drawing.Size(366, 139);
            this.gototedarikci.TabIndex = 1;
            this.gototedarikci.Text = "Tedarikçi Bilgileri";
            this.gototedarikci.UseVisualStyleBackColor = true;
            this.gototedarikci.Click += new System.EventHandler(this.gototedarikci_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(390, 454);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(366, 139);
            this.close.TabIndex = 1;
            this.close.Text = "Kapat";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.kapat_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(12, 454);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(372, 139);
            this.cikis.TabIndex = 0;
            this.cikis.Text = "Çıkış Yap";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikisyap_Click);
            // 
            // HomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 614);
            this.Controls.Add(this.calisanupdate);
            this.Controls.Add(this.gotourun);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.close);
            this.Controls.Add(this.indirimyap);
            this.Controls.Add(this.gototedarikci);
            this.Controls.Add(this.gotomarket);
            this.Controls.Add(this.gotocalisan);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Bilgileri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Market_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gotocalisan;
        private System.Windows.Forms.Button gotomarket;
        private System.Windows.Forms.Button gotourun;
        private System.Windows.Forms.Button indirimyap;
        public System.Windows.Forms.Button calisanupdate;
        private System.Windows.Forms.Button gototedarikci;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button cikis;
    }
}

