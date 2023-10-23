
namespace Drivers_Khudiakov.Forms
{
    partial class ChangeStatusLicenseFormDialog
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
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.LicenseListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.NewStatusCustomTextBox = new Drivers_Khudiakov.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OldStatusCustomTextBox = new Drivers_Khudiakov.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.driversDataSet = new Drivers_Khudiakov.DriversDataSet();
            this.lICENSETableAdapter = new Drivers_Khudiakov.DriversDataSetTableAdapters.LICENSETableAdapter();
            this.sTATUS_LICENSETableAdapter = new Drivers_Khudiakov.DriversDataSetTableAdapters.STATUS_LICENSETableAdapter();
            this.dRIVERSTableAdapter = new Drivers_Khudiakov.DriversDataSetTableAdapters.DRIVERSTableAdapter();
            this.CommentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Drivers_Khudiakov.DriversDataSetTableAdapters.TableAdapterManager();
            this.changE_STATUS_LICENSETableAdapter1 = new Drivers_Khudiakov.DriversDataSetTableAdapters.CHANGE_STATUS_LICENSETableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(824, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы уверены в изменении статуса лицензии?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(656, 417);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 1;
            this.YesButton.Text = "Да";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(737, 417);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 2;
            this.NoButton.Text = "Нет";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // LicenseListView
            // 
            this.LicenseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.LicenseListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LicenseListView.FullRowSelect = true;
            this.LicenseListView.HideSelection = false;
            this.LicenseListView.Location = new System.Drawing.Point(12, 192);
            this.LicenseListView.Name = "LicenseListView";
            this.LicenseListView.Size = new System.Drawing.Size(800, 80);
            this.LicenseListView.TabIndex = 3;
            this.LicenseListView.UseCompatibleStateImageBehavior = false;
            this.LicenseListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "•";
            this.columnHeader2.Width = 30;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Водитель";
            this.columnHeader8.Width = 184;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Дата оформления";
            this.columnHeader9.Width = 139;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Дата окончания";
            this.columnHeader10.Width = 126;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Категория";
            this.columnHeader11.Width = 93;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Серия";
            this.columnHeader12.Width = 66;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Номер";
            this.columnHeader13.Width = 69;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Статус";
            this.columnHeader14.Width = 86;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NewStatusCustomTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OldStatusCustomTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.panel1.Location = new System.Drawing.Point(12, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 77);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "?";
            // 
            // NewStatusCustomTextBox
            // 
            this.NewStatusCustomTextBox.BackColor = System.Drawing.Color.White;
            this.NewStatusCustomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewStatusCustomTextBox.Location = new System.Drawing.Point(424, 21);
            this.NewStatusCustomTextBox.Name = "NewStatusCustomTextBox";
            this.NewStatusCustomTextBox.Size = new System.Drawing.Size(194, 34);
            this.NewStatusCustomTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "На";
            // 
            // OldStatusCustomTextBox
            // 
            this.OldStatusCustomTextBox.BackColor = System.Drawing.Color.White;
            this.OldStatusCustomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OldStatusCustomTextBox.Location = new System.Drawing.Point(185, 21);
            this.OldStatusCustomTextBox.Name = "OldStatusCustomTextBox";
            this.OldStatusCustomTextBox.Size = new System.Drawing.Size(194, 34);
            this.OldStatusCustomTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "С";
            // 
            // driversDataSet
            // 
            this.driversDataSet.DataSetName = "DriversDataSet";
            this.driversDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lICENSETableAdapter
            // 
            this.lICENSETableAdapter.ClearBeforeFill = true;
            // 
            // sTATUS_LICENSETableAdapter
            // 
            this.sTATUS_LICENSETableAdapter.ClearBeforeFill = true;
            // 
            // dRIVERSTableAdapter
            // 
            this.dRIVERSTableAdapter.ClearBeforeFill = true;
            // 
            // CommentRichTextBox
            // 
            this.CommentRichTextBox.Location = new System.Drawing.Point(12, 300);
            this.CommentRichTextBox.Name = "CommentRichTextBox";
            this.CommentRichTextBox.Size = new System.Drawing.Size(800, 96);
            this.CommentRichTextBox.TabIndex = 6;
            this.CommentRichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Причина изменения:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHANGE_STATUS_LICENSETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DRIVERSTableAdapter = null;
            this.tableAdapterManager.LICENSETableAdapter = null;
            this.tableAdapterManager.STATUS_LICENSETableAdapter = null;
            this.tableAdapterManager.TYPE_ENGINETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Drivers_Khudiakov.DriversDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VEHICLETableAdapter = null;
            // 
            // changE_STATUS_LICENSETableAdapter1
            // 
            this.changE_STATUS_LICENSETableAdapter1.ClearBeforeFill = true;
            // 
            // ChangeStatusLicenseFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(824, 452);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CommentRichTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LicenseListView);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.label1);
            this.Name = "ChangeStatusLicenseFormDialog";
            this.Text = "Измненение статуса лицензии";
            this.Load += new System.EventHandler(this.ChangeStatusLicenseFormDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.ListView LicenseListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private CustomTextBox OldStatusCustomTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private CustomTextBox NewStatusCustomTextBox;
        private System.Windows.Forms.Label label3;
        private DriversDataSet driversDataSet;
        private DriversDataSetTableAdapters.LICENSETableAdapter lICENSETableAdapter;
        private DriversDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DriversDataSetTableAdapters.STATUS_LICENSETableAdapter sTATUS_LICENSETableAdapter;
        private DriversDataSetTableAdapters.DRIVERSTableAdapter dRIVERSTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.RichTextBox CommentRichTextBox;
        private System.Windows.Forms.Label label5;
        private DriversDataSetTableAdapters.CHANGE_STATUS_LICENSETableAdapter changE_STATUS_LICENSETableAdapter1;
    }
}