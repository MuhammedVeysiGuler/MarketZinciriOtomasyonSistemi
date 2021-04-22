
namespace otomasyonodev
{
    partial class Urunler
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
            this.urunismi = new System.Windows.Forms.ColumnHeader();
            this.indirimorani = new System.Windows.Forms.ColumnHeader();
            this.indirimtarihi = new System.Windows.Forms.ColumnHeader();
            this.sonindirimmiktari = new System.Windows.Forms.ColumnHeader();
            this.sonindirimtarihi = new System.Windows.Forms.ColumnHeader();
            this.urunlerr = new System.Windows.Forms.ListView();
            this.urunadi = new System.Windows.Forms.ColumnHeader();
            this.indirimorni = new System.Windows.Forms.ColumnHeader();
            this.indirimtrahi = new System.Windows.Forms.ColumnHeader();
            this.sonindirim = new System.Windows.Forms.ColumnHeader();
            this.sonindirimtarih = new System.Windows.Forms.ColumnHeader();
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
            // urunismi
            // 
            this.urunismi.Text = "Ürün İsmi";
            this.urunismi.Width = 120;
            // 
            // indirimorani
            // 
            this.indirimorani.DisplayIndex = 2;
            this.indirimorani.Text = "İndirim Oranı";
            this.indirimorani.Width = 120;
            // 
            // indirimtarihi
            // 
            this.indirimtarihi.DisplayIndex = 1;
            this.indirimtarihi.Text = "İndirim Tarihi";
            // 
            // sonindirimmiktari
            // 
            this.sonindirimmiktari.Text = "Son İndirim Miktarı";
            // 
            // sonindirimtarihi
            // 
            this.sonindirimtarihi.Text = "Son İndirim Tarihi";
            // 
            // urunlerr
            // 
            this.urunlerr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunadi,
            this.indirimorni,
            this.indirimtrahi,
            this.sonindirim,
            this.sonindirimtarih});
            this.urunlerr.HideSelection = false;
            this.urunlerr.Location = new System.Drawing.Point(12, 75);
            this.urunlerr.Name = "urunlerr";
            this.urunlerr.Size = new System.Drawing.Size(1106, 527);
            this.urunlerr.TabIndex = 1;
            this.urunlerr.UseCompatibleStateImageBehavior = false;
            this.urunlerr.View = System.Windows.Forms.View.Details;
            // 
            // urunadi
            // 
            this.urunadi.Text = "Urun Adi";
            // 
            // indirimorni
            // 
            this.indirimorni.Text = "Indirim Orani";
            // 
            // indirimtrahi
            // 
            this.indirimtrahi.Text = "Indirim Tarihi";
            // 
            // sonindirim
            // 
            this.sonindirim.Text = "Son İndirim Miktari";
            // 
            // sonindirimtarih
            // 
            this.sonindirimtarih.Text = "Son İndirim Tarihi";
            // 
            // isadmin
            // 
            this.isadmin.AutoSize = true;
            this.isadmin.Location = new System.Drawing.Point(1114, 0);
            this.isadmin.Name = "isadmin";
            this.isadmin.Size = new System.Drawing.Size(0, 15);
            this.isadmin.TabIndex = 2;
            // 
            // Urunler
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 614);
            this.Controls.Add(this.isadmin);
            this.Controls.Add(this.urunlerr);
            this.Controls.Add(this.homebutton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Urunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Bilgileri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Calisan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.ColumnHeader urunismi;
        private System.Windows.Forms.ColumnHeader asd;
        private System.Windows.Forms.ColumnHeader calisansuresi;
        private System.Windows.Forms.ColumnHeader calisanpozisyonu;
        private System.Windows.Forms.ColumnHeader calisanadres;
        private System.Windows.Forms.ColumnHeader indirimorani;
        private System.Windows.Forms.ColumnHeader indirimtarihi;
        private System.Windows.Forms.ColumnHeader sonindirimmiktari;
        private System.Windows.Forms.ColumnHeader sonindirimtarihi;
        private System.Windows.Forms.ListView urunlerr;
        private System.Windows.Forms.ColumnHeader urunadi;
        private System.Windows.Forms.ColumnHeader indirimorni;
        private System.Windows.Forms.ColumnHeader indirimtrahi;
        private System.Windows.Forms.ColumnHeader sonindirim;
        private System.Windows.Forms.ColumnHeader sonindirimtarih;
        public System.Windows.Forms.Label isadmin;
    }
}

