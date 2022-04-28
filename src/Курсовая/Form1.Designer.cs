
namespace Курсовая
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataBase = new Курсовая.ShopDataBase();
            this.employeers = new System.Windows.Forms.Button();
            this.makers = new System.Windows.Forms.Button();
            this.buyers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.shopDataBase;
            this.bindingSource1.Position = 0;
            // 
            // shopDataBase
            // 
            this.shopDataBase.DataSetName = "ShopDataBase";
            this.shopDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeers
            // 
            this.employeers.Location = new System.Drawing.Point(137, 60);
            this.employeers.Name = "employeers";
            this.employeers.Size = new System.Drawing.Size(186, 64);
            this.employeers.TabIndex = 0;
            this.employeers.Text = "Сотрудники";
            this.employeers.UseVisualStyleBackColor = true;
            this.employeers.Click += new System.EventHandler(this.employeers_Click);
            // 
            // makers
            // 
            this.makers.Location = new System.Drawing.Point(137, 147);
            this.makers.Name = "makers";
            this.makers.Size = new System.Drawing.Size(182, 68);
            this.makers.TabIndex = 1;
            this.makers.Text = "Производители";
            this.makers.UseVisualStyleBackColor = true;
            this.makers.Click += new System.EventHandler(this.makers_Click);
            // 
            // buyers
            // 
            this.buyers.Location = new System.Drawing.Point(137, 243);
            this.buyers.Name = "buyers";
            this.buyers.Size = new System.Drawing.Size(182, 70);
            this.buyers.TabIndex = 2;
            this.buyers.Text = "Покупатели";
            this.buyers.UseVisualStyleBackColor = true;
            this.buyers.Click += new System.EventHandler(this.buyers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 365);
            this.Controls.Add(this.buyers);
            this.Controls.Add(this.makers);
            this.Controls.Add(this.employeers);
            this.Name = "Form1";
            this.Text = "Главная форма";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private ShopDataBase shopDataBase;
        private System.Windows.Forms.Button employeers;
        private System.Windows.Forms.Button makers;
        private System.Windows.Forms.Button buyers;
    }
}

