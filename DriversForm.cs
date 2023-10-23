using Drivers_Khudiakov.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers_Khudiakov
{
    public partial class DriversForm : Form
    {
        public DriversForm()
        {
            InitializeComponent();
        }
        private void DriversForm_Load(object sender, EventArgs e)
        {
            FillDriversList();
            FIOLabel.Text = "";
        }
        void FillDriversList()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driversDataSet.DRIVERS". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter1.Fill(this.driversDataSet1.DRIVERS);
            DriversListView.Items.Clear();
            foreach (DataRow row in driversDataSet1.DRIVERS.Rows)
            {
                string[] items = new string[13];
                items[1] = row[1].ToString();
                items[2] = row[2].ToString();
                items[3] = row[3].ToString();
                items[4] = row[4].ToString();
                items[5] = row[5].ToString();
                items[6] = row[6].ToString();
                items[7] = row[7].ToString();
                items[8] = row[8].ToString();
                items[9] = row[9].ToString();
                items[10] = row[10].ToString();
                items[11] = row[11].ToString();
                items[12] = row[13].ToString();
                ListViewItem it = new ListViewItem()
                {
                    Text = row[0].ToString()
                };
                it.SubItems.AddRange(items);
                DriversListView.Items.Add(it);
            }
        }
        ListViewItem LastSelectedItem = new ListViewItem();
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driversDataSet.DRIVERS". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter1.Fill(this.driversDataSet1.DRIVERS);

            DataRow driver = driversDataSet1.DRIVERS.Select("ID_Driver =" + LastSelectedItem.Text)[0];
            ChangeDataDrivers form = new ChangeDataDrivers("Карточка водителя", false, Convert.ToInt32(driver[0]))
            {
                Surname = driver["Surname"].ToString(),
                _Name = driver["Name"].ToString(),
                LastName = driver["LastName"].ToString(),
                Registration = driver["AddressRegistration"].ToString(),
                Life = driver["AddressLife"].ToString(),
                PassSeries = driver["PassportSerial"].ToString(),
                PassNumber = driver["PassportNumber"].ToString(),
                Email = driver["Email"].ToString(),
                Phone = driver["Phone"].ToString(),
                Company = driver["CompanyJob"].ToString(),
                Job = driver["JobName"].ToString(),
                Photo = driver["Photo"].ToString(),
            };
            if (form.ShowDialog() == DialogResult.OK)
                FillDriversList();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resault = MessageBox.Show("Вы уверены в удалении?", "Удаление.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resault == DialogResult.Yes)
            {
                var driver = driversDataSet1.DRIVERS.Select("ID_Driver =" + LastSelectedItem.Text)[0];
                int delete =driversTableAdapter1.Delete(Convert.ToInt32(driver[0]), driver[1].ToString(), driver[2].ToString(), driver[3].ToString(), driver[4].ToString(), driver[5].ToString(), driver[6].ToString(), driver[7].ToString(), driver[8].ToString(), driver[9].ToString(), driver[10].ToString(), driver[11].ToString());
                if (delete == 0)
                {
                    MessageBox.Show("Удаление не прошло.");
                    return;
                }
                DriversListView.Items.Remove(LastSelectedItem);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ChangeDataDrivers form = new ChangeDataDrivers("Создание карточки водителя", true);
            if (form.ShowDialog() == DialogResult.OK)
                FillDriversList();
        }

        private void DriversListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            LastSelectedItem = e.Item;
            var driver = driversDataSet1.DRIVERS.Select("ID_Driver =" + LastSelectedItem.Text)[0];
            string absPath = System.IO.Directory.GetCurrentDirectory()+ @"\Assets\";
            ImagePictureBox.Image = Image.FromFile(driver["Photo"].ToString() != "" ? absPath + driver["Photo"].ToString() : absPath + "no-image.png");
            FIOLabel.Text = $"{driver[1]} {driver[2]} {driver[3]}";
        }

        private void DriversListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(DriversListView, e.X, e.Y);
        }

        private void DriversForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new NavigationForm().Show(); 
        }
    }
}
