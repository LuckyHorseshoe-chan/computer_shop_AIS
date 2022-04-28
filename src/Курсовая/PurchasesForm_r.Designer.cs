
namespace Курсовая
{
    partial class PurchasesForm_r
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasesForm_r));
            this.search = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.shopDataBase = new Курсовая.ShopDataBase();
            this.покупкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.покупкиTableAdapter = new Курсовая.ShopDataBaseTableAdapters.ПокупкиTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDпокупкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDпокупателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDпроизводителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.доставкаDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(20, 316);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(125, 40);
            this.search.TabIndex = 3;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(583, 202);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(126, 39);
            this.back.TabIndex = 6;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(583, 131);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(126, 43);
            this.report.TabIndex = 5;
            this.report.Text = "Отчёт";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.покупкиBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 31);
            this.bindingNavigator1.TabIndex = 7;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // shopDataBase
            // 
            this.shopDataBase.DataSetName = "ShopDataBase";
            this.shopDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // покупкиBindingSource
            // 
            this.покупкиBindingSource.DataMember = "Покупки";
            this.покупкиBindingSource.DataSource = this.shopDataBase;
            // 
            // покупкиTableAdapter
            // 
            this.покупкиTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDпокупкиDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.iDпокупателяDataGridViewTextBoxColumn,
            this.iDпроизводителяDataGridViewTextBoxColumn,
            this.iDтовараDataGridViewTextBoxColumn,
            this.доставкаDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.покупкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(507, 226);
            this.dataGridView1.TabIndex = 8;
            // 
            // iDпокупкиDataGridViewTextBoxColumn
            // 
            this.iDпокупкиDataGridViewTextBoxColumn.DataPropertyName = "IDпокупки";
            this.iDпокупкиDataGridViewTextBoxColumn.HeaderText = "IDпокупки";
            this.iDпокупкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDпокупкиDataGridViewTextBoxColumn.Name = "iDпокупкиDataGridViewTextBoxColumn";
            this.iDпокупкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDпокупкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDпокупателяDataGridViewTextBoxColumn
            // 
            this.iDпокупателяDataGridViewTextBoxColumn.DataPropertyName = "IDпокупателя";
            this.iDпокупателяDataGridViewTextBoxColumn.HeaderText = "IDпокупателя";
            this.iDпокупателяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDпокупателяDataGridViewTextBoxColumn.Name = "iDпокупателяDataGridViewTextBoxColumn";
            this.iDпокупателяDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDпокупателяDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDпроизводителяDataGridViewTextBoxColumn
            // 
            this.iDпроизводителяDataGridViewTextBoxColumn.DataPropertyName = "IDпроизводителя";
            this.iDпроизводителяDataGridViewTextBoxColumn.HeaderText = "IDпроизводителя";
            this.iDпроизводителяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDпроизводителяDataGridViewTextBoxColumn.Name = "iDпроизводителяDataGridViewTextBoxColumn";
            this.iDпроизводителяDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDпроизводителяDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDтовараDataGridViewTextBoxColumn
            // 
            this.iDтовараDataGridViewTextBoxColumn.DataPropertyName = "IDтовара";
            this.iDтовараDataGridViewTextBoxColumn.HeaderText = "IDтовара";
            this.iDтовараDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDтовараDataGridViewTextBoxColumn.Name = "iDтовараDataGridViewTextBoxColumn";
            this.iDтовараDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDтовараDataGridViewTextBoxColumn.Width = 125;
            // 
            // доставкаDataGridViewCheckBoxColumn
            // 
            this.доставкаDataGridViewCheckBoxColumn.DataPropertyName = "Доставка";
            this.доставкаDataGridViewCheckBoxColumn.HeaderText = "Доставка";
            this.доставкаDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.доставкаDataGridViewCheckBoxColumn.Name = "доставкаDataGridViewCheckBoxColumn";
            this.доставкаDataGridViewCheckBoxColumn.ReadOnly = true;
            this.доставкаDataGridViewCheckBoxColumn.Width = 125;
            // 
            // PurchasesForm_r
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.report);
            this.Controls.Add(this.search);
            this.Name = "PurchasesForm_r";
            this.Text = "Покупки (только чтение)";
            this.Load += new System.EventHandler(this.PurchasesForm_r_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private ShopDataBase shopDataBase;
        private System.Windows.Forms.BindingSource покупкиBindingSource;
        private ShopDataBaseTableAdapters.ПокупкиTableAdapter покупкиTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDпокупкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDпокупателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDпроизводителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn доставкаDataGridViewCheckBoxColumn;
    }
}