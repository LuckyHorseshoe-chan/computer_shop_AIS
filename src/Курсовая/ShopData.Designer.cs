
namespace Курсовая
{
    partial class ShopData
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
            this.goods = new System.Windows.Forms.Button();
            this.purchases = new System.Windows.Forms.Button();
            this.supply = new System.Windows.Forms.Button();
            this.warehouse = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goods
            // 
            this.goods.Location = new System.Drawing.Point(68, 29);
            this.goods.Name = "goods";
            this.goods.Size = new System.Drawing.Size(214, 52);
            this.goods.TabIndex = 0;
            this.goods.Text = "Товары";
            this.goods.UseVisualStyleBackColor = true;
            this.goods.Click += new System.EventHandler(this.goods_Click);
            // 
            // purchases
            // 
            this.purchases.Location = new System.Drawing.Point(68, 102);
            this.purchases.Name = "purchases";
            this.purchases.Size = new System.Drawing.Size(214, 53);
            this.purchases.TabIndex = 1;
            this.purchases.Text = "Покупки";
            this.purchases.UseVisualStyleBackColor = true;
            this.purchases.Click += new System.EventHandler(this.purchases_Click);
            // 
            // supply
            // 
            this.supply.Location = new System.Drawing.Point(68, 181);
            this.supply.Name = "supply";
            this.supply.Size = new System.Drawing.Size(214, 57);
            this.supply.TabIndex = 2;
            this.supply.Text = "Поставка";
            this.supply.UseVisualStyleBackColor = true;
            this.supply.Click += new System.EventHandler(this.supply_Click);
            // 
            // warehouse
            // 
            this.warehouse.Location = new System.Drawing.Point(68, 267);
            this.warehouse.Name = "warehouse";
            this.warehouse.Size = new System.Drawing.Size(214, 52);
            this.warehouse.TabIndex = 3;
            this.warehouse.Text = "Склад";
            this.warehouse.UseVisualStyleBackColor = true;
            this.warehouse.Click += new System.EventHandler(this.warehouse_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(68, 343);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(214, 54);
            this.back.TabIndex = 4;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ShopData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 430);
            this.Controls.Add(this.back);
            this.Controls.Add(this.warehouse);
            this.Controls.Add(this.supply);
            this.Controls.Add(this.purchases);
            this.Controls.Add(this.goods);
            this.Name = "ShopData";
            this.Text = "Данные о магазине";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goods;
        private System.Windows.Forms.Button purchases;
        private System.Windows.Forms.Button supply;
        private System.Windows.Forms.Button warehouse;
        private System.Windows.Forms.Button back;
    }
}