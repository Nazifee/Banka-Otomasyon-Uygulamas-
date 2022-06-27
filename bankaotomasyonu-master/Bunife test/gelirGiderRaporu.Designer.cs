namespace Bunife_test
{
    partial class gelirGiderRaporu
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
            this.dtpTarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lstwGelirGider = new System.Windows.Forms.ListView();
            this.gelenToplam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gidenToplam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genelToplam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // dtpTarih
            // 
            this.dtpTarih.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpTarih.BorderRadius = 0;
            this.dtpTarih.ForeColor = System.Drawing.Color.White;
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTarih.FormatCustom = null;
            this.dtpTarih.Location = new System.Drawing.Point(56, 53);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(303, 36);
            this.dtpTarih.TabIndex = 0;
            this.dtpTarih.Value = new System.DateTime(2017, 12, 28, 18, 28, 12, 435);
            this.dtpTarih.onValueChanged += new System.EventHandler(this.dtpTarih_onValueChanged);
            // 
            // lstwGelirGider
            // 
            this.lstwGelirGider.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gelenToplam,
            this.gidenToplam,
            this.genelToplam});
            this.lstwGelirGider.Location = new System.Drawing.Point(0, 160);
            this.lstwGelirGider.Name = "lstwGelirGider";
            this.lstwGelirGider.Size = new System.Drawing.Size(451, 145);
            this.lstwGelirGider.TabIndex = 1;
            this.lstwGelirGider.UseCompatibleStateImageBehavior = false;
            this.lstwGelirGider.View = System.Windows.Forms.View.Details;
            // 
            // gelenToplam
            // 
            this.gelenToplam.Text = "Gelen Toplam";
            this.gelenToplam.Width = 164;
            // 
            // gidenToplam
            // 
            this.gidenToplam.Text = "Giden Toplam";
            this.gidenToplam.Width = 133;
            // 
            // genelToplam
            // 
            this.genelToplam.Text = "Genel Toplam";
            this.genelToplam.Width = 200;
            // 
            // gelirGiderRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstwGelirGider);
            this.Controls.Add(this.dtpTarih);
            this.Name = "gelirGiderRaporu";
            this.Size = new System.Drawing.Size(451, 352);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker dtpTarih;
        private System.Windows.Forms.ListView lstwGelirGider;
        private System.Windows.Forms.ColumnHeader gelenToplam;
        private System.Windows.Forms.ColumnHeader gidenToplam;
        private System.Windows.Forms.ColumnHeader genelToplam;

    }
}
