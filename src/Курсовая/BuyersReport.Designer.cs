
namespace Курсовая
{
    partial class BuyersReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ShopDataBase = new Курсовая.ShopDataBase();
            this.ПокупателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ПокупателиTableAdapter = new Курсовая.ShopDataBaseTableAdapters.ПокупателиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ПокупателиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ПокупателиBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Курсовая.BuyersReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(69, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(673, 345);
            this.reportViewer1.TabIndex = 0;
            // 
            // ShopDataBase
            // 
            this.ShopDataBase.DataSetName = "ShopDataBase";
            this.ShopDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ПокупателиBindingSource
            // 
            this.ПокупателиBindingSource.DataMember = "Покупатели";
            this.ПокупателиBindingSource.DataSource = this.ShopDataBase;
            // 
            // ПокупателиTableAdapter
            // 
            this.ПокупателиTableAdapter.ClearBeforeFill = true;
            // 
            // BuyersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BuyersReport";
            this.Text = "Отчёт о покупателях";
            this.Load += new System.EventHandler(this.BuyersReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ПокупателиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ПокупателиBindingSource;
        private ShopDataBase ShopDataBase;
        private ShopDataBaseTableAdapters.ПокупателиTableAdapter ПокупателиTableAdapter;
    }
}