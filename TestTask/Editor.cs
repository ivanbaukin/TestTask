﻿using System;
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

            models.MyInt = 15;
            models.MyString = "Text 1";
            models.Date1 = DateTime.Today;
            models.MyInt2 = 20;
            models.MyInt3 = 35;
            models.MyInt4 = 150;
            models.MyInt5 = 101;
            models.MyInt6 = 102;
            models.MyInt7 = 30;
            models.MyInt8 = 32;
            models.MyString2 = "Text 2";

            var type = models.GetType();
            var array = type.GetProperties();
            var tlp = tableLayoutPanel;

            GetUserControl getUC = new GetUserControl();
            getUC.GetUC(array, models, tlp);

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
