using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers_Khudiakov.Forms
{
    public partial class ReportViewerLicenseForm : Form
    {
        protected int License;
        public ReportViewerLicenseForm(int license)
        {
            InitializeComponent();
            License = license;
        }

        private void ReportViewerLicenseForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "reportsDataSet.LicenseDrivers". При необходимости она может быть перемещена или удалена.
            this.licenseDriversTableAdapter.FillLicenseDrivers(this.reportsDataSet.LicenseDrivers);
            string executablePath = System.IO.Directory.GetCurrentDirectory() + "\\Assets\\";
            reportsDataSetBindingSource.Filter = "ID_License = " + License;
            var item = reportsDataSet.LicenseDrivers.Select("ID_License =" + License)[0];
                
            ReportParameter Surname = new ReportParameter("Surname", item["Surname"].ToString());
            ReportParameter Name = new ReportParameter("Name", item["Name"].ToString());
            ReportParameter LastName = new ReportParameter("LastName", item["LastName"].ToString());
            ReportParameter Registration = new ReportParameter("Registration", item["AddressRegistration"].ToString());
            ReportParameter LicenseDate = new ReportParameter("LicenseDate", item["LicenseDate"].ToString());
            ReportParameter ExpiryDate = new ReportParameter("ExpiryDate", item["ExpiryDate"].ToString());
            ReportParameter SerianNumber = new ReportParameter("SerianNumber", item["LicenseSeries"].ToString() + " " + item["LicenseNumber"].ToString());
            ReportParameter Category = new ReportParameter("Category", item["Category"].ToString());
            // ReportParameter PhotoDriver = new ReportParameter("PhotoDriver", System.IO.Directory.GetCurrentDirectory() + "\\Assets\\" + item["Photo"].ToString()+".png", true);
            var path = new Uri($"{executablePath + item["Photo"].ToString()}");
            ReportParameter PhotoDriver = new ReportParameter("PhotoDriver", "File:\\" + path.AbsolutePath);


            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { Surname });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { Name });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { LastName });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { Registration });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { LicenseDate });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { ExpiryDate });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { SerianNumber });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { Category });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { PhotoDriver });

                
            this.reportViewer1.RefreshReport();
            //reportViewer1.
        }

        private void ReportViewerLicenseForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"Ширина {Width} Высота {Height}");
        }
    }
}
