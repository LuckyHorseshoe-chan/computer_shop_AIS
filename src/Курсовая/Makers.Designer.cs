
namespace Курсовая
{
    partial class Makers
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
            this.buyers = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buyers
            // 
            this.buyers.Location = new System.Drawing.Point(96, 74);
            this.buyers.Name = "buyers";
            this.buyers.Size = new System.Drawing.Size(244, 96);
            this.buyers.TabIndex = 0;
            this.buyers.Text = "Покупки";
            this.buyers.UseVisualStyleBackColor = true;
            this.buyers.Click += new System.EventHandler(this.buyers_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(96, 207);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(248, 90);
            this.back.TabIndex = 1;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Makers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 372);
            this.Controls.Add(this.back);
            this.Controls.Add(this.buyers);
            this.Name = "Makers";
            this.Text = "Меню для производителей";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buyers;
        private System.Windows.Forms.Button back;
    }
}