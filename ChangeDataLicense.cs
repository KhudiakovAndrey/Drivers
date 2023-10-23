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
    public partial class ChangeDataLicense : Form
    {
        protected int ID;
        protected DriversDataSet.DRIVERSRow Driver;
        public string LicenseDate { get { return LicenseDateTimePicker.Value.ToString("d"); } set { LicenseDateTimePicker.Value = Convert.ToDateTime(value); } }
        public string ExpiryDate { get { return ExpryDateTimePicker.Value.ToString("d"); } set { ExpryDateTimePicker.Value = Convert.ToDateTime(value); } }
        public string Category { get { return CategoryCustomTextBox.Text; } set { CategoryCustomTextBox.Text = value; } }
        public string LicenseSeries { get { return SeriesCustomTextBox.Text; } set { SeriesCustomTextBox.Text = value; } }
        public string LicenseNumber { get { return NumberCustomTextBox.Text; } set { NumberCustomTextBox.Text = value; } }
        
        public string NewStatusLicense { get; set; }
        protected bool AddOrChange;
        protected string Status;
        protected string OldStatusLicense;
        public ChangeDataLicense(bool addOrChange, string status = null, int id = 0, DriversDataSet.DRIVERSRow driver = null)
        {
            InitializeComponent();
            AddOrChange = addOrChange;
            ID = id;
            Driver = driver;
            Status = status;
            OldStatusLicense = status;
        }
        private void ChangeDataLicense_Load(object sender, EventArgs e)
        {
            Fill();
            DriversDataGridView.Columns[0].Visible = false;
            foreach (DataGridViewColumn column in DriversDataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            DriversDataGridView.Height = 0;
            if (Status != null)
            {
                var status = driversDataSet.STATUS_LICENSE.Where(s => s.ID_StatusLicense == Status).ToList()[0];
                StatusComboBox.SelectedValue = status.ID_StatusLicense;
            }
        }
        void Fill()
        {
            this.licenseTableAdapter1.Fill(this.driversDataSet.LICENSE);
            this.driversTableAdapter1.Fill(this.driversDataSet.DRIVERS);
            this.statuS_LICENSETableAdapter1.Fill(this.driversDataSet.STATUS_LICENSE);
            changE_STATUS_LICENSETableAdapter1.Fill(driversDataSet.CHANGE_STATUS_LICENSE);
            if (Driver != null)
            {
                tbImagePictureBox.Image = Image.FromFile(Driver.Photo != "" ? absPath + Driver.Photo : absPath + "no-image.png");
                DriverComboBox.Text = $"{Driver.Surname} {Driver.Name} {Driver.LastName}";
                DriversDataGridView.Height = 0;
            }
            else
                DriverComboBox.Text = "";
            var ChangedRows = driversDataSet.CHANGE_STATUS_LICENSE.Select("ID_License =" + ID);
            if (ChangedRows.Length > 0)
            {
                ChangedLabel.Visible = false;
                foreach (var row in ChangedRows)
                {
                    string oldStatus = ConvertIDtoTitleStatus(row[2].ToString());
                    string newStatus = ConvertIDtoTitleStatus(row[3].ToString());
                    ChangeStatusFlowLayoutPanel.Controls.Add(new ChangeStatusControl(Convert.ToInt32(row[0]), Convert.ToInt32(row[1]), oldStatus, newStatus, Convert.ToDateTime(row[4]).ToString("d"), row[5].ToString()));
                }
            }
            else
            {
                ChangedLabel.Visible = true;
            }
        }
        string absPath = System.IO.Directory.GetCurrentDirectory() + @"\Assets\";

        private string ConvertIDtoTitleStatus(string id)
        {
            var row = driversDataSet.STATUS_LICENSE.Where(s => s.ID_StatusLicense == id).Select(s => new { s.Title }).ToList()[0];
            return row.Title;
        }
        private void OKbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddOrChange)
                {
                    //add
                    licenseTableAdapter1.Insert(Driver.ID_Driver, Convert.ToDateTime(LicenseDate), Convert.ToDateTime(ExpiryDate), Category, LicenseSeries, LicenseNumber, NewStatusLicense);
                }
                else
                {
                    //change
                    var oldstaturRow = driversDataSet.STATUS_LICENSE.Where(sl => sl.ID_StatusLicense == OldStatusLicense ).Select(sl => new { sl.Title }).ToList()[0];
                    var newStatus = driversDataSet.STATUS_LICENSE.Select("Title ='" + StatusComboBox.Text + "'")[0];
                    if (newStatus["Title"].ToString() != oldstaturRow.Title)
                    {
                        ChangeStatusLicenseFormDialog dialog = new ChangeStatusLicenseFormDialog(ID, Driver, oldstaturRow.Title, newStatus["Title"].ToString());
                        dialog.ShowDialog();
                        if (dialog.DialogResult == DialogResult.No)
                            return;
                    }
                    DataRow newLicens = driversDataSet.LICENSE.Select("ID_License =" + ID)[0];
                    newLicens.SetField<int>("ID_Driver", Driver.ID_Driver);
                    newLicens.SetField<DateTime>("LicenseDate", Convert.ToDateTime(LicenseDate));
                    newLicens.SetField<DateTime>("ExpiryDate", Convert.ToDateTime(ExpiryDate));
                    newLicens.SetField<string>("Category", Category);
                    newLicens.SetField<string>("LicenseSeries", LicenseSeries);
                    newLicens.SetField<string>("LicenseNumber", LicenseNumber);
                    newLicens.SetField<string>("ID_StatusLicense", newStatus[0].ToString());

                    int update = licenseTableAdapter1.Update(newLicens);
                    if (update == 0)
                        MessageBox.Show("Не обновилось");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        private void DriverComboBox_TextChanged(object sender, EventArgs e)
        {
            if (DriverComboBox.TextLength <= 0)
            {
                DriversDataGridView.Height = 0;
                tbImagePictureBox.Image = null;
                Driver = null;
                return;
            }
            bindingSource1.Filter = $"Surname + ' ' + Name + ' ' + LastName LIKE '%{DriverComboBox.Text}%'";
            if (DriversDataGridView.Rows.Count > 0)
            {
                DriversDataGridView.Height = DriversDataGridView.RowTemplate.Height * 5;
            }
            else
            {
                DriversDataGridView.Height = 0;
                tbImagePictureBox.Image = null;
                Driver = null;
            }
        }

        private void dRIVERSBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (DriversDataGridView.Rows.Count <= 0)
                return;

            DriversDataGridView.Columns.RemoveAt(1);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();

            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.HeaderText = "Фото";
            DriversDataGridView.Columns.Insert(1, imageColumn);

            for (int i = 0; i < DriversDataGridView.Rows.Count; i++)
            {
                var row = driversDataSet.DRIVERS.Where(d => d.ID_Driver == Convert.ToInt32(DriversDataGridView.Rows[i].Cells[0].Value)).ToList()[0];
                Image p = new Bitmap(row.Photo != "" ? absPath + row.Photo : absPath + "no-image.png");
                DriversDataGridView.Rows[i].Cells[1].Value = p;
            }

        }
        private void DriversDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DriversDataGridView.SelectedRows.Count <= 0)
                return;
            var driver = driversDataSet.DRIVERS.Where(d => d.ID_Driver == Convert.ToInt32(DriversDataGridView.SelectedRows[0].Cells[0].Value)).ToList()[0];
            tbImagePictureBox.Image = Image.FromFile(driver.Photo != "" ? absPath + driver.Photo : absPath + "no-image.png");
            DriverComboBox.Text = $"{driver.Surname} {driver.Name} {driver.LastName}";
            DriversDataGridView.Height = 0;
            Driver = driver;
        }

        private void AddDriverButton_Click(object sender, EventArgs e)
        {
            ChangeDataDrivers driver = new ChangeDataDrivers("Добавлениеб", true);
            if (driver.ShowDialog() == DialogResult.OK)
                Fill();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            new ReportViewerLicenseForm(ID).Show();
        }
    }
}
