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
    public partial class ChangeStatusControl : UserControl
    {
        protected int ID;
        protected int IDLicense;
        public string OldStatus { get { return OldStatus; } set { OldStatusLabel.Text += value; } }
        public string NewStatus { get { return NewStatus; } set { NewStatusLabel.Text += value; } }
        public string Date { get { return Date; } set { DateLabel.Text = value; } }
        public string Comment { get { return Comment; } set { CommentLabel.Text += value; } }

        public ChangeStatusControl(int id, int idLicense, string oldStatus, string newStatus, string date, string comment )
        {
            InitializeComponent();
            ID = id;
            IDLicense = idLicense;
            OldStatus = oldStatus;
            NewStatus = newStatus;
            Date = date;
            Comment = comment;
        }
    }
}
