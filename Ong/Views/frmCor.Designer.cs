namespace Ong.Views
{
    partial class frmCor
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.gatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBanco = new Ong.BancoDs.dsBanco();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gatoTableAdapter = new Ong.BancoDs.dsBancoTableAdapters.GatoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // gatoBindingSource
            // 
            this.gatoBindingSource.DataMember = "Gato";
            this.gatoBindingSource.DataSource = this.dsBanco;
            // 
            // dsBanco
            // 
            this.dsBanco.DataSetName = "dsBanco";
            this.dsBanco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReportCor";
            reportDataSource1.Value = this.gatoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ong.Reports.ReportCor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(653, 255);
            this.reportViewer1.TabIndex = 0;
            // 
            // gatoTableAdapter
            // 
            this.gatoTableAdapter.ClearBeforeFill = true;
            // 
            // frmCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmCor";
            this.Text = "frmCor";
            this.Load += new System.EventHandler(this.frmCor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBanco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BancoDs.dsBanco dsBanco;
        private System.Windows.Forms.BindingSource gatoBindingSource;
        private BancoDs.dsBancoTableAdapters.GatoTableAdapter gatoTableAdapter;
    }
}