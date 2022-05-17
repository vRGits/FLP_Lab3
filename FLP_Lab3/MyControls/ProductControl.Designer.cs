namespace FLP_Lab3.MyControls
{
    partial class ProductControl
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
            this.ProductName = new System.Windows.Forms.Label();
            this.ProductCalories = new System.Windows.Forms.Label();
            this.ProductProteins = new System.Windows.Forms.Label();
            this.ProductFats = new System.Windows.Forms.Label();
            this.ProductCarbohydrates = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(5, 5);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(49, 20);
            this.ProductName.TabIndex = 0;
            this.ProductName.Text = "Name";
            this.ProductName.Click += new System.EventHandler(this.ProductName_Click);
            this.ProductName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductLabels_MouseClick);
            // 
            // ProductCalories
            // 
            this.ProductCalories.AutoSize = true;
            this.ProductCalories.Location = new System.Drawing.Point(100, 5);
            this.ProductCalories.Name = "ProductCalories";
            this.ProductCalories.Size = new System.Drawing.Size(35, 20);
            this.ProductCalories.TabIndex = 1;
            this.ProductCalories.Text = "ccal";
            this.ProductCalories.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductLabels_MouseClick);
            // 
            // ProductProteins
            // 
            this.ProductProteins.AutoSize = true;
            this.ProductProteins.Location = new System.Drawing.Point(141, 5);
            this.ProductProteins.Name = "ProductProteins";
            this.ProductProteins.Size = new System.Drawing.Size(37, 20);
            this.ProductProteins.TabIndex = 2;
            this.ProductProteins.Text = "prot";
            this.ProductProteins.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductLabels_MouseClick);
            // 
            // ProductFats
            // 
            this.ProductFats.AutoSize = true;
            this.ProductFats.Location = new System.Drawing.Point(184, 5);
            this.ProductFats.Name = "ProductFats";
            this.ProductFats.Size = new System.Drawing.Size(33, 20);
            this.ProductFats.TabIndex = 3;
            this.ProductFats.Text = "fats";
            this.ProductFats.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductLabels_MouseClick);
            // 
            // ProductCarbohydrates
            // 
            this.ProductCarbohydrates.AutoSize = true;
            this.ProductCarbohydrates.Location = new System.Drawing.Point(223, 5);
            this.ProductCarbohydrates.Name = "ProductCarbohydrates";
            this.ProductCarbohydrates.Size = new System.Drawing.Size(47, 20);
            this.ProductCarbohydrates.TabIndex = 4;
            this.ProductCarbohydrates.Text = "carbo";
            this.ProductCarbohydrates.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductLabels_MouseClick);
            // 
            // ProductControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ProductCarbohydrates);
            this.Controls.Add(this.ProductFats);
            this.Controls.Add(this.ProductProteins);
            this.Controls.Add(this.ProductCalories);
            this.Controls.Add(this.ProductName);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(273, 30);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductControl_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label ProductCalories;
        private System.Windows.Forms.Label ProductProteins;
        private System.Windows.Forms.Label ProductFats;
        private System.Windows.Forms.Label ProductCarbohydrates;
    }
}
