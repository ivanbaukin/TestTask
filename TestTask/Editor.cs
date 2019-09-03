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
            MyProp();
            Edit();
        }

        Models models = new Models();
        public void Edit()
        {
            var type = models.GetType();
            var array = type.GetProperties();

            foreach (var item in array)
            {
                if (item.PropertyType == typeof(Int32))
                {
                    UCInt uCInt = new UCInt();

                    var value = Convert.ToDecimal(item.GetValue(models));
                    string getNameProp = item.Name;
                    uCInt.SetUserControlNumeric(value, getNameProp);

                    tlp.Controls.Add(uCInt);
                }

                if (item.PropertyType == typeof(String))
                {
                    UCText uCText = new UCText();

                    var value = item.GetValue(models).ToString();
                    string getNameProp = item.Name;
                    uCText.SetUserControlTextBox(value, getNameProp);

                    tlp.Controls.Add(uCText);
                }

                if (item.PropertyType == typeof(DateTime))
                {
                    UCDataTimePicker uCDataTimePicker = new UCDataTimePicker();

                    var value = Convert.ToDateTime(item.GetValue(models));
                    string getNameProp = item.Name;
                    uCDataTimePicker.SetUserControlDateTimePicker(value, getNameProp);

                    tlp.Controls.Add(uCDataTimePicker);
                }
            }
        }
        public void MyProp()
        {
            models.MyInt = 15;
            models.MyString = "Text 1";
            models.Date1 = DateTime.Today.AddDays(4).AddMonths(5);
            models.MyInt2 = 20;
            models.MyInt3 = 35;
            models.MyInt4 = 150;
            models.MyInt5 = 100;
            models.MyInt6 = -4;
            models.MyInt7 = 30;
            models.MyInt8 = 32;
            models.MyString2 = "Text 2";
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
