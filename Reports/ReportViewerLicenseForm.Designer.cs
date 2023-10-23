
namespace Drivers_Khudiakov.Forms
{
    partial class ReportViewerLicenseForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.driversTableAdapter1 = new Drivers_Khudiakov.DriversDataSetTableAdapters.DRIVERSTableAdapter();
            this.reportsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsDataSet = new Drivers_Khudiakov.ReportsDataSet();
            this.licenseDriversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licenseDriversTableAdapter = new Drivers_Khudiakov.ReportsDataSetTableAdapters.LicenseDriversTableAdapter();
            this.tableAdapterManager = new Drivers_Khudiakov.ReportsDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseDriversBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportLicenseDriverDataSet";
            reportDataSource1.Value = this.reportsDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Drivers_Khudiakov.Forms.Reports.ReportLicense.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(978, 684);
            this.reportViewer1.TabIndex = 0;
            // 
            // driversTableAdapter1
            // 
            this.driversTableAdapter1.ClearBeforeFill = true;
            // 
            // reportsDataSetBindingSource
            // 
            this.reportsDataSetBindingSource.DataSource = this.reportsDataSet;
            this.reportsDataSetBindingSource.Position = 0;
            // 
            // reportsDataSet
            // 
            this.reportsDataSet.DataSetName = "ReportsDataSet";
            this.reportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // licenseDriversBindingSource
            // 
            this.licenseDriversBindingSource.DataMember = "LicenseDrivers";
            this.licenseDriversBindingSource.DataSource = this.reportsDataSet;
            // 
            // licenseDriversTableAdapter
            // 
            this.licenseDriversTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Drivers_Khudiakov.ReportsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ReportViewerLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 684);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportViewerLicenseForm";
            this.Text = "ReportViewerLicenseForm";
            this.Load += new System.EventHandler(this.ReportViewerLicenseForm_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ReportViewerLicenseForm_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseDriversBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportsDataSetBindingSource;
        private ReportsDataSet reportsDataSet;
        private System.Windows.Forms.BindingSource licenseDriversBindingSource;
        private ReportsDataSetTableAdapters.LicenseDriversTableAdapter licenseDriversTableAdapter;
        private ReportsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DriversDataSetTableAdapters.DRIVERSTableAdapter driversTableAdapter1;
    }
}