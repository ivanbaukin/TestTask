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
            var array = type.GetProperties();

            models.MyInt = 15;
            models.MyString = "Text 1";
            models.MyInt2 = 13;
            models.MyString2 = "Tsdhhf";

            foreach (var item in array)
            {
                if (item.PropertyType == typeof(Int32))
                {
                    UCInt uci = new UCInt();
                    var result = Convert.ToDecimal(item.GetValue(models));
                    uci.SetUserControlInt(result);
                    tlp.Controls.Add(uci);
                    
                }

                if (item.PropertyType == typeof(String))
                {
                    UCText uct = new UCText();
                    var result = item.GetValue(models).ToString();
                    uct.SetUserControlTextBox(result);
                    tlp.Controls.Add(uct);
                    
                }
            }
        }
    }
}
