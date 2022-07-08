using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string myString = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Консультация 1
            ////    int[] a = new int[5];
            ////    a[0] = 12;
            ////    a[1] = 253;
            ////    a[2] = 72;
            ////    a[3] = 125125;
            ////    a[4] = 12454;

            ////    foreach (var b in a)
            ////    {
            ////        MessageBox.Show(b.ToString());
            ////    }

            //// Вариант для Боди Билдеров
            //var s = "G3f5tGh235fs";

            //int a = 0;
            //int sum = 0;

            //foreach (var c in s)
            //{
            //    if (int.TryParse(c.ToString(), out a))
            //        sum += a;
            //}
            //MessageBox.Show(sum.ToString());

            //// Вариант НЕ для Боди Билдеров
            //s = "G3f5tGh235fs";

            //a = 0;
            //sum = 0;

            //var charList = new char[]{ '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //var g = Convert.ToInt32(s);

            //foreach (var c in s)
            //{
            //    if (charList.Contains(c))
            //        sum += Convert.ToInt32(c);
            //}
            //MessageBox.Show(sum.ToString());
            #endregion

            #region Консультация 2

            DateTime date1 = new DateTime(2015, 7, 20, 18, 30, 25);

            date1 = date1.AddDays(-3);

            OutputTextBox.Text = date1.ToString();

            //Console.WriteLine(date1.ToLocalTime()); // 20.07.2015 21:30:25
            //Console.WriteLine(date1.ToUniversalTime()); // 20.07.2015 15:30:25
            //Console.WriteLine(date1.ToLongDateString()); // 20 июля 2015 г.
            //Console.WriteLine(date1.ToShortDateString()); // 20.07.2015
            //Console.WriteLine(date1.ToLongTimeString()); // 18:30:25
            //Console.WriteLine(date1.ToShortTimeString()); // 18:30

            #endregion
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            //OutputTextBox.Text = myDateTimePicker.Value.ToString();
            Car car1 = new Car();
            //car1.Say(OutputTextBox);

            //car1.CheckOwner(InputTextBox.Text, OutputTextBox);

            OutputTextBox.Text = myString;
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            myString = InputTextBox.Text;
        }
    }
}
