
namespace Курсовая
{
    partial class Buyers
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
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goods
            // 
            this.goods.Location = new System.Drawing.Point(68, 93);
            this.goods.Name = "goods";
            this.goods.Size = new System.Drawing.Size(291, 95);
            this.goods.TabIndex = 0;
            this.goods.Text = "Товары";
            this.goods.UseVisualStyleBackColor = true;
            this.goods.Click += new System.EventHandler(this.goods_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(65, 236);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(293, 77);
            this.back.TabIndex = 1;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Buyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 377);
            this.Controls.Add(this.back);
            this.Controls.Add(this.goods);
            this.Name = "Buyers";
            this.Text = "Меню для покупателей";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goods;
        private System.Windows.Forms.Button back;
    }
}