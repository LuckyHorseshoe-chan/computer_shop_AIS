
namespace Курсовая
{
    partial class GoodsForm_r
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsForm_r));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shopDataBase = new Курсовая.ShopDataBase();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарыTableAdapter = new Курсовая.ShopDataBaseTableAdapters.ТоварыTableAdapter();
            this.iDтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDпоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDскладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.report = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new Курсовая.ShopDataBaseTableAdapters.TableAdapterManager();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDтовараDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.iDпоставкиDataGridViewTextBoxColumn,
            this.iDскладаDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.товарыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(568, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // shopDataBase
            // 
            this.shopDataBase.DataSetName = "ShopDataBase";
            this.shopDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.shopDataBase;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
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
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            this.ценаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDпоставкиDataGridViewTextBoxColumn
            // 
            this.iDпоставкиDataGridViewTextBoxColumn.DataPropertyName = "IDпоставки";
            this.iDпоставкиDataGridViewTextBoxColumn.HeaderText = "IDпоставки";
            this.iDпоставкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDпоставкиDataGridViewTextBoxColumn.Name = "iDпоставкиDataGridViewTextBoxColumn";
            this.iDпоставкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDпоставкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDскладаDataGridViewTextBoxColumn
            // 
            this.iDскладаDataGridViewTextBoxColumn.DataPropertyName = "IDсклада";
            this.iDскладаDataGridViewTextBoxColumn.HeaderText = "IDсклада";
            this.iDскладаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDскладаDataGridViewTextBoxColumn.Name = "iDскладаDataGridViewTextBoxColumn";
            this.iDскладаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDскладаDataGridViewTextBoxColumn.Width = 125;
            // 
            // модельDataGridViewTextBoxColumn
            // 
            this.модельDataGridViewTextBoxColumn.DataPropertyName = "Модель";
            this.модельDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.модельDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.модельDataGridViewTextBoxColumn.Name = "модельDataGridViewTextBoxColumn";
            this.модельDataGridViewTextBoxColumn.ReadOnly = true;
            this.модельDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.товарыBindingSource;
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
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(622, 152);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(156, 39);
            this.report.TabIndex = 3;
            this.report.Text = "Отчёт";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(27, 358);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(126, 37);
            this.search.TabIndex = 5;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Курсовая.ShopDataBaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ПокупателиTableAdapter = null;
            this.tableAdapterManager1.ПокупкиTableAdapter = null;
            this.tableAdapterManager1.ПоставкаTableAdapter = null;
            this.tableAdapterManager1.ПроизводителиTableAdapter = null;
            this.tableAdapterManager1.СкладTableAdapter = null;
            this.tableAdapterManager1.ТоварыTableAdapter = this.товарыTableAdapter;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(622, 214);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(156, 39);
            this.back.TabIndex = 4;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // GoodsForm_r
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search);
            this.Controls.Add(this.back);
            this.Controls.Add(this.report);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GoodsForm_r";
            this.Text = "Товары (только чтение)";
            this.Load += new System.EventHandler(this.GoodsForm_r_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ShopDataBase shopDataBase;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private ShopDataBaseTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDпоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDскладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button search;
        private ShopDataBaseTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button back;
    }
}