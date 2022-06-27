namespace Bunife_test
{
    partial class musteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriEkle));
            this.txtAd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDogumTarihi = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtDogumYeri = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtSoyad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbBireysel = new System.Windows.Forms.RadioButton();
            this.rdbTicari = new System.Windows.Forms.RadioButton();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTemizle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lstwMusteriListele = new System.Windows.Forms.ListView();
            this.MusteriNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MusteriTipi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtAd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAd.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtAd.BorderThickness = 3;
            this.txtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAd.isPassword = false;
            this.txtAd.Location = new System.Drawing.Point(4, 4);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(190, 30);
            this.txtAd.TabIndex = 1;
            this.txtAd.Text = "Ad";
            this.txtAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAd.Enter += new System.EventHandler(this.txtAd_Enter);
            this.txtAd.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtDogumTarihi);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.txtDogumYeri);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtTc);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 220);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Doğum Tarihi";
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.dtDogumTarihi.BorderRadius = 0;
            this.dtDogumTarihi.ForeColor = System.Drawing.Color.White;
            this.dtDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtDogumTarihi.FormatCustom = null;
            this.dtDogumTarihi.Location = new System.Drawing.Point(4, 173);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(245, 36);
            this.dtDogumTarihi.TabIndex = 5;
            this.dtDogumTarihi.Value = new System.DateTime(1994, 5, 30, 0, 0, 0, 0);
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtDogumYeri.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDogumYeri.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtDogumYeri.BorderThickness = 3;
            this.txtDogumYeri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDogumYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDogumYeri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDogumYeri.isPassword = false;
            this.txtDogumYeri.Location = new System.Drawing.Point(4, 118);
            this.txtDogumYeri.Margin = new System.Windows.Forms.Padding(4);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(190, 30);
            this.txtDogumYeri.TabIndex = 4;
            this.txtDogumYeri.Text = "Doğum yeri";
            this.txtDogumYeri.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDogumYeri.Enter += new System.EventHandler(this.txtDogumYeri_Enter);
            this.txtDogumYeri.Leave += new System.EventHandler(this.txtDogumYeri_Leave);
            // 
            // txtSoyad
            // 
            this.txtSoyad.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtSoyad.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoyad.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtSoyad.BorderThickness = 3;
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoyad.isPassword = false;
            this.txtSoyad.Location = new System.Drawing.Point(4, 42);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(190, 30);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.Text = "Soyad";
            this.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoyad.Enter += new System.EventHandler(this.txtSoyad_Enter);
            this.txtSoyad.Leave += new System.EventHandler(this.txtSoyad_Leave);
            // 
            // txtTc
            // 
            this.txtTc.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtTc.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTc.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtTc.BorderThickness = 3;
            this.txtTc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTc.isPassword = false;
            this.txtTc.Location = new System.Drawing.Point(4, 80);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(190, 30);
            this.txtTc.TabIndex = 3;
            this.txtTc.Text = "TC Kimlik Numarası";
            this.txtTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTc.Enter += new System.EventHandler(this.txtTc_Enter);
            this.txtTc.Leave += new System.EventHandler(this.txtTc_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbBireysel);
            this.panel2.Controls.Add(this.rdbTicari);
            this.panel2.Controls.Add(this.txtAdres);
            this.panel2.Controls.Add(this.txtTelefon);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Location = new System.Drawing.Point(319, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 220);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rdbBireysel
            // 
            this.rdbBireysel.AutoSize = true;
            this.rdbBireysel.Checked = true;
            this.rdbBireysel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbBireysel.Location = new System.Drawing.Point(42, 189);
            this.rdbBireysel.Name = "rdbBireysel";
            this.rdbBireysel.Size = new System.Drawing.Size(75, 20);
            this.rdbBireysel.TabIndex = 4;
            this.rdbBireysel.TabStop = true;
            this.rdbBireysel.Text = "Bireysel";
            this.rdbBireysel.UseVisualStyleBackColor = true;
            // 
            // rdbTicari
            // 
            this.rdbTicari.AutoSize = true;
            this.rdbTicari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbTicari.Location = new System.Drawing.Point(118, 189);
            this.rdbTicari.Name = "rdbTicari";
            this.rdbTicari.Size = new System.Drawing.Size(60, 20);
            this.rdbTicari.TabIndex = 5;
            this.rdbTicari.Text = "Ticari";
            this.rdbTicari.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdres.Location = new System.Drawing.Point(4, 4);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(303, 103);
            this.txtAdres.TabIndex = 6;
            this.txtAdres.Text = "Adres";
            this.txtAdres.Enter += new System.EventHandler(this.txtAdres_Enter);
            this.txtAdres.Leave += new System.EventHandler(this.txtAdres_Leave);
            // 
            // txtTelefon
            // 
            this.txtTelefon.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtTelefon.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefon.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtTelefon.BorderThickness = 3;
            this.txtTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefon.isPassword = false;
            this.txtTelefon.Location = new System.Drawing.Point(4, 114);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(190, 30);
            this.txtTelefon.TabIndex = 7;
            this.txtTelefon.Text = "Telefon";
            this.txtTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefon.Enter += new System.EventHandler(this.txtTelefon_Enter);
            this.txtTelefon.Leave += new System.EventHandler(this.txtTelefon_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtEmail.BorderThickness = 3;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(4, 152);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 30);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // btnEkle
            // 
            this.btnEkle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.BorderRadius = 0;
            this.btnEkle.ButtonText = "Ekle";
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.DisabledColor = System.Drawing.Color.Gray;
            this.btnEkle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEkle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEkle.Iconimage")));
            this.btnEkle.Iconimage_right = null;
            this.btnEkle.Iconimage_right_Selected = null;
            this.btnEkle.Iconimage_Selected = null;
            this.btnEkle.IconMarginLeft = 0;
            this.btnEkle.IconMarginRight = 0;
            this.btnEkle.IconRightVisible = true;
            this.btnEkle.IconRightZoom = 0D;
            this.btnEkle.IconVisible = true;
            this.btnEkle.IconZoom = 40D;
            this.btnEkle.IsTab = true;
            this.btnEkle.Location = new System.Drawing.Point(646, 42);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnEkle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEkle.selected = false;
            this.btnEkle.Size = new System.Drawing.Size(140, 50);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Textcolor = System.Drawing.Color.White;
            this.btnEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.BorderRadius = 0;
            this.btnTemizle.ButtonText = "Temizle";
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.DisabledColor = System.Drawing.Color.Gray;
            this.btnTemizle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTemizle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Iconimage")));
            this.btnTemizle.Iconimage_right = null;
            this.btnTemizle.Iconimage_right_Selected = null;
            this.btnTemizle.Iconimage_Selected = null;
            this.btnTemizle.IconMarginLeft = 0;
            this.btnTemizle.IconMarginRight = 0;
            this.btnTemizle.IconRightVisible = true;
            this.btnTemizle.IconRightZoom = 0D;
            this.btnTemizle.IconVisible = true;
            this.btnTemizle.IconZoom = 40D;
            this.btnTemizle.IsTab = false;
            this.btnTemizle.Location = new System.Drawing.Point(646, 98);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnTemizle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnTemizle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTemizle.selected = false;
            this.btnTemizle.Size = new System.Drawing.Size(140, 50);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.Textcolor = System.Drawing.Color.White;
            this.btnTemizle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // lstwMusteriListele
            // 
            this.lstwMusteriListele.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MusteriNo,
            this.Ad,
            this.Soyad,
            this.Telefon,
            this.Email,
            this.MusteriTipi});
            this.lstwMusteriListele.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstwMusteriListele.Location = new System.Drawing.Point(0, 246);
            this.lstwMusteriListele.Name = "lstwMusteriListele";
            this.lstwMusteriListele.Size = new System.Drawing.Size(812, 205);
            this.lstwMusteriListele.TabIndex = 6;
            this.lstwMusteriListele.UseCompatibleStateImageBehavior = false;
            this.lstwMusteriListele.View = System.Windows.Forms.View.Details;
            // 
            // MusteriNo
            // 
            this.MusteriNo.Text = "Müşteri No";
            this.MusteriNo.Width = 66;
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.Text = "Soyad";
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 64;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 72;
            // 
            // MusteriTipi
            // 
            this.MusteriTipi.Text = "Müşteri Tipi";
            this.MusteriTipi.Width = 421;
            // 
            // musteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstwMusteriListele);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "musteriEkle";
            this.Size = new System.Drawing.Size(812, 451);
            this.Load += new System.EventHandler(this.musteriEkle_Load);
            this.VisibleChanged += new System.EventHandler(this.musteriEkle_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtAd;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSoyad;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTc;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDogumYeri;
        private Bunifu.Framework.UI.BunifuDatepicker dtDogumTarihi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAdres;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTelefon;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private System.Windows.Forms.RadioButton rdbBireysel;
        private System.Windows.Forms.RadioButton rdbTicari;
        private Bunifu.Framework.UI.BunifuFlatButton btnEkle;
        private Bunifu.Framework.UI.BunifuFlatButton btnTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstwMusteriListele;
        private System.Windows.Forms.ColumnHeader MusteriNo;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader MusteriTipi;
    }
}
