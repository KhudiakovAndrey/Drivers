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
    public partial class LicensesForm : Form
    {
        public LicensesForm()
        {
            InitializeComponent();
        }
        private void LicensesForm_Load(object sender, EventArgs e)
        {
            FillLicenseList();
        }
        void FillLicenseList()
        {
            driversTableAdapter1.Fill(driversDataSet1.DRIVERS);
            licenseTableAdapter1.Fill(driversDataSet1.LICENSE);
            statuS_LICENSETableAdapter1.Fill(driversDataSet1.STATUS_LICENSE);
            LicenseListView.Items.Clear();
            foreach (DataRow row in driversDataSet1.LICENSE.Rows)
            {
                string[] items = new string[9];
                DataRow tempRow;
                tempRow = row.GetParentRow("FK_LICENSE_DRIVERS");
                items[1] = "•";

                items[2] = $"{tempRow[1]} {tempRow[2]} {tempRow[3]}";
                items[3] = Convert.ToDateTime(row[2]).ToString("d");
                items[4] = Convert.ToDateTime(row[3]).ToString("d");
                items[5] = row[4].ToString();
                items[6] = row[5].ToString();
                items[7] = row[6].ToString();
                tempRow = row.GetParentRow("FK_LICENSE_STATUS_LICENSE");
                items[8] = tempRow[1].ToString();
                ListViewItem it = new ListViewItem();
                it.Text = row[0].ToString();
                it.UseItemStyleForSubItems = false;

                it.SubItems.AddRange(items);
                LicenseListView.Items.Add(it);
                string line = items[8];
                LicenseListView.Items[it.Index].SubItems[1].Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
                if (line.Replace(" ", "") == "Изъят" || line.Replace(" ", "") == "Приостановлен")
                    LicenseListView.Items[it.Index].SubItems[1].ForeColor = Color.Red;
                else if (line.Replace(" ", "") == "Активен")
                    LicenseListView.Items[it.Index].SubItems[1].ForeColor = Color.Green;
                else if (line.Replace(" ", "") == "Утратил силу")
                    LicenseListView.Items[it.Index].SubItems[1].ForeColor = Color.DarkGray;
            }
        }
        ListViewItem LastSelectedItem = new ListViewItem();
        private void AddButton_Click(object sender, EventArgs e)
        {
            ChangeDataLicense change = new ChangeDataLicense(true);
            if (change.ShowDialog() == DialogResult.OK)
                FillLicenseList();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var license = driversDataSet1.LICENSE.Where(l => l.ID_License == int.Parse(LastSelectedItem.Text)).ToList()[0];
            var drive = driversDataSet1.DRIVERS.Where(d => d.ID_Driver == license.ID_Driver).ToList()[0];
            ChangeDataLicense change = new ChangeDataLicense(false, license.ID_StatusLicense, license.ID_License, drive)
            {
                LicenseDate = license.LicenseDate.ToString(),
                ExpiryDate = license.ExpiryDate.ToString(),
                Category = license.Category,
                LicenseSeries = license.LicenseSeries,
                LicenseNumber = license.LicenseNumber,
            };
            if (change.ShowDialog() == DialogResult.OK)
                FillLicenseList();
        }

        private void LicenseListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            LastSelectedItem = e.Item;
        }

        private void LicenseListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(LicenseListView, e.X, e.Y);
        }

        private void LicensesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new NavigationForm().Show();
        }
    }
}
