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
    public partial class LicenseControl : UserControl
    {
        protected int ID;
        protected int IDDriver;
        protected string LicenseDate { get { return LicenseDate; } set { StartLabel.Text += value; } }
        protected string ExpryDate { get { return ExpryDate; } set { FinishLabel.Text += value; } }
        protected string Category { get { return Category; } set { CategoryLabel.Text += value; } }
        protected string Seria { get { return Seria; } set { SeriaLabel.Text = value; } }
        protected string Number { get { return Number; } set { NumberLabel.Text = value; } }
        protected string Status { get { return Status; } set { StatusLabel.Text += value; } }
        public LicenseControl(int id, int driver, string start, string finish, string category, string seria, string number, string status)
        {
            InitializeComponent();
            ID = id;
            IDDriver = driver;
            LicenseDate = start;
            ExpryDate = finish;
            Category = category;
            Seria = seria;
            Number = number;
            Status = status;
        }
    }
}
