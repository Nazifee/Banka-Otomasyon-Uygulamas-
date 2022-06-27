namespace Bunife_test
{
    partial class paraYatir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paraYatir));
            this.txtYatirilacakMiktar = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblHesapBakiyesi = new System.Windows.Forms.Label();
            this.btnEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.drpHesapNo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtYatirilacakMiktar
            // 
            this.txtYatirilacakMiktar.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.txtYatirilacakMiktar.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtYatirilacakMiktar.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.txtYatirilacakMiktar.BorderThickness = 3;
            this.txtYatirilacakMiktar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYatirilacakMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtYatirilacakMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtYatirilacakMiktar.isPassword = false;
            this.txtYatirilacakMiktar.Location = new System.Drawing.Point(4, 56);
            this.txtYatirilacakMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtYatirilacakMiktar.Name = "txtYatirilacakMiktar";
            this.txtYatirilacakMiktar.Size = new System.Drawing.Size(370, 44);
            this.txtYatirilacakMiktar.TabIndex = 2;
            this.txtYatirilacakMiktar.Text = "Yatırılacak Miktarı Giriniz";
            this.txtYatirilacakMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtYatirilacakMiktar.Enter += new System.EventHandler(this.txtYatirilacakMiktar_Enter);
            this.txtYatirilacakMiktar.Leave += new System.EventHandler(this.txtYatirilacakMiktar_Leave);
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(328, 133);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(0, 18);
            this.lblBakiye.TabIndex = 0;
            // 
            // lblHesapBakiyesi
            // 
            this.lblHesapBakiyesi.AutoSize = true;
            this.lblHesapBakiyesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapBakiyesi.Location = new System.Drawing.Point(206, 132);
            this.lblHesapBakiyesi.Name = "lblHesapBakiyesi";
            this.lblHesapBakiyesi.Size = new System.Drawing.Size(122, 20);
            this.lblHesapBakiyesi.TabIndex = 4;
            this.lblHesapBakiyesi.Text = "Hesap Bakiyesi:";
            // 
            // btnEkle
            // 
            this.btnEkle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.BorderRadius = 0;
            this.btnEkle.ButtonText = "Para Yatır";
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
            this.btnEkle.Location = new System.Drawing.Point(6, 117);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnEkle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEkle.selected = false;
            this.btnEkle.Size = new System.Drawing.Size(179, 50);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Para Yatır";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Textcolor = System.Drawing.Color.White;
            this.btnEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hesap Numarası :";
            // 
            // drpHesapNo
            // 
            this.drpHesapNo.FormattingEnabled = true;
            this.drpHesapNo.Location = new System.Drawing.Point(179, 16);
            this.drpHesapNo.Name = "drpHesapNo";
            this.drpHesapNo.Size = new System.Drawing.Size(195, 21);
            this.drpHesapNo.TabIndex = 7;
            this.drpHesapNo.SelectedIndexChanged += new System.EventHandler(this.drpHesapNo_onItemSelected);
            // 
            // paraYatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drpHesapNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHesapBakiyesi);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtYatirilacakMiktar);
            this.Name = "paraYatir";
            this.Size = new System.Drawing.Size(478, 264);
            this.Load += new System.EventHandler(this.paraYatir_Load);
            this.VisibleChanged += new System.EventHandler(this.paraYatir_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtYatirilacakMiktar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEkle;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblHesapBakiyesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpHesapNo;
    }
}
