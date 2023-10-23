
namespace Drivers_Khudiakov.Forms
{
    partial class NavigationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.DriversButton = new System.Windows.Forms.Button();
            this.LicenseButton = new System.Windows.Forms.Button();
            this.VehicleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главное меню";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DriversButton
            // 
            this.DriversButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DriversButton.Location = new System.Drawing.Point(31, 95);
            this.DriversButton.Name = "DriversButton";
            this.DriversButton.Size = new System.Drawing.Size(159, 77);
            this.DriversButton.TabIndex = 1;
            this.DriversButton.Text = "Водители";
            this.DriversButton.UseVisualStyleBackColor = true;
            this.DriversButton.Click += new System.EventHandler(this.DriversButton_Click);
            // 
            // LicenseButton
            // 
            this.LicenseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LicenseButton.Location = new System.Drawing.Point(251, 95);
            this.LicenseButton.Name = "LicenseButton";
            this.LicenseButton.Size = new System.Drawing.Size(159, 77);
            this.LicenseButton.TabIndex = 2;
            this.LicenseButton.Text = "Лицензии";
            this.LicenseButton.UseVisualStyleBackColor = true;
            this.LicenseButton.Click += new System.EventHandler(this.LicenseButton_Click);
            // 
            // VehicleButton
            // 
            this.VehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VehicleButton.Location = new System.Drawing.Point(459, 95);
            this.VehicleButton.Name = "VehicleButton";
            this.VehicleButton.Size = new System.Drawing.Size(159, 77);
            this.VehicleButton.TabIndex = 3;
            this.VehicleButton.Text = "Траспорт";
            this.VehicleButton.UseVisualStyleBackColor = true;
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 211);
            this.Controls.Add(this.VehicleButton);
            this.Controls.Add(this.LicenseButton);
            this.Controls.Add(this.DriversButton);
            this.Controls.Add(this.label1);
            this.Name = "NavigationForm";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DriversButton;
        private System.Windows.Forms.Button LicenseButton;
        private System.Windows.Forms.Button VehicleButton;
    }
}