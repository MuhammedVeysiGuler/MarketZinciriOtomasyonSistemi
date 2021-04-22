
namespace otomasyonodev
{
    partial class UpdateUrun
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guncelle = new System.Windows.Forms.Button();
            this.homebutton = new System.Windows.Forms.Button();
            this.isadmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1106, 284);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // maas
            // 
            this.maas.Location = new System.Drawing.Point(162, 142);
            this.maas.Name = "maas";
            this.maas.Size = new System.Drawing.Size(100, 23);
            this.maas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ýndirim Miktarý";
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(727, 107);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(391, 205);
            this.guncelle.TabIndex = 3;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // homebutton
            // 
            this.homebutton.Location = new System.Drawing.Point(12, 12);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(1106, 57);
            this.homebutton.TabIndex = 5;
            this.homebutton.Text = "Ana Sayfa";
            this.homebutton.UseVisualStyleBackColor = true;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // isadmin
            // 
            this.isadmin.AutoSize = true;
            this.isadmin.Location = new System.Drawing.Point(467, 172);
            this.isadmin.Name = "isadmin";
            this.isadmin.Size = new System.Drawing.Size(0, 15);
            this.isadmin.TabIndex = 6;
            // 
            // UpdateUrun
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 614);
            this.Controls.Add(this.isadmin);
            this.Controls.Add(this.homebutton);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maas);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Bilgileri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Urun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox maas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button homebutton;
        public System.Windows.Forms.Label isadmin;
    }
}

