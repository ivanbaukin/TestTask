using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    class GetNumericUpDown
    {
        public void GetNumeric(PropertyInfo[] collection, object models, TableLayoutPanel tlp)
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
            }
        }
    }
}
