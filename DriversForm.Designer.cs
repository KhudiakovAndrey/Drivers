
namespace Drivers_Khudiakov
{
    partial class DriversForm
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
            this.DriversListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.driversDataSet1 = new Drivers_Khudiakov.DriversDataSet();
            this.driversTableAdapter1 = new Drivers_Khudiakov.DriversDataSetTableAdapters.DRIVERSTableAdapter();
            this.tableAdapterManager1 = new Drivers_Khudiakov.DriversDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DriversListView
            // 
            this.DriversListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader14});
            this.DriversListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DriversListView.FullRowSelect = true;
            this.DriversListView.HideSelection = false;
            this.DriversListView.Location = new System.Drawing.Point(10, 79);
            this.DriversListView.Margin = new System.Windows.Forms.Padding(15);
            this.DriversListView.MultiSelect = false;
            this.DriversListView.Name = "DriversListView";
            this.DriversListView.Size = new System.Drawing.Size(1259, 381);
            this.DriversListView.TabIndex = 0;
            this.DriversListView.UseCompatibleStateImageBehavior = false;
            this.DriversListView.View = System.Windows.Forms.View.Details;
            this.DriversListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.DriversListView_ItemSelectionChanged);
            this.DriversListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DriversListView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Отчество";
            this.columnHeader4.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Серия";
            this.columnHeader5.Width = 68;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Номер";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Адрес";
            this.columnHeader7.Width = 114;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Проживание";
            this.columnHeader8.Width = 105;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Место работы";
            this.columnHeader9.Width = 104;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Должность";
            this.columnHeader10.Width = 89;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Телефон";
            this.columnHeader11.Width = 114;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Почта";
            this.columnHeader12.Width = 149;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Замечания";
            this.columnHeader14.Width = 203;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 69);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1117, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Водители";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.AddButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.AddButton.Location = new System.Drawing.Point(1117, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(142, 69);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 48);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить ";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FIOLabel);
            this.panel2.Controls.Add(this.ImagePictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1269, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.panel2.Size = new System.Drawing.Size(242, 450);
            this.panel2.TabIndex = 3;
            // 
            // FIOLabel
            // 
            this.FIOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FIOLabel.Location = new System.Drawing.Point(0, 352);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(242, 37);
            this.FIOLabel.TabIndex = 1;
            this.FIOLabel.Text = "FIO";
            this.FIOLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImagePictureBox.Location = new System.Drawing.Point(0, 100);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(242, 249);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePictureBox.TabIndex = 0;
            this.ImagePictureBox.TabStop = false;
            // 
            // driversDataSet1
            // 
            this.driversDataSet1.DataSetName = "DriversDataSet";
            this.driversDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driversTableAdapter1
            // 
            this.driversTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DRIVERSTableAdapter = this.driversTableAdapter1;
            this.tableAdapterManager1.LICENSETableAdapter = null;
            this.tableAdapterManager1.STATUS_LICENSETableAdapter = null;
            this.tableAdapterManager1.TYPE_ENGINETableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Drivers_Khudiakov.DriversDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VEHICLETableAdapter = null;
            // 
            // DriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 470);
            this.Controls.Add(this.DriversListView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "DriversForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Водители";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DriversForm_FormClosed);
            this.Load += new System.EventHandler(this.DriversForm_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView DriversListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Label FIOLabel;
        private DriversDataSet driversDataSet1;
        private DriversDataSetTableAdapters.DRIVERSTableAdapter driversTableAdapter1;
        private DriversDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}

