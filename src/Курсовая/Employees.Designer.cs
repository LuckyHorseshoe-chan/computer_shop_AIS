
namespace Курсовая
{
    partial class Employees
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
            this.shopdata = new System.Windows.Forms.Button();
            this.makers = new System.Windows.Forms.Button();
            this.buyers = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shopdata
            // 
            this.shopdata.Location = new System.Drawing.Point(76, 59);
            this.shopdata.Name = "shopdata";
            this.shopdata.Size = new System.Drawing.Size(218, 52);
            this.shopdata.TabIndex = 0;
            this.shopdata.Text = "Данные о магазине";
            this.shopdata.UseVisualStyleBackColor = true;
            this.shopdata.Click += new System.EventHandler(this.shopdata_Click);
            // 
            // makers
            // 
            this.makers.Location = new System.Drawing.Point(76, 139);
            this.makers.Name = "makers";
            this.makers.Size = new System.Drawing.Size(218, 55);
            this.makers.TabIndex = 1;
            this.makers.Text = "Производители";
            this.makers.UseVisualStyleBackColor = true;
            this.makers.Click += new System.EventHandler(this.makers_Click);
            // 
            // buyers
            // 
            this.buyers.Location = new System.Drawing.Point(76, 218);
            this.buyers.Name = "buyers";
            this.buyers.Size = new System.Drawing.Size(218, 54);
            this.buyers.TabIndex = 2;
            this.buyers.Text = "Покупатели";
            this.buyers.UseVisualStyleBackColor = true;
            this.buyers.Click += new System.EventHandler(this.buyers_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(76, 297);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(218, 54);
            this.back.TabIndex = 3;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 405);
            this.Controls.Add(this.back);
            this.Controls.Add(this.buyers);
            this.Controls.Add(this.makers);
            this.Controls.Add(this.shopdata);
            this.Name = "Employees";
            this.Text = "Меню для сотрудников";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shopdata;
        private System.Windows.Forms.Button makers;
        private System.Windows.Forms.Button buyers;
        private System.Windows.Forms.Button back;
    }
}