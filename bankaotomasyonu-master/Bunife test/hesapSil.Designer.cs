namespace Bunife_test
{
    partial class hesapSil
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
            this.btnHesapSil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.drpHesapNo = new System.Windows.Forms.ComboBox();
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
            this.txtMusteriNo.TabIndex = 2;
            this.txtMusteriNo.Text = "Müşteri Numarası";
            this.txtMusteriNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMusteriNo.OnValueChanged += new System.EventHandler(this.txtMusteriNo_OnValueChanged);
            this.txtMusteriNo.Enter += new System.EventHandler(this.txtMusteriNo_Enter);
            this.txtMusteriNo.Leave += new System.EventHandler(this.txtMusteriNo_Leave);
            // 
            // btnHesapSil
            // 
            this.btnHesapSil.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnHesapSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnHesapSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapSil.BorderRadius = 0;
            this.btnHesapSil.ButtonText = "Hesap Sil";
            this.btnHesapSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapSil.DisabledColor = System.Drawing.Color.Gray;
            this.btnHesapSil.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHesapSil.Iconimage = global::Bunife_test.Properties.Resources.clean;
            this.btnHesapSil.Iconimage_right = null;
            this.btnHesapSil.Iconimage_right_Selected = null;
            this.btnHesapSil.Iconimage_Selected = null;
            this.btnHesapSil.IconMarginLeft = 0;
            this.btnHesapSil.IconMarginRight = 0;
            this.btnHesapSil.IconRightVisible = true;
            this.btnHesapSil.IconRightZoom = 0D;
            this.btnHesapSil.IconVisible = true;
            this.btnHesapSil.IconZoom = 40D;
            this.btnHesapSil.IsTab = false;
            this.btnHesapSil.Location = new System.Drawing.Point(6, 96);
            this.btnHesapSil.Name = "btnHesapSil";
            this.btnHesapSil.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnHesapSil.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.btnHesapSil.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHesapSil.selected = false;
            this.btnHesapSil.Size = new System.Drawing.Size(241, 48);
            this.btnHesapSil.TabIndex = 3;
            this.btnHesapSil.Text = "Hesap Sil";
            this.btnHesapSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapSil.Textcolor = System.Drawing.Color.White;
            this.btnHesapSil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapSil.Click += new System.EventHandler(this.btnHesapSil_Click);
            // 
            // drpHesapNo
            // 
            this.drpHesapNo.FormattingEnabled = true;
            this.drpHesapNo.Location = new System.Drawing.Point(6, 65);
            this.drpHesapNo.Name = "drpHesapNo";
            this.drpHesapNo.Size = new System.Drawing.Size(241, 21);
            this.drpHesapNo.TabIndex = 4;
            // 
            // hesapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drpHesapNo);
            this.Controls.Add(this.btnHesapSil);
            this.Controls.Add(this.txtMusteriNo);
            this.Name = "hesapSil";
            this.Size = new System.Drawing.Size(396, 330);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtMusteriNo;
        private Bunifu.Framework.UI.BunifuFlatButton btnHesapSil;
        private System.Windows.Forms.ComboBox drpHesapNo;
    }
}
