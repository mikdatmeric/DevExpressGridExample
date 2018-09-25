namespace DevExpressGridExample.UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtMalKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBitisTarihi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaslangicTarihi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.smpBtnDosyayaKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.smpBtnYazdır = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.txtMalKodu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBitisTarihi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBaslangicTarihi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 77);
            this.panel1.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAra.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(1262, 44);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(107, 30);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtMalKodu
            // 
            this.txtMalKodu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMalKodu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMalKodu.Location = new System.Drawing.Point(962, 19);
            this.txtMalKodu.Name = "txtMalKodu";
            this.txtMalKodu.Size = new System.Drawing.Size(185, 22);
            this.txtMalKodu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(829, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mal Kodu :";
            // 
            // txtBitisTarihi
            // 
            this.txtBitisTarihi.Location = new System.Drawing.Point(561, 18);
            this.txtBitisTarihi.Name = "txtBitisTarihi";
            this.txtBitisTarihi.Size = new System.Drawing.Size(185, 22);
            this.txtBitisTarihi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(428, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitiş Tarihi :";
            // 
            // txtBaslangicTarihi
            // 
            this.txtBaslangicTarihi.Location = new System.Drawing.Point(150, 17);
            this.txtBaslangicTarihi.Name = "txtBaslangicTarihi";
            this.txtBaslangicTarihi.Size = new System.Drawing.Size(185, 22);
            this.txtBaslangicTarihi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi :";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 137);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1372, 517);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.smpBtnDosyayaKaydet);
            this.panelControl1.Controls.Add(this.smpBtnYazdır);
            this.panelControl1.Location = new System.Drawing.Point(12, 95);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1372, 36);
            this.panelControl1.TabIndex = 2;
            // 
            // smpBtnDosyayaKaydet
            // 
            this.smpBtnDosyayaKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("smpBtnDosyayaKaydet.ImageOptions.Image")));
            this.smpBtnDosyayaKaydet.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.smpBtnDosyayaKaydet.Location = new System.Drawing.Point(1273, 2);
            this.smpBtnDosyayaKaydet.Name = "smpBtnDosyayaKaydet";
            this.smpBtnDosyayaKaydet.Size = new System.Drawing.Size(45, 29);
            this.smpBtnDosyayaKaydet.TabIndex = 3;
            this.smpBtnDosyayaKaydet.ToolTip = "Dosyaya Kaydet";
            this.smpBtnDosyayaKaydet.Click += new System.EventHandler(this.smpBtnDosyayaKaydet_Click);
            // 
            // smpBtnYazdır
            // 
            this.smpBtnYazdır.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("smpBtnYazdır.ImageOptions.Image")));
            this.smpBtnYazdır.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.smpBtnYazdır.Location = new System.Drawing.Point(1324, 2);
            this.smpBtnYazdır.Name = "smpBtnYazdır";
            this.smpBtnYazdır.Size = new System.Drawing.Size(43, 29);
            this.smpBtnYazdır.TabIndex = 0;
            this.smpBtnYazdır.ToolTip = "Yazdır";
            this.smpBtnYazdır.Click += new System.EventHandler(this.smpBtnYazdır_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 666);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtMalKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBitisTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaslangicTarihi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton smpBtnDosyayaKaydet;
        private DevExpress.XtraEditors.SimpleButton smpBtnYazdır;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

