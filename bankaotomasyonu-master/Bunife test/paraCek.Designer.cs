namespace Bunife_test
{
    partial class paraCek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paraCek));
            this.txtCekilecekMiktari = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblHesapBakiyesi = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.drpHesapNo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCekilecekMiktari
            // 
            this.txtCekilecekMiktari.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtCekilecekMiktari.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCekilecekMiktari.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtCekilecekMiktari.BorderThickness = 3;
            this.txtCekilecekMiktari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCekilecekMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCekilecekMiktari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCekilecekMiktari.isPassword = false;
            this.txtCekilecekMiktari.Location = new System.Drawing.Point(4, 80);
            this.txtCekilecekMiktari.Margin = new System.Windows.Forms.Padding(4);
            this.txtCekilecekMiktari.Name = "txtCekilecekMiktari";
            this.txtCekilecekMiktari.Size = new System.Drawing.Size(397, 44);
            this.txtCekilecekMiktari.TabIndex = 0;
            this.txtCekilecekMiktari.Text = "Çekilecek Para Miktarı";
            this.txtCekilecekMiktari.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCekilecekMiktari.Enter += new System.EventHandler(this.txtCekilecekMiktari_Enter);
            this.txtCekilecekMiktari.Leave += new System.EventHandler(this.txtCekilecekMiktari_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hesap Numarası";
            // 
            // btnEkle
            // 
            this.btnEkle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.BorderRadius = 0;
            this.btnEkle.ButtonText = "Para Çek";
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
            this.btnEkle.Location = new System.Drawing.Point(4, 138);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnEkle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEkle.selected = false;
            this.btnEkle.Size = new System.Drawing.Size(179, 50);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Para Çek";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Textcolor = System.Drawing.Color.White;
            this.btnEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblHesapBakiyesi
            // 
            this.lblHesapBakiyesi.AutoSize = true;
            this.lblHesapBakiyesi.BackColor = System.Drawing.Color.Transparent;
            this.lblHesapBakiyesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapBakiyesi.Location = new System.Drawing.Point(3, 47);
            this.lblHesapBakiyesi.Name = "lblHesapBakiyesi";
            this.lblHesapBakiyesi.Size = new System.Drawing.Size(122, 20);
            this.lblHesapBakiyesi.TabIndex = 12;
            this.lblHesapBakiyesi.Text = "Hesap Bakiyesi:";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBakiye.Location = new System.Drawing.Point(140, 47);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(0, 20);
            this.lblBakiye.TabIndex = 11;
            // 
            // drpHesapNo
            // 
            this.drpHesapNo.FormattingEnabled = true;
            this.drpHesapNo.Location = new System.Drawing.Point(144, 11);
            this.drpHesapNo.Name = "drpHesapNo";
            this.drpHesapNo.Size = new System.Drawing.Size(257, 21);
            this.drpHesapNo.TabIndex = 13;
            this.drpHesapNo.SelectedIndexChanged += new System.EventHandler(this.drpHesapNo_SelectedIndexChanged);
            // 
            // paraCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drpHesapNo);
            this.Controls.Add(this.lblHesapBakiyesi);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCekilecekMiktari);
            this.Name = "paraCek";
            this.Size = new System.Drawing.Size(474, 375);
            this.VisibleChanged += new System.EventHandler(this.paraCek_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtCekilecekMiktari;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEkle;
        private System.Windows.Forms.Label lblHesapBakiyesi;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.ComboBox drpHesapNo;
    }
}
