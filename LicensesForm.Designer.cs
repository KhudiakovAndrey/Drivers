
namespace Drivers_Khudiakov.Forms
{
    partial class LicensesForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.LicenseListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.licenseTableAdapter1 = new Drivers_Khudiakov.DriversDataSetTableAdapters.LICENSETableAdapter();
            this.driversTableAdapter1 = new Drivers_Khudiakov.DriversDataSetTableAdapters.DRIVERSTableAdapter();
            this.driversDataSet1 = new Drivers_Khudiakov.DriversDataSet();
            this.statuS_LICENSETableAdapter1 = new Drivers_Khudiakov.DriversDataSetTableAdapters.STATUS_LICENSETableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataSet1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1128, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лицензии";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LicenseListView
            // 
            this.LicenseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.LicenseListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LicenseListView.FullRowSelect = true;
            this.LicenseListView.HideSelection = false;
            this.LicenseListView.Location = new System.Drawing.Point(10, 85);
            this.LicenseListView.MultiSelect = false;
            this.LicenseListView.Name = "LicenseListView";
            this.LicenseListView.Size = new System.Drawing.Size(968, 382);
            this.LicenseListView.TabIndex = 1;
            this.LicenseListView.UseCompatibleStateImageBehavior = false;
            this.LicenseListView.View = System.Windows.Forms.View.Details;
            this.LicenseListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LicenseListView_ItemSelectionChanged);
            this.LicenseListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LicenseListView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 30;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Водитель";
            this.columnHeader3.Width = 190;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата оформления";
            this.columnHeader4.Width = 156;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Дата окончания";
            this.columnHeader5.Width = 117;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Категория";
            this.columnHeader6.Width = 76;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Серия";
            this.columnHeader7.Width = 160;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Номер";
            this.columnHeader8.Width = 123;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Статус";
            this.columnHeader9.Width = 121;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(978, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 382);
            this.panel1.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.AddButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(160, 69);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // licenseTableAdapter1
            // 
            this.licenseTableAdapter1.ClearBeforeFill = true;
            // 
            // driversTableAdapter1
            // 
            this.driversTableAdapter1.ClearBeforeFill = true;
            // 
            // driversDataSet1
            // 
            this.driversDataSet1.DataSetName = "DriversDataSet";
            this.driversDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statuS_LICENSETableAdapter1
            // 
            this.statuS_LICENSETableAdapter1.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 48);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // LicensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 477);
            this.Controls.Add(this.LicenseListView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "LicensesForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Лицензии";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LicensesForm_FormClosed);
            this.Load += new System.EventHandler(this.LicensesForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.driversDataSet1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LicenseListView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private DriversDataSetTableAdapters.LICENSETableAdapter licenseTableAdapter1;
        private DriversDataSetTableAdapters.DRIVERSTableAdapter driversTableAdapter1;
        private DriversDataSet driversDataSet1;
        private DriversDataSetTableAdapters.STATUS_LICENSETableAdapter statuS_LICENSETableAdapter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}