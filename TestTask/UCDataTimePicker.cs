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
    public partial class UCDataTimePicker : UserControl
    {
        public UCDataTimePicker()
        {
            InitializeComponent();
        }

        public void SetUserControlDateTimePicker(DateTime date, string name)
        {
            if (date > dateTimePicker.MaxDate)
            {
                MessageBox.Show($"Ваше свойство {name} содержит: {date}, что превышает максимальное значение: {dateTimePicker.MaxDate}", "Ошибка!");
                lblDateTime.Text = name;
            }
            else if (date < dateTimePicker.MinDate)
            {
                MessageBox.Show($"Ваше свойство {name} содержит: {date}, что превышает максимальное значение: {dateTimePicker.MinDate}", "Ошибка!");
                lblDateTime.Text = name;
            }
            dateTimePicker.Value = date;
            lblDateTime.Text = name;
        }
    }
}
