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
        /// <summary>
        /// Присваевает Lable и TextBox значение.
        /// </summary>
        public void SetUserControlTextBox(string value, string name)
        {
            MyTextBox.Text = value;
            lblMyText.Text = name;
        }
    }
}
