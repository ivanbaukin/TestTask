using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        //main for changes
        GetProperties getProp = new GetProperties();
        
        public void Edit()
        {
            var type = getProp.GetType();
            var array = type.GetProperties();
            var tlp = tableLayoutPanel;

            GetUserControl getUC = new GetUserControl();
            getUC.GetUC(array, getProp, tlp);
        }
        //test properties
        public void MyProp()
        {
            getProp.MyInt = 15;
            getProp.MyString = "Text 1";
            getProp.Date1 = DateTime.Today;
            getProp.MyInt2 = 20;
            getProp.MyInt3 = 35;
            getProp.MyInt4 = 150;
            getProp.MyInt5 = 101;
            getProp.MyInt6 = 102;
            getProp.MyInt7 = 30;
            getProp.MyInt8 = 32;
            getProp.MyString2 = "Text 2";
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //todo editor set value 
        }
    }
}
