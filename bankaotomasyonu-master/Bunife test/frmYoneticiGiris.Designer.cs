namespace Bunife_test
{
    partial class frmYoneticiGiris
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYoneticiGiris));
            this.txtKullaniciAdi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnGiris = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sidePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKullaniciAdi.HintForeColor = System.Drawing.Color.DimGray;
            this.txtKullaniciAdi.HintText = "Kullanýcý Adý";
            this.txtKullaniciAdi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKullaniciAdi.isPassword = false;
            this.txtKullaniciAdi.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtKullaniciAdi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtKullaniciAdi.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtKullaniciAdi.LineThickness = 3;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(245, 120);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(370, 44);
            this.txtKullaniciAdi.TabIndex = 1;
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnGiris
            // 
            this.btnGiris.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnGiris.BackColor = System.Drawing.Color.White;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.BorderRadius = 5;
            this.btnGiris.ButtonText = "Giriþ Yap";
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.DisabledColor = System.Drawing.Color.Gray;
            this.btnGiris.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGiris.Iconimage = null;
            this.btnGiris.Iconimage_right = null;
            this.btnGiris.Iconimage_right_Selected = null;
            this.btnGiris.Iconimage_Selected = null;
            this.btnGiris.IconMarginLeft = 0;
            this.btnGiris.IconMarginRight = 0;
            this.btnGiris.IconRightVisible = true;
            this.btnGiris.IconRightZoom = 0D;
            this.btnGiris.IconVisible = true;
            this.btnGiris.IconZoom = 90D;
            this.btnGiris.IsTab = true;
            this.btnGiris.Location = new System.Drawing.Point(374, 302);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Normalcolor = System.Drawing.Color.White;
            this.btnGiris.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnGiris.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnGiris.selected = false;
            this.btnGiris.Size = new System.Drawing.Size(241, 48);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriþ Yap";
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGiris.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnGiris.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.AllowDrop = true;
            this.sidePanel.BackColor = System.Drawing.SystemColors.Control;
            this.sidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidePanel.BackgroundImage")));
            this.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.sidePanel.GradientBottomLeft = System.Drawing.Color.Turquoise;
            this.sidePanel.GradientBottomRight = System.Drawing.Color.Black;
            this.sidePanel.GradientTopLeft = System.Drawing.Color.DarkTurquoise;
            this.sidePanel.GradientTopRight = System.Drawing.Color.RoyalBlue;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Quality = 10;
            this.sidePanel.Size = new System.Drawing.Size(235, 427);
            this.sidePanel.TabIndex = 0;
            this.sidePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmYoneticiGiris_MouseDown);
            this.sidePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmYoneticiGiris_MouseMove);
            this.sidePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmYoneticiGiris_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::Bunife_test.Properties.Resources.closeButton;
            this.btnClose.ImageActive = global::Bunife_test.Properties.Resources.closeButtonDark;
            this.btnClose.Location = new System.Drawing.Point(618, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 51);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSifre.HintForeColor = System.Drawing.Color.DimGray;
            this.txtSifre.HintText = "Þifre";
            this.txtSifre.isPassword = true;
            this.txtSifre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtSifre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSifre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtSifre.LineThickness = 3;
            this.txtSifre.Location = new System.Drawing.Point(245, 210);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(370, 33);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSifre.OnValueChanged += new System.EventHandler(this.txtSifre_OnValueChanged);
            // 
            // frmYoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 427);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYoneticiGiris";
            this.Text = "Banka Otomasyonu";
            this.Load += new System.EventHandler(this.frmYoneticiGiris_Load_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmYoneticiGiris_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmYoneticiGiris_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmYoneticiGiris_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel sidePanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKullaniciAdi;
        private Bunifu.Framework.UI.BunifuFlatButton btnGiris;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSifre;
    }
}