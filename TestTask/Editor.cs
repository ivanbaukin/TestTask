using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
            Edit();
        }

        public void Edit()
        {
            var models = new Models();
            var type = models.GetType();
            var prop = type.GetProperties();

            foreach (var item in prop)
            {
                UCInt uci = new UCInt();
                tlp.Controls.Add(uci);
            }
        }
    }
}
