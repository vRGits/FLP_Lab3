namespace FLP_Lab3.MyControls
{
    partial class NotSelectedProductControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Core.Model.Product product1 = new Core.Model.Product();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotSelectedProductControl));
            this.productControl1 = new FLP_Lab3.MyControls.ProductControl();
            this.Delete = new System.Windows.Forms.PictureBox();
            this.Update = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Update)).BeginInit();
            this.SuspendLayout();
            // 
            // productControl1
            // 
            this.productControl1.AllowDrop = true;
            this.productControl1.BackColor = System.Drawing.SystemColors.Control;
            this.productControl1.Location = new System.Drawing.Point(0, 0);
            this.productControl1.Name = "productControl1";
            product1.Calories = 1;
            product1.Carbohydrates = 1D;
            product1.Fats = 1D;
            product1.Id = 0;
            product1.Name = "some string";
            product1.Proteins = 1D;
            this.productControl1.Product = product1;
            this.productControl1.Size = new System.Drawing.Size(329, 30);
            this.productControl1.TabIndex = 0;
            this.productControl1.Load += new System.EventHandler(this.productControl1_Load_1);
            // 
            // Delete
            // 
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Location = new System.Drawing.Point(303, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(20, 20);
            this.Delete.TabIndex = 1;
            this.Delete.TabStop = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.Location = new System.Drawing.Point(277, 5);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(20, 20);
            this.Update.TabIndex = 2;
            this.Update.TabStop = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // NotSelectedProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.productControl1);
            this.Name = "NotSelectedProductControl";
            this.Size = new System.Drawing.Size(328, 28);
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Update)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Delete;
        private System.Windows.Forms.PictureBox Update;
        private ProductControl productControl1;
    }
}
