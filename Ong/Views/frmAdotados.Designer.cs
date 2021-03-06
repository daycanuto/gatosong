﻿namespace Ong.Views
{
    partial class frmAdotados
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsBanco = new Ong.BancoDs.dsBanco();
            this.dsAdocaoStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAdocaoStatusTableAdapter = new Ong.BancoDs.dsBancoTableAdapters.dsAdocaoStatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdocaoStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportAdotados";
            reportDataSource1.Value = this.dsAdocaoStatusBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ong.Reports.ReportAdotados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(619, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsBanco
            // 
            this.dsBanco.DataSetName = "dsBanco";
            this.dsBanco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsAdocaoStatusBindingSource
            // 
            this.dsAdocaoStatusBindingSource.DataMember = "dsAdocaoStatus";
            this.dsAdocaoStatusBindingSource.DataSource = this.dsBanco;
            // 
            // dsAdocaoStatusTableAdapter
            // 
            this.dsAdocaoStatusTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdotados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmAdotados";
            this.Text = "Gatos Adotados";
            this.Load += new System.EventHandler(this.frmAdotados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdocaoStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BancoDs.dsBanco dsBanco;
        private System.Windows.Forms.BindingSource dsAdocaoStatusBindingSource;
        private BancoDs.dsBancoTableAdapters.dsAdocaoStatusTableAdapter dsAdocaoStatusTableAdapter;
    }
}