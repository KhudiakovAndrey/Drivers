using Drivers_Khudiakov.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers_Khudiakov
{
    public partial class ChangeDataDrivers : Form
    {
        protected int ID;
        protected bool AddOrChange;
        public string Surname { get { return SurnamecustomTextBox.Text; } set { SurnamecustomTextBox.Text = value; } }
        public string _Name { get { return NamecustomTextBox.Text; } set { NamecustomTextBox.Text = value; } }
        public string LastName { get { return LastNamecustomTextBox.Text; } set { LastNamecustomTextBox.Text = value; } }
        public string Registration { get { return RegistrcustomTextBox.Text; } set { RegistrcustomTextBox.Text = value; } }
        public string Life { get { return LifecustomTextBox.Text; } set { LifecustomTextBox.Text = value; } }
        public string PassSeries { get { return PassSercustomTextBox.Text; } set { PassSercustomTextBox.Text = value; } }
        public string PassNumber { get { return PassNumcustomTextBox.Text; } set { PassNumcustomTextBox.Text = value; } }
        public string Email { get { return EmailcustomTextBox.Text; } set { EmailcustomTextBox.Text = value; } }
        public string Phone { get { return PhonecustomTextBox.Text; } set { PhonecustomTextBox.Text = value; } }
        public string Company { get { return CompanycustomTextBox.Text; } set { CompanycustomTextBox.Text = value; } }
        public string Job { get { return JobcustomTextBox.Text; } set { JobcustomTextBox.Text = value; } }
        public string Photo { get { return ImagePictureBox.Tag.ToString(); } set {
                string absPath = System.IO.Directory.GetCurrentDirectory() + @"\Assets\";
                ImagePictureBox.Image = Image.FromFile(value != "" ? Path.IsPathRooted(value) ? value : absPath + value : absPath + "no-image.png");
                ImagePictureBox.Tag = value; } }

        public ChangeDataDrivers(string titleText, bool addOrChange, int id = 0)
        {
            InitializeComponent();
            TitleLabel.Text = titleText;
            AddOrChange = addOrChange;
            ID = id;

             
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddOrChange)
                {
                    //add
                    dRIVERSTableAdapter.Insert(Surname, _Name, LastName, PassSeries, PassNumber, Registration, Life, Company, Job, Phone, Email, Path.GetFileName(Photo), "");
                }
                else
                {
                    //change
                    DataRow newDriver = driversDataSet.DRIVERS.Select("ID_Driver =" + ID)[0];
                    newDriver.SetField<string>("Surname", Surname);
                    newDriver.SetField<string>("Name", _Name);
                    newDriver.SetField<string>("LastName", LastName);
                    newDriver.SetField<string>("PassportSerial", PassSeries);
                    newDriver.SetField<string>("PassportNumber", PassNumber);
                    newDriver.SetField<string>("AddressRegistration", Registration);
                    newDriver.SetField<string>("AddressLife", Life);
                    newDriver.SetField<string>("CompanyJob", Company);
                    newDriver.SetField<string>("JobName", Job);
                    newDriver.SetField<string>("Phone", Phone);
                    newDriver.SetField<string>("Email", Email);
                    newDriver.SetField<string>("Photo", newDriver["Photo"].ToString() == "" ? "" : newDriver["Photo"].ToString());
                    newDriver.SetField<string>("Description", newDriver["Description"].ToString() == "" ? "" : newDriver["Description"].ToString());

                    int update = dRIVERSTableAdapter.Update(newDriver);
                    if (update == 0)
                        MessageBox.Show("Не обновилось");
                }
            }
            catch(Exception ex)
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

        private void ChangeDataDrivers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driversDataSet.DRIVERS". При необходимости она может быть перемещена или удалена.
            this.dRIVERSTableAdapter.Fill(this.driversDataSet.DRIVERS);
            licenseTableAdapter1.Fill(driversDataSet.LICENSE);
            statuS_LICENSETableAdapter1.Fill(driversDataSet.STATUS_LICENSE);
            var LicenseRows = driversDataSet.LICENSE.Select("ID_Driver =" + ID);
            if (LicenseRows.Length > 0)
            {
                LicenseLabel.Visible = false;
                foreach (var row in LicenseRows)
                {
                    string status = ConvertIDtoTitleStatus(row[7].ToString());
                    LicenseFlowLayoutPanel.Controls.Add(new LicenseControl(Convert.ToInt32(row[0]), Convert.ToInt32(row[1]), Convert.ToDateTime(row[2]).ToString("d"), Convert.ToDateTime(row[3]).ToString("d"), row[4].ToString(), row[5].ToString().Trim(), row[6].ToString(), status));
                }
            }
            else
            {
                LicenseLabel.Visible = true;
            }

        }
        private string ConvertIDtoTitleStatus(string id)
        {
            var row = driversDataSet.STATUS_LICENSE.Where(s => s.ID_StatusLicense == id).Select(s => new { s.Title }).ToList()[0];
            return row.Title;
        }


        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;",
                Multiselect = false,
            };
            openFileDialog.ShowDialog();
            Photo = openFileDialog.FileName;
        }
    }
}
