
namespace otomasyonodev
{
    partial class Calisan
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
            this.calisanlar = new System.Windows.Forms.ListView();
            this.calisanismi = new System.Windows.Forms.ColumnHeader();
            this.calisanmaasi = new System.Windows.Forms.ColumnHeader();
            this.calisansuresi = new System.Windows.Forms.ColumnHeader();
            this.calisanpozisyonu = new System.Windows.Forms.ColumnHeader();
            this.calisanadres = new System.Windows.Forms.ColumnHeader();
            this.calisanyillikizin = new System.Windows.Forms.ColumnHeader();
            this.calisanhaftalikizin = new System.Windows.Forms.ColumnHeader();
            this.calisanmarketi = new System.Windows.Forms.ColumnHeader();
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
            // calisanlar
            // 
            this.calisanlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.calisanismi,
            this.calisanmaasi,
            this.calisansuresi,
            this.calisanpozisyonu,
            this.calisanadres,
            this.calisanyillikizin,
            this.calisanhaftalikizin,
            this.calisanmarketi});
            this.calisanlar.GridLines = true;
            this.calisanlar.HideSelection = false;
            this.calisanlar.Location = new System.Drawing.Point(12, 75);
            this.calisanlar.Name = "calisanlar";
            this.calisanlar.Size = new System.Drawing.Size(1106, 527);
            this.calisanlar.TabIndex = 2;
            this.calisanlar.UseCompatibleStateImageBehavior = false;
            this.calisanlar.View = System.Windows.Forms.View.Details;
            this.calisanlar.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // calisanismi
            // 
            this.calisanismi.Text = "Çalışan İsmi";
            this.calisanismi.Width = 120;
            // 
            // calisanmaasi
            // 
            this.calisanmaasi.Text = "Maaş";
            // 
            // calisansuresi
            // 
            this.calisansuresi.Text = "Çalışma Süresi";
            this.calisansuresi.Width = 120;
            // 
            // calisanpozisyonu
            // 
            this.calisanpozisyonu.Text = "Pozisyon";
            // 
            // calisanadres
            // 
            this.calisanadres.DisplayIndex = 5;
            this.calisanadres.Text = "Adresi";
            // 
            // calisanyillikizin
            // 
            this.calisanyillikizin.DisplayIndex = 6;
            this.calisanyillikizin.Text = "Kalan Yıllık İzin";
            this.calisanyillikizin.Width = 120;
            // 
            // calisanhaftalikizin
            // 
            this.calisanhaftalikizin.DisplayIndex = 7;
            this.calisanhaftalikizin.Text = "Kalan Haftalık İzin";
            this.calisanhaftalikizin.Width = 120;
            // 
            // calisanmarketi
            // 
            this.calisanmarketi.DisplayIndex = 4;
            this.calisanmarketi.Text = "Çalıştığı Market";
            this.calisanmarketi.Width = 120;
            // 
            // isadmin
            // 
            this.isadmin.AutoSize = true;
            this.isadmin.Location = new System.Drawing.Point(1114, -1);
            this.isadmin.Name = "isadmin";
            this.isadmin.Size = new System.Drawing.Size(0, 15);
            this.isadmin.TabIndex = 3;
            // 
            // Calisan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 614);
            this.Controls.Add(this.isadmin);
            this.Controls.Add(this.calisanlar);
            this.Controls.Add(this.homebutton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calisan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Bilgileri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Calisan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.ListView calisanlar;
        private System.Windows.Forms.ColumnHeader calisanismi;
        private System.Windows.Forms.ColumnHeader calisanmaasi;
        private System.Windows.Forms.ColumnHeader calisansuresi;
        private System.Windows.Forms.ColumnHeader calisanpozisyonu;
        private System.Windows.Forms.ColumnHeader calisanmarketi;
        private System.Windows.Forms.ColumnHeader calisanadres;
        private System.Windows.Forms.ColumnHeader calisanyillikizin;
        private System.Windows.Forms.ColumnHeader calisanhaftalikizin;
        public System.Windows.Forms.Label isadmin;
    }
}

