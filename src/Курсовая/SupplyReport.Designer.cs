
namespace Курсовая
{
    partial class SupplyReport
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
            this.ПоставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShopDataBase = new Курсовая.ShopDataBase();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ПоставкаTableAdapter = new Курсовая.ShopDataBaseTableAdapters.ПоставкаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ПоставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // ПоставкаBindingSource
            // 
            this.ПоставкаBindingSource.DataMember = "Поставка";
            this.ПоставкаBindingSource.DataSource = this.ShopDataBase;
            // 
            // ShopDataBase
            // 
            this.ShopDataBase.DataSetName = "ShopDataBase";
            this.ShopDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ПоставкаBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Курсовая.SupplyReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(119, 112);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(503, 235);
            this.reportViewer1.TabIndex = 0;
            // 
            // ПоставкаTableAdapter
            // 
            this.ПоставкаTableAdapter.ClearBeforeFill = true;
            // 
            // SupplyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SupplyReport";
            this.Text = "Отчёт о поставках";
            this.Load += new System.EventHandler(this.SupplyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ПоставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ПоставкаBindingSource;
        private ShopDataBase ShopDataBase;
        private ShopDataBaseTableAdapters.ПоставкаTableAdapter ПоставкаTableAdapter;
    }
}