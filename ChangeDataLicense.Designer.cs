
namespace Drivers_Khudiakov.Forms
{
    partial class ChangeDataLicense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.AddDriverButton = new System.Windows.Forms.Button();
            this.tbImagePictureBox = new System.Windows.Forms.PictureBox();
            this.DriversDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDriverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.driversDataSet = new Drivers_Khudiakov.DriversDataSet();
            this.DriverComboBox = new Drivers_Khudiakov.CustomTextBox();
            this.NumberCustomTextBox = new Drivers_Khudiakov.CustomTextBox();
            this.SeriesCustomTextBox = new Drivers_Khudiakov.CustomTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoryCustomTextBox = new Drivers_Khudiakov.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExpryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LicenseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.sTATUSLICENSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.driversTableAdapter1 = new Drivers_Khudiakov.DriversDataSetTableAdapters.DRIVERSTableAdapter();
            this.licenseTableAdapter1 = new Drivers_Khudiakov.DriversDataSetTableAdapters.LICENSETableAdapter();
            this.statuS_LICENSETableAdapter1 = new Drivers_Khudiakov.DriversDataSetTableAdapters.STATUS_LICENSETableAdapter();
            this.ChangeStatusFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ChangedLabel = new System.Windows.Forms.Label();
            this.changE_STATUS_LICENSETableAdapter1 = new Drivers_Khudiakov.DriversDataSetTableAdapters.CHANGE_STATUS_LICENSETableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriversDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSLICENSEBindingSource)).BeginInit();
            this.ChangeStatusFlowLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лицензия";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.AddDriverButton);
            this.panel1.Controls.Add(this.tbImagePictureBox);
            this.panel1.Controls.Add(this.DriversDataGridView);
            this.panel1.Controls.Add(this.DriverComboBox);
            this.panel1.Controls.Add(this.NumberCustomTextBox);
            this.panel1.Controls.Add(this.SeriesCustomTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CategoryCustomTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ExpryDateTimePicker);
            this.panel1.Controls.Add(this.LicenseDateTimePicker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.StatusComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 259);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Статус";
            // 
            // AddDriverButton
            // 
            this.AddDriverButton.Location = new System.Drawing.Point(688, 19);
            this.AddDriverButton.Name = "AddDriverButton";
            this.AddDriverButton.Size = new System.Drawing.Size(41, 32);
            this.AddDriverButton.TabIndex = 13;
            this.AddDriverButton.Text = "+";
            this.AddDriverButton.UseVisualStyleBackColor = true;
            this.AddDriverButton.Click += new System.EventHandler(this.AddDriverButton_Click);
            // 
            // tbImagePictureBox
            // 
            this.tbImagePictureBox.Location = new System.Drawing.Point(116, 19);
            this.tbImagePictureBox.Name = "tbImagePictureBox";
            this.tbImagePictureBox.Size = new System.Drawing.Size(41, 32);
            this.tbImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tbImagePictureBox.TabIndex = 4;
            this.tbImagePictureBox.TabStop = false;
            // 
            // DriversDataGridView
            // 
            this.DriversDataGridView.AllowUserToAddRows = false;
            this.DriversDataGridView.AllowUserToDeleteRows = false;
            this.DriversDataGridView.AutoGenerateColumns = false;
            this.DriversDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DriversDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DriversDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DriversDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriversDataGridView.ColumnHeadersVisible = false;
            this.DriversDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDriverDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.passportSerialDataGridViewTextBoxColumn,
            this.passportNumberDataGridViewTextBoxColumn});
            this.DriversDataGridView.DataSource = this.bindingSource1;
            this.DriversDataGridView.Location = new System.Drawing.Point(130, 57);
            this.DriversDataGridView.MultiSelect = false;
            this.DriversDataGridView.Name = "DriversDataGridView";
            this.DriversDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DriversDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DriversDataGridView.RowHeadersVisible = false;
            this.DriversDataGridView.RowTemplate.Height = 50;
            this.DriversDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DriversDataGridView.Size = new System.Drawing.Size(545, 21);
            this.DriversDataGridView.TabIndex = 5;
            this.DriversDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DriversDataGridView_CellMouseClick);
            // 
            // iDDriverDataGridViewTextBoxColumn
            // 
            this.iDDriverDataGridViewTextBoxColumn.DataPropertyName = "ID_Driver";
            this.iDDriverDataGridViewTextBoxColumn.HeaderText = "ID_Driver";
            this.iDDriverDataGridViewTextBoxColumn.Name = "iDDriverDataGridViewTextBoxColumn";
            this.iDDriverDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passportSerialDataGridViewTextBoxColumn
            // 
            this.passportSerialDataGridViewTextBoxColumn.DataPropertyName = "PassportSerial";
            this.passportSerialDataGridViewTextBoxColumn.HeaderText = "PassportSerial";
            this.passportSerialDataGridViewTextBoxColumn.Name = "passportSerialDataGridViewTextBoxColumn";
            this.passportSerialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passportNumberDataGridViewTextBoxColumn
            // 
            this.passportNumberDataGridViewTextBoxColumn.DataPropertyName = "PassportNumber";
            this.passportNumberDataGridViewTextBoxColumn.HeaderText = "PassportNumber";
            this.passportNumberDataGridViewTextBoxColumn.Name = "passportNumberDataGridViewTextBoxColumn";
            this.passportNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "DRIVERS";
            this.bindingSource1.DataSource = this.driversDataSet;
            this.bindingSource1.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.dRIVERSBindingSource_ListChanged);
            // 
            // driversDataSet
            // 
            this.driversDataSet.DataSetName = "DriversDataSet";
            this.driversDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DriverComboBox
            // 
            this.DriverComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.DriverComboBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DriverComboBox.Location = new System.Drawing.Point(163, 19);
            this.DriverComboBox.Name = "DriverComboBox";
            this.DriverComboBox.Size = new System.Drawing.Size(518, 32);
            this.DriverComboBox.TabIndex = 12;
            this.DriverComboBox.TextChanged += new System.EventHandler(this.DriverComboBox_TextChanged);
            // 
            // NumberCustomTextBox
            // 
            this.NumberCustomTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumberCustomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberCustomTextBox.Location = new System.Drawing.Point(380, 168);
            this.NumberCustomTextBox.Name = "NumberCustomTextBox";
            this.NumberCustomTextBox.Size = new System.Drawing.Size(295, 32);
            this.NumberCustomTextBox.TabIndex = 11;
            // 
            // SeriesCustomTextBox
            // 
            this.SeriesCustomTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SeriesCustomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SeriesCustomTextBox.Location = new System.Drawing.Point(98, 168);
            this.SeriesCustomTextBox.Name = "SeriesCustomTextBox";
            this.SeriesCustomTextBox.Size = new System.Drawing.Size(201, 32);
            this.SeriesCustomTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Номер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Серия";
            // 
            // CategoryCustomTextBox
            // 
            this.CategoryCustomTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CategoryCustomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryCustomTextBox.Location = new System.Drawing.Point(137, 117);
            this.CategoryCustomTextBox.Name = "CategoryCustomTextBox";
            this.CategoryCustomTextBox.Size = new System.Drawing.Size(538, 32);
            this.CategoryCustomTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Категория";
            // 
            // ExpryDateTimePicker
            // 
            this.ExpryDateTimePicker.Location = new System.Drawing.Point(475, 74);
            this.ExpryDateTimePicker.Name = "ExpryDateTimePicker";
            this.ExpryDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.ExpryDateTimePicker.TabIndex = 5;
            // 
            // LicenseDateTimePicker
            // 
            this.LicenseDateTimePicker.Location = new System.Drawing.Point(230, 74);
            this.LicenseDateTimePicker.Name = "LicenseDateTimePicker";
            this.LicenseDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.LicenseDateTimePicker.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата оформления от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Водитель";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DataSource = this.sTATUSLICENSEBindingSource;
            this.StatusComboBox.DisplayMember = "Title";
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(98, 213);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(285, 32);
            this.StatusComboBox.TabIndex = 15;
            this.StatusComboBox.ValueMember = "ID_StatusLicense";
            // 
            // sTATUSLICENSEBindingSource
            // 
            this.sTATUSLICENSEBindingSource.DataMember = "STATUS_LICENSE";
            this.sTATUSLICENSEBindingSource.DataSource = this.driversDataSet;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(652, 335);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(571, 335);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 2;
            this.OKbutton.Text = "ОК";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // driversTableAdapter1
            // 
            this.driversTableAdapter1.ClearBeforeFill = true;
            // 
            // licenseTableAdapter1
            // 
            this.licenseTableAdapter1.ClearBeforeFill = true;
            // 
            // statuS_LICENSETableAdapter1
            // 
            this.statuS_LICENSETableAdapter1.ClearBeforeFill = true;
            // 
            // ChangeStatusFlowLayoutPanel
            // 
            this.ChangeStatusFlowLayoutPanel.AutoScroll = true;
            this.ChangeStatusFlowLayoutPanel.Controls.Add(this.ChangedLabel);
            this.ChangeStatusFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChangeStatusFlowLayoutPanel.Location = new System.Drawing.Point(735, 125);
            this.ChangeStatusFlowLayoutPanel.Name = "ChangeStatusFlowLayoutPanel";
            this.ChangeStatusFlowLayoutPanel.Size = new System.Drawing.Size(337, 250);
            this.ChangeStatusFlowLayoutPanel.TabIndex = 16;
            // 
            // ChangedLabel
            // 
            this.ChangedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.ChangedLabel.Location = new System.Drawing.Point(3, 0);
            this.ChangedLabel.Name = "ChangedLabel";
            this.ChangedLabel.Size = new System.Drawing.Size(331, 258);
            this.ChangedLabel.TabIndex = 0;
            this.ChangedLabel.Text = "Изменений в статусе не было";
            this.ChangedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changE_STATUS_LICENSETableAdapter1
            // 
            this.changE_STATUS_LICENSETableAdapter1.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 336F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1072, 100);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(739, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(330, 100);
            this.label9.TabIndex = 1;
            this.label9.Text = "Изменения статуса";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1072, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.Text = "Печать";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // ChangeDataLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 375);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChangeStatusFlowLayoutPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ChangeDataLicense";
            this.Text = "Взаимодействие с лицензией";
            this.Load += new System.EventHandler(this.ChangeDataLicense_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriversDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSLICENSEBindingSource)).EndInit();
            this.ChangeStatusFlowLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKbutton;
        //private DriversDataSet driversDataSet;
        //private DriversDataSetTableAdapters.DRIVERSTableAdapter dRIVERSTableAdapter;
        //private DriversDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        //private DriversDataSetTableAdapters.LICENSETableAdapter lICENSETableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ExpryDateTimePicker;
        private System.Windows.Forms.DateTimePicker LicenseDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private CustomTextBox CategoryCustomTextBox;
        private System.Windows.Forms.Label label5;
        private CustomTextBox NumberCustomTextBox;
        private CustomTextBox SeriesCustomTextBox;
        private System.Windows.Forms.DataGridView DriversDataGridView;
        private CustomTextBox DriverComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.PictureBox tbImagePictureBox;
        private System.Windows.Forms.Button AddDriverButton;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label label8;
        private DriversDataSetTableAdapters.DRIVERSTableAdapter driversTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DriversDataSet driversDataSet;
        private DriversDataSetTableAdapters.LICENSETableAdapter licenseTableAdapter1;
        private DriversDataSetTableAdapters.STATUS_LICENSETableAdapter statuS_LICENSETableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDriverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sTATUSLICENSEBindingSource;
        private System.Windows.Forms.FlowLayoutPanel ChangeStatusFlowLayoutPanel;
        private System.Windows.Forms.Label ChangedLabel;
        private DriversDataSetTableAdapters.CHANGE_STATUS_LICENSETableAdapter changE_STATUS_LICENSETableAdapter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        //private DriversDataSetTableAdapters.STATUS_LICENSETableAdapter statuS_LICENSETableAdapter1;
    }
}