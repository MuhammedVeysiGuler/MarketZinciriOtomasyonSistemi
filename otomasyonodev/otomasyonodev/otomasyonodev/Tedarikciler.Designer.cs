
namespace otomasyonodev
{
    partial class Tedarikciler
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
            this.tedarikcilerr = new System.Windows.Forms.ListView();
            this.tedarikciadi = new System.Windows.Forms.ColumnHeader();
            this.adres = new System.Windows.Forms.ColumnHeader();
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
            // tedarikcilerr
            // 
            this.tedarikcilerr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tedarikciadi,
            this.adres});
            this.tedarikcilerr.HideSelection = false;
            this.tedarikcilerr.Location = new System.Drawing.Point(12, 75);
            this.tedarikcilerr.Name = "tedarikcilerr";
            this.tedarikcilerr.Size = new System.Drawing.Size(1106, 527);
            this.tedarikcilerr.TabIndex = 1;
            this.tedarikcilerr.UseCompatibleStateImageBehavior = false;
            this.tedarikcilerr.View = System.Windows.Forms.View.Details;
            // 
            // tedarikciadi
            // 
            this.tedarikciadi.Text = "Tedarikçi Adı";
            // 
            // adres
            // 
            this.adres.Text = "Adres";
            // 
            // isadmin
            // 
            this.isadmin.AutoSize = true;
            this.isadmin.Location = new System.Drawing.Point(1114, 1);
            this.isadmin.Name = "isadmin";
            this.isadmin.Size = new System.Drawing.Size(0, 15);
            this.isadmin.TabIndex = 2;
            // 
            // Tedarikciler
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 614);
            this.Controls.Add(this.isadmin);
            this.Controls.Add(this.tedarikcilerr);
            this.Controls.Add(this.homebutton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tedarikciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Bilgileri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Calisan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.ListView tedarikcilerr;
        private System.Windows.Forms.ColumnHeader tedarikciadi;
        private System.Windows.Forms.ColumnHeader adres;
        public System.Windows.Forms.Label isadmin;
    }
}

