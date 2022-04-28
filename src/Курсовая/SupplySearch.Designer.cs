
namespace Курсовая
{
    partial class SupplySearch
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.shopDataBase = new Курсовая.ShopDataBase();
            this.поставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставкаTableAdapter = new Курсовая.ShopDataBaseTableAdapters.ПоставкаTableAdapter();
            this.поставкаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(423, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 22);
            this.textBox1.TabIndex = 0;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(423, 98);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(205, 40);
            this.search.TabIndex = 1;
            this.search.Text = "Искать";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // shopDataBase
            // 
            this.shopDataBase.DataSetName = "ShopDataBase";
            this.shopDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставкаBindingSource
            // 
            this.поставкаBindingSource.DataMember = "Поставка";
            this.поставкаBindingSource.DataSource = this.shopDataBase;
            // 
            // поставкаTableAdapter
            // 
            this.поставкаTableAdapter.ClearBeforeFill = true;
            // 
            // поставкаBindingSource1
            // 
            this.поставкаBindingSource1.DataMember = "Поставка";
            this.поставкаBindingSource1.DataSource = this.shopDataBase;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(325, 141);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите страну:";
            // 
            // SupplySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox1);
            this.Name = "SupplySearch";
            this.Text = "Поиск поставки";
            this.Load += new System.EventHandler(this.SupplyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search;
        private ShopDataBase shopDataBase;
        private System.Windows.Forms.BindingSource поставкаBindingSource;
        private ShopDataBaseTableAdapters.ПоставкаTableAdapter поставкаTableAdapter;
        private System.Windows.Forms.BindingSource поставкаBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}