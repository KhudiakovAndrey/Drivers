
namespace Drivers_Khudiakov.Forms
{
    partial class ChangeStatusControl
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
            this.DateLabel = new System.Windows.Forms.Label();
            this.OldStatusLabel = new System.Windows.Forms.Label();
            this.NewStatusLabel = new System.Windows.Forms.Label();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.DateLabel.Location = new System.Drawing.Point(0, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(300, 29);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Дата";
            // 
            // OldStatusLabel
            // 
            this.OldStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.OldStatusLabel.Location = new System.Drawing.Point(0, 29);
            this.OldStatusLabel.Name = "OldStatusLabel";
            this.OldStatusLabel.Size = new System.Drawing.Size(297, 23);
            this.OldStatusLabel.TabIndex = 1;
            this.OldStatusLabel.Text = "Старый статус: ";
            // 
            // NewStatusLabel
            // 
            this.NewStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NewStatusLabel.Location = new System.Drawing.Point(1, 52);
            this.NewStatusLabel.Name = "NewStatusLabel";
            this.NewStatusLabel.Size = new System.Drawing.Size(296, 22);
            this.NewStatusLabel.TabIndex = 2;
            this.NewStatusLabel.Text = "Новый статус: ";
            // 
            // CommentLabel
            // 
            this.CommentLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CommentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CommentLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CommentLabel.Location = new System.Drawing.Point(0, 74);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(300, 76);
            this.CommentLabel.TabIndex = 3;
            this.CommentLabel.Text = "Причина: ";
            // 
            // ChangeStatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.NewStatusLabel);
            this.Controls.Add(this.OldStatusLabel);
            this.Controls.Add(this.DateLabel);
            this.Name = "ChangeStatusControl";
            this.Size = new System.Drawing.Size(300, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label OldStatusLabel;
        private System.Windows.Forms.Label NewStatusLabel;
        private System.Windows.Forms.Label CommentLabel;
    }
}
