using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public partial class UCDataTimePicker : UserControl
    {
        public UCDataTimePicker()
        {
            InitializeComponent();
        }

        public void SetUserControlDateTimePicker(DateTime date, string name)
        {
            dateTimePicker.Value = date;
            lblDateTime.Text = name;
        }
    }
}
