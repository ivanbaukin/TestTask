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
    public partial class UCInt : UserControl
    {
        public UCInt()
        {
            InitializeComponent();
        }

        public void SetUserControlNumeric(decimal value, string name)
        {
            if (value > numericUpDown.Maximum)
            {
                MessageBox.Show($"Ваше свойство {name} содержит: {value}, что превышает максимальное значение: {numericUpDown.Maximum}", "Ошибка!");
                lblMyInt.Text = name;
            }
            else if(value < numericUpDown.Minimum)
            {
                MessageBox.Show($"Ваше свойство {name} содержит: {value}, что ниже минимального значения: { numericUpDown.Minimum}", "Ошибка!");
                lblMyInt.Text = name;
            }
            else
            {
                numericUpDown.Value = value;
                lblMyInt.Text = name;
            }
        }
    }
}
