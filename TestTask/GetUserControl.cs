using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    class GetUserControl
    {
        public void GetUC(PropertyInfo[] collection, object models, TableLayoutPanel tlp)
        {
            foreach (var item in collection)
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

                    var value = item.GetValue(models);
                    string getNameProp = item.Name;

                    if (value == null)
                    {
                        string n = "null";
                        MessageBox.Show($"Ваше свойство {item.Name} содержит: {n}!", "Ошибка!");
                        uCText.SetUserControlTextBox(n, item.Name);
                    }
                    else
                    {
                        uCText.SetUserControlTextBox(value.ToString(), getNameProp);
                    }

                    tlp.Controls.Add(uCText);
                }

                if (item.PropertyType == typeof(DateTime))
                {
                    UCDateTimePicker uCDataTimePicker = new UCDateTimePicker();

                    var value = Convert.ToDateTime(item.GetValue(models));
                    string getNameProp = item.Name;
                    uCDataTimePicker.SetUserControlDateTimePicker(value, getNameProp);

                    tlp.Controls.Add(uCDataTimePicker);
                }
            }
        }
    }
}
