using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    class GetTextBox
    {
        public void GetText(PropertyInfo[] collection, object models, TableLayoutPanel tlp)
        {
            foreach (var item in collection)
            {
                if (item.PropertyType == typeof(String))
                {
                    UCText uCText = new UCText();

                    var value = item.GetValue(models).ToString();
                    string getNameProp = item.Name;
                    uCText.SetUserControlTextBox(value, getNameProp);

                    tlp.Controls.Add(uCText);
                }
            }
        }
    }
}
