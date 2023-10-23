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
    public partial class ChangeStatusLicenseFormDialog : Form
    {
        protected int ID;
        protected DriversDataSet.DRIVERSRow Driver;
        public ChangeStatusLicenseFormDialog(int id, DriversDataSet.DRIVERSRow driver, string oldStatus, string newStatus)
        {
            InitializeComponent();
            ID = id;
            Driver = driver;
            OldStatusCustomTextBox.Text = oldStatus;
            NewStatusCustomTextBox.Text = newStatus;
        }
        private void ChangeStatusLicenseFormDialog_Load(object sender, EventArgs e)
        {
            FillLicenseList();
            OldStatusCustomTextBox.Enabled = false;
            NewStatusCustomTextBox.Enabled = false;
        }
        void FillLicenseList()
        {
            this.changE_STATUS_LICENSETableAdapter1.Fill(this.driversDataSet.CHANGE_STATUS_LICENSE);
            this.dRIVERSTableAdapter.Fill(this.driversDataSet.DRIVERS);
            this.sTATUS_LICENSETableAdapter.Fill(this.driversDataSet.STATUS_LICENSE);
            this.lICENSETableAdapter.Fill(this.driversDataSet.LICENSE);
            LicenseListView.Items.Clear();
            foreach (DataRow row in driversDataSet.LICENSE.Select("ID_Driver =" + Driver.ID_Driver))
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


        private void button1_Click(object sender, EventArgs e)
        {
            var oldStatusRow = driversDataSet.STATUS_LICENSE.Where(s => s.Title == OldStatusCustomTextBox.Text).ToList()[0];
            var newStatusRow = driversDataSet.STATUS_LICENSE.Where(s => s.Title == NewStatusCustomTextBox.Text).ToList()[0];

            int i =changE_STATUS_LICENSETableAdapter1.Insert(ID, oldStatusRow.ID_StatusLicense, newStatusRow.ID_StatusLicense, DateTime.Now, CommentRichTextBox.Text);
            if (i > 0)
                MessageBox.Show("Ok");
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.No;
            Close();
        }
    }
}
