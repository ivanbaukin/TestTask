using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace TestTask
{
    class GetDataTimePicker
    {
        public void GetDateTime(PropertyInfo[] collection, object models, TableLayoutPanel tlp)
        {
            foreach (var item in collection)
            {
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
    }
}
