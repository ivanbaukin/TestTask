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
    public partial class UCText : UserControl
    {
        public UCText()
        {
            InitializeComponent();
        }

        public void SetUserControlTextBox(string value)
        {
            MyTextBox.Text = value;
        }
    }
}
