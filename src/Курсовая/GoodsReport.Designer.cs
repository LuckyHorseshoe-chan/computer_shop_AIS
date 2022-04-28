
namespace Курсовая
{
    partial class GoodsReport
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
            this.ТоварыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShopDataBase = new Курсовая.ShopDataBase();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ТоварыTableAdapter = new Курсовая.ShopDataBaseTableAdapters.ТоварыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ТоварыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // ТоварыBindingSource
            // 
            this.ТоварыBindingSource.DataMember = "Товары";
            this.ТоварыBindingSource.DataSource = this.ShopDataBase;
            // 
            // ShopDataBase
            // 
            this.ShopDataBase.DataSetName = "ShopDataBase";
            this.ShopDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ТоварыBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Курсовая.GoodsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(99, 108);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(547, 272);
            this.reportViewer1.TabIndex = 0;
            // 
            // ТоварыTableAdapter
            // 
            this.ТоварыTableAdapter.ClearBeforeFill = true;
            // 
            // GoodsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GoodsReport";
            this.Text = "Отчёт о товарах";
            this.Load += new System.EventHandler(this.GoodsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ТоварыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ТоварыBindingSource;
        private ShopDataBase ShopDataBase;
        private ShopDataBaseTableAdapters.ТоварыTableAdapter ТоварыTableAdapter;
    }
}