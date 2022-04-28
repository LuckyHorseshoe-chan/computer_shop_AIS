
namespace Курсовая
{
    partial class MakersReport
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
            this.ShopDataBase = new Курсовая.ShopDataBase();
            this.ПроизводителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ПроизводителиTableAdapter = new Курсовая.ShopDataBaseTableAdapters.ПроизводителиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ПроизводителиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ПроизводителиBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Курсовая.MakersReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(78, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(575, 282);
            this.reportViewer1.TabIndex = 0;
            // 
            // ShopDataBase
            // 
            this.ShopDataBase.DataSetName = "ShopDataBase";
            this.ShopDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ПроизводителиBindingSource
            // 
            this.ПроизводителиBindingSource.DataMember = "Производители";
            this.ПроизводителиBindingSource.DataSource = this.ShopDataBase;
            // 
            // ПроизводителиTableAdapter
            // 
            this.ПроизводителиTableAdapter.ClearBeforeFill = true;
            // 
            // MakersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MakersReport";
            this.Text = "Отчёт о производителях";
            this.Load += new System.EventHandler(this.MakersReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ПроизводителиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ПроизводителиBindingSource;
        private ShopDataBase ShopDataBase;
        private ShopDataBaseTableAdapters.ПроизводителиTableAdapter ПроизводителиTableAdapter;
    }
}