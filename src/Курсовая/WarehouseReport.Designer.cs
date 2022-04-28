
namespace Курсовая
{
    partial class WarehouseReport
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
            this.СкладBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShopDataBase = new Курсовая.ShopDataBase();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.СкладTableAdapter = new Курсовая.ShopDataBaseTableAdapters.СкладTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.СкладBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // СкладBindingSource
            // 
            this.СкладBindingSource.DataMember = "Склад";
            this.СкладBindingSource.DataSource = this.ShopDataBase;
            // 
            // ShopDataBase
            // 
            this.ShopDataBase.DataSetName = "ShopDataBase";
            this.ShopDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.СкладBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Курсовая.WarehouseReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(55, 47);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(610, 350);
            this.reportViewer1.TabIndex = 0;
            // 
            // СкладTableAdapter
            // 
            this.СкладTableAdapter.ClearBeforeFill = true;
            // 
            // WarehouseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "WarehouseReport";
            this.Text = "Отчёт о складах";
            this.Load += new System.EventHandler(this.WarehouseReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.СкладBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource СкладBindingSource;
        private ShopDataBase ShopDataBase;
        private ShopDataBaseTableAdapters.СкладTableAdapter СкладTableAdapter;
    }
}