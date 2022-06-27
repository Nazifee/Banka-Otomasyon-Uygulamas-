namespace Bunife_test
{
    partial class hesapEkle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMusteriNo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnHesapAc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHesapListele = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lstwHesaplar = new System.Windows.Forms.ListView();
            this.hesapNumarasi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bakiye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtMusteriNo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMusteriNo.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtMusteriNo.BorderThickness = 3;
            this.txtMusteriNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMusteriNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMusteriNo.isPassword = false;
            this.txtMusteriNo.Location = new System.Drawing.Point(4, 4);
            this.txtMusteriNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(370, 44);
            this.txtMusteriNo.TabIndex = 1;
            this.txtMusteriNo.Text = "Müşteri Numarası";
            this.txtMusteriNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMusteriNo.Enter += new System.EventHandler(this.txtMusteriNo_Enter);
            this.txtMusteriNo.Leave += new System.EventHandler(this.txtMusteriNo_Leave);
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnHesapAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnHesapAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapAc.BorderRadius = 0;
            this.btnHesapAc.ButtonText = "Hesap Ekle";
            this.btnHesapAc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapAc.DisabledColor = System.Drawing.Color.Gray;
            this.btnHesapAc.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHesapAc.Iconimage = global::Bunife_test.Properties.Resources.check;
            this.btnHesapAc.Iconimage_right = null;
            this.btnHesapAc.Iconimage_right_Selected = null;
            this.btnHesapAc.Iconimage_Selected = null;
            this.btnHesapAc.IconMarginLeft = 0;
            this.btnHesapAc.IconMarginRight = 0;
            this.btnHesapAc.IconRightVisible = true;
            this.btnHesapAc.IconRightZoom = 0D;
            this.btnHesapAc.IconVisible = true;
            this.btnHesapAc.IconZoom = 40D;
            this.btnHesapAc.IsTab = false;
            this.btnHesapAc.Location = new System.Drawing.Point(6, 55);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnHesapAc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnHesapAc.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHesapAc.selected = false;
            this.btnHesapAc.Size = new System.Drawing.Size(138, 48);
            this.btnHesapAc.TabIndex = 1;
            this.btnHesapAc.Text = "Hesap Ekle";
            this.btnHesapAc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapAc.Textcolor = System.Drawing.Color.White;
            this.btnHesapAc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // btnHesapListele
            // 
            this.btnHesapListele.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnHesapListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnHesapListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapListele.BorderRadius = 0;
            this.btnHesapListele.ButtonText = "Hesap Listele";
            this.btnHesapListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapListele.DisabledColor = System.Drawing.Color.Gray;
            this.btnHesapListele.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHesapListele.Iconimage = global::Bunife_test.Properties.Resources.check;
            this.btnHesapListele.Iconimage_right = null;
            this.btnHesapListele.Iconimage_right_Selected = null;
            this.btnHesapListele.Iconimage_Selected = null;
            this.btnHesapListele.IconMarginLeft = 0;
            this.btnHesapListele.IconMarginRight = 0;
            this.btnHesapListele.IconRightVisible = true;
            this.btnHesapListele.IconRightZoom = 0D;
            this.btnHesapListele.IconVisible = true;
            this.btnHesapListele.IconZoom = 40D;
            this.btnHesapListele.IsTab = false;
            this.btnHesapListele.Location = new System.Drawing.Point(164, 55);
            this.btnHesapListele.Name = "btnHesapListele";
            this.btnHesapListele.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnHesapListele.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnHesapListele.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHesapListele.selected = false;
            this.btnHesapListele.Size = new System.Drawing.Size(145, 48);
            this.btnHesapListele.TabIndex = 2;
            this.btnHesapListele.Text = "Hesap Listele";
            this.btnHesapListele.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapListele.Textcolor = System.Drawing.Color.White;
            this.btnHesapListele.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapListele.Click += new System.EventHandler(this.btnHesapListele_Click);
            // 
            // lstwHesaplar
            // 
            this.lstwHesaplar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hesapNumarasi,
            this.bakiye});
            this.lstwHesaplar.Location = new System.Drawing.Point(0, 133);
            this.lstwHesaplar.Name = "lstwHesaplar";
            this.lstwHesaplar.Size = new System.Drawing.Size(524, 160);
            this.lstwHesaplar.TabIndex = 3;
            this.lstwHesaplar.UseCompatibleStateImageBehavior = false;
            this.lstwHesaplar.View = System.Windows.Forms.View.Details;
            // 
            // hesapNumarasi
            // 
            this.hesapNumarasi.Text = "Hesap Numarası";
            this.hesapNumarasi.Width = 166;
            // 
            // bakiye
            // 
            this.bakiye.Text = "Bakiye";
            this.bakiye.Width = 217;
            // 
            // hesapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstwHesaplar);
            this.Controls.Add(this.btnHesapListele);
            this.Controls.Add(this.btnHesapAc);
            this.Controls.Add(this.txtMusteriNo);
            this.Name = "hesapEkle";
            this.Size = new System.Drawing.Size(524, 389);
            this.Load += new System.EventHandler(this.hesapEkle_Load);
            this.VisibleChanged += new System.EventHandler(this.hesapEkle_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtMusteriNo;
        private Bunifu.Framework.UI.BunifuFlatButton btnHesapAc;
        private Bunifu.Framework.UI.BunifuFlatButton btnHesapListele;
        private System.Windows.Forms.ListView lstwHesaplar;
        private System.Windows.Forms.ColumnHeader hesapNumarasi;
        private System.Windows.Forms.ColumnHeader bakiye;
    }
}
