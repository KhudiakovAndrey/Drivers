
namespace Drivers_Khudiakov.Forms
{
    partial class LicenseControl
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
            this.SeriaLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.FinishLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SeriaLabel
            // 
            this.SeriaLabel.AutoSize = true;
            this.SeriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.SeriaLabel.Location = new System.Drawing.Point(4, 4);
            this.SeriaLabel.Name = "SeriaLabel";
            this.SeriaLabel.Size = new System.Drawing.Size(76, 26);
            this.SeriaLabel.TabIndex = 0;
            this.SeriaLabel.Text = "Серия";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.NumberLabel.Location = new System.Drawing.Point(86, 4);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(80, 26);
            this.NumberLabel.TabIndex = 1;
            this.NumberLabel.Text = "Номер";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(5, 47);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(23, 20);
            this.StartLabel.TabIndex = 2;
            this.StartLabel.Text = "с ";
            // 
            // FinishLabel
            // 
            this.FinishLabel.AutoSize = true;
            this.FinishLabel.Location = new System.Drawing.Point(137, 47);
            this.FinishLabel.Name = "FinishLabel";
            this.FinishLabel.Size = new System.Drawing.Size(34, 20);
            this.FinishLabel.TabIndex = 3;
            this.FinishLabel.Text = "по ";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(5, 84);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(108, 20);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "Категория: ";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(5, 121);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(78, 20);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Статус: ";
            // 
            // LicenseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.FinishLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.SeriaLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LicenseControl";
            this.Size = new System.Drawing.Size(272, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SeriaLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label FinishLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label StatusLabel;
    }
}
