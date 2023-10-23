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
    public partial class NavigationForm : Form
    {
        public NavigationForm()
        {
            InitializeComponent();
        }

        private void DriversButton_Click(object sender, EventArgs e)
        {
            new DriversForm().Show();
            this.Hide();
        }

        private void LicenseButton_Click(object sender, EventArgs e)
        {
            new LicensesForm().Show();
            Hide();
        }
    }
}
