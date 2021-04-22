
namespace otomasyonodev
{
    partial class Market
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
            this.homebutton = new System.Windows.Forms.Button();
            this.markets = new System.Windows.Forms.ListView();
            this.marketadi = new System.Windows.Forms.ColumnHeader();
            this.adres = new System.Windows.Forms.ColumnHeader();
            this.temizlikurunleri = new System.Windows.Forms.ColumnHeader();
            this.gidaurunleri = new System.Windows.Forms.ColumnHeader();
            this.haftalikstok = new System.Windows.Forms.ColumnHeader();
            this.isadmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homebutton
            // 
            this.homebutton.Location = new System.Drawing.Point(12, 12);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(1106, 57);
            this.homebutton.TabIndex = 0;
            this.homebutton.Text = "Ana Sayfa";
            this.homebutton.UseVisualStyleBackColor = true;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // markets
            // 
            this.markets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.marketadi,
            this.adres,
            this.temizlikurunleri,
            this.gidaurunleri,
            this.haftalikstok});
            this.markets.HideSelection = false;
            this.markets.Location = new System.Drawing.Point(12, 75);
            this.markets.Name = "markets";
            this.markets.Size = new System.Drawing.Size(1106, 527);
            this.markets.TabIndex = 1;
            this.markets.UseCompatibleStateImageBehavior = false;
            this.markets.View = System.Windows.Forms.View.Details;
            // 
            // marketadi
            // 
            this.marketadi.Text = "Market Adı";
            // 
            // adres
            // 
            this.adres.Text = "Adres";
            // 
            // temizlikurunleri
            // 
            this.temizlikurunleri.Text = "Temizlik Ürünleri Stoğu";
            // 
            // gidaurunleri
            // 
            this.gidaurunleri.Text = "Gıda Ürünleri Stok";
            // 
            // haftalikstok
            // 
            this.haftalikstok.Text = "Haftalık İndirim Ürünleri Stok";
            // 
            // isadmin
            // 
            this.isadmin.AutoSize = true;
            this.isadmin.Location = new System.Drawing.Point(1084, -89);
            this.isadmin.Name = "isadmin";
            this.isadmin.Size = new System.Drawing.Size(0, 15);
            this.isadmin.TabIndex = 4;
            // 
            // Market
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 614);
            this.Controls.Add(this.isadmin);
            this.Controls.Add(this.markets);
            this.Controls.Add(this.homebutton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Market";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Bilgileri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Calisan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.ColumnHeader calisanmaasi;
        private System.Windows.Forms.ColumnHeader calisansuresi;
        private System.Windows.Forms.ColumnHeader calisanpozisyonu;
        private System.Windows.Forms.ColumnHeader calisanadres;
        private System.Windows.Forms.ListView markets;
        private System.Windows.Forms.ColumnHeader marketadi;
        private System.Windows.Forms.ColumnHeader adres;
        private System.Windows.Forms.ColumnHeader temizlikurunleri;
        private System.Windows.Forms.ColumnHeader gidaurunleri;
        private System.Windows.Forms.ColumnHeader haftalikstok;
        public System.Windows.Forms.Label isadmin;
    }
}

