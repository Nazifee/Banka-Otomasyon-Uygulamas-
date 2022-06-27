namespace Bunife_test
{
    partial class uHesapOzeti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uHesapOzeti));
            this.lstwHesapOzeti = new System.Windows.Forms.ListView();
            this.islemTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yapilanIslem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tutar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bakiye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHesapOzeti = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHesapBakiyesi = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.drpHesapNo = new System.Windows.Forms.ComboBox();
            this.islemUcreti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstwHesapOzeti
            // 
            this.lstwHesapOzeti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.islemTarihi,
            this.yapilanIslem,
            this.Tutar,
            this.Bakiye,
            this.islemUcreti});
            this.lstwHesapOzeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstwHesapOzeti.Location = new System.Drawing.Point(3, 130);
            this.lstwHesapOzeti.Name = "lstwHesapOzeti";
            this.lstwHesapOzeti.Size = new System.Drawing.Size(645, 264);
            this.lstwHesapOzeti.TabIndex = 3;
            this.lstwHesapOzeti.UseCompatibleStateImageBehavior = false;
            this.lstwHesapOzeti.View = System.Windows.Forms.View.Details;
            // 
            // islemTarihi
            // 
            this.islemTarihi.Text = "İşlem Tarihi";
            this.islemTarihi.Width = 100;
            // 
            // yapilanIslem
            // 
            this.yapilanIslem.Text = "Yapılan İşlem";
            this.yapilanIslem.Width = 100;
            // 
            // Tutar
            // 
            this.Tutar.Text = "Tutar";
            this.Tutar.Width = 100;
            // 
            // Bakiye
            // 
            this.Bakiye.Text = "Bakiye";
            this.Bakiye.Width = 100;
            // 
            // btnHesapOzeti
            // 
            this.btnHesapOzeti.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnHesapOzeti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnHesapOzeti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapOzeti.BorderRadius = 0;
            this.btnHesapOzeti.ButtonText = "Hesap Özet";
            this.btnHesapOzeti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapOzeti.DisabledColor = System.Drawing.Color.Gray;
            this.btnHesapOzeti.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHesapOzeti.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHesapOzeti.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHesapOzeti.Iconimage")));
            this.btnHesapOzeti.Iconimage_right = null;
            this.btnHesapOzeti.Iconimage_right_Selected = null;
            this.btnHesapOzeti.Iconimage_Selected = null;
            this.btnHesapOzeti.IconMarginLeft = 0;
            this.btnHesapOzeti.IconMarginRight = 0;
            this.btnHesapOzeti.IconRightVisible = true;
            this.btnHesapOzeti.IconRightZoom = 0D;
            this.btnHesapOzeti.IconVisible = true;
            this.btnHesapOzeti.IconZoom = 40D;
            this.btnHesapOzeti.IsTab = true;
            this.btnHesapOzeti.Location = new System.Drawing.Point(3, 74);
            this.btnHesapOzeti.Name = "btnHesapOzeti";
            this.btnHesapOzeti.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnHesapOzeti.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnHesapOzeti.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHesapOzeti.selected = false;
            this.btnHesapOzeti.Size = new System.Drawing.Size(179, 50);
            this.btnHesapOzeti.TabIndex = 2;
            this.btnHesapOzeti.Text = "Hesap Özet";
            this.btnHesapOzeti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapOzeti.Textcolor = System.Drawing.Color.White;
            this.btnHesapOzeti.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapOzeti.Click += new System.EventHandler(this.btnHesapOzeti_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hesap Numarası";
            // 
            // lblHesapBakiyesi
            // 
            this.lblHesapBakiyesi.AutoSize = true;
            this.lblHesapBakiyesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapBakiyesi.Location = new System.Drawing.Point(408, 102);
            this.lblHesapBakiyesi.Name = "lblHesapBakiyesi";
            this.lblHesapBakiyesi.Size = new System.Drawing.Size(122, 20);
            this.lblHesapBakiyesi.TabIndex = 10;
            this.lblHesapBakiyesi.Text = "Hesap Bakiyesi:";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(539, 102);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(0, 20);
            this.lblBakiye.TabIndex = 9;
            // 
            // drpHesapNo
            // 
            this.drpHesapNo.FormattingEnabled = true;
            this.drpHesapNo.Location = new System.Drawing.Point(253, 7);
            this.drpHesapNo.Name = "drpHesapNo";
            this.drpHesapNo.Size = new System.Drawing.Size(229, 21);
            this.drpHesapNo.TabIndex = 11;
            this.drpHesapNo.SelectedIndexChanged += new System.EventHandler(this.drpHesapNo_SelectedIndexChanged);
            // 
            // islemUcreti
            // 
            this.islemUcreti.Text = "İşlem Ücreti";
            this.islemUcreti.Width = 100;
            // 
            // uHesapOzeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drpHesapNo);
            this.Controls.Add(this.lblHesapBakiyesi);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHesapOzeti);
            this.Controls.Add(this.lstwHesapOzeti);
            this.Name = "uHesapOzeti";
            this.Size = new System.Drawing.Size(651, 435);
            this.VisibleChanged += new System.EventHandler(this.uHesapOzeti_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstwHesapOzeti;
        private System.Windows.Forms.ColumnHeader islemTarihi;
        private System.Windows.Forms.ColumnHeader yapilanIslem;
        private System.Windows.Forms.ColumnHeader Tutar;
        private Bunifu.Framework.UI.BunifuFlatButton btnHesapOzeti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHesapBakiyesi;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.ComboBox drpHesapNo;
        private System.Windows.Forms.ColumnHeader Bakiye;
        private System.Windows.Forms.ColumnHeader islemUcreti;
    }
}
