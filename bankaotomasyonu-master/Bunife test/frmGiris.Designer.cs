namespace Bunife_test
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.sidePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pctMusteri = new System.Windows.Forms.PictureBox();
            this.pctYonetici = new System.Windows.Forms.PictureBox();
            this.btnMusteriGiris = new System.Windows.Forms.Button();
            this.btnYoneticiGiris = new System.Windows.Forms.Button();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctYonetici)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AllowDrop = true;
            this.sidePanel.BackColor = System.Drawing.SystemColors.Control;
            this.sidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidePanel.BackgroundImage")));
            this.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidePanel.Controls.Add(this.btnClose);
            this.sidePanel.Controls.Add(this.pctMusteri);
            this.sidePanel.Controls.Add(this.pctYonetici);
            this.sidePanel.Controls.Add(this.btnMusteriGiris);
            this.sidePanel.Controls.Add(this.btnYoneticiGiris);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.sidePanel.GradientBottomLeft = System.Drawing.Color.Turquoise;
            this.sidePanel.GradientBottomRight = System.Drawing.Color.Black;
            this.sidePanel.GradientTopLeft = System.Drawing.Color.DarkViolet;
            this.sidePanel.GradientTopRight = System.Drawing.Color.RoyalBlue;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Quality = 10;
            this.sidePanel.Size = new System.Drawing.Size(405, 356);
            this.sidePanel.TabIndex = 1;
            this.sidePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sidePanel_MouseDown);
            this.sidePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sidePanel_MouseMove);
            this.sidePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sidePanel_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::Bunife_test.Properties.Resources.closeButton;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(344, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 51);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pctMusteri
            // 
            this.pctMusteri.BackColor = System.Drawing.Color.Transparent;
            this.pctMusteri.Image = ((System.Drawing.Image)(resources.GetObject("pctMusteri.Image")));
            this.pctMusteri.Location = new System.Drawing.Point(12, 200);
            this.pctMusteri.Name = "pctMusteri";
            this.pctMusteri.Size = new System.Drawing.Size(100, 105);
            this.pctMusteri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMusteri.TabIndex = 2;
            this.pctMusteri.TabStop = false;
            // 
            // pctYonetici
            // 
            this.pctYonetici.BackColor = System.Drawing.Color.Transparent;
            this.pctYonetici.Image = ((System.Drawing.Image)(resources.GetObject("pctYonetici.Image")));
            this.pctYonetici.Location = new System.Drawing.Point(13, 52);
            this.pctYonetici.Name = "pctYonetici";
            this.pctYonetici.Size = new System.Drawing.Size(100, 105);
            this.pctYonetici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctYonetici.TabIndex = 2;
            this.pctYonetici.TabStop = false;
            // 
            // btnMusteriGiris
            // 
            this.btnMusteriGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnMusteriGiris.FlatAppearance.BorderSize = 0;
            this.btnMusteriGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMusteriGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMusteriGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriGiris.ForeColor = System.Drawing.Color.Transparent;
            this.btnMusteriGiris.Location = new System.Drawing.Point(119, 200);
            this.btnMusteriGiris.Name = "btnMusteriGiris";
            this.btnMusteriGiris.Size = new System.Drawing.Size(275, 105);
            this.btnMusteriGiris.TabIndex = 2;
            this.btnMusteriGiris.Text = "Müşteri Giriş";
            this.btnMusteriGiris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriGiris.UseVisualStyleBackColor = false;
            this.btnMusteriGiris.Click += new System.EventHandler(this.btnMusteriGiris_Click);
            // 
            // btnYoneticiGiris
            // 
            this.btnYoneticiGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnYoneticiGiris.FlatAppearance.BorderSize = 0;
            this.btnYoneticiGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnYoneticiGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnYoneticiGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoneticiGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiGiris.ForeColor = System.Drawing.Color.Transparent;
            this.btnYoneticiGiris.Location = new System.Drawing.Point(119, 52);
            this.btnYoneticiGiris.Name = "btnYoneticiGiris";
            this.btnYoneticiGiris.Size = new System.Drawing.Size(275, 105);
            this.btnYoneticiGiris.TabIndex = 1;
            this.btnYoneticiGiris.Text = "Yönetici Giriş";
            this.btnYoneticiGiris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYoneticiGiris.UseVisualStyleBackColor = false;
            this.btnYoneticiGiris.Click += new System.EventHandler(this.btnYoneticiGiris_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 356);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiris";
            this.Text = "frmGiris";
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctYonetici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel sidePanel;
        private System.Windows.Forms.Button btnYoneticiGiris;
        private System.Windows.Forms.PictureBox pctMusteri;
        private System.Windows.Forms.PictureBox pctYonetici;
        private System.Windows.Forms.Button btnMusteriGiris;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
    }
}