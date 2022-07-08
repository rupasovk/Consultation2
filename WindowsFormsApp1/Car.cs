using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Car : Object
    {
        #region Поля
        public string Mark = "Volvo";
        public string Model = "V40";
        public DateTime RegistationDate = DateTime.Now;

        public string Owner = "Misha";
        #endregion

        #region Методы

        public void Say(TextBox outputTextBox)
        {
            outputTextBox.Text = ToString();
        }
        
        public void CheckOwner(string Name, TextBox outputTextBox)
        {
            if (Owner == Name)
                outputTextBox.Text = "Является владельцем";
            else
                outputTextBox.Text = "Не является владельцем";
        }

        public override string ToString()
        {
            int a = 10;
            return $"Mark: {Mark} Model: {Model} Registration Date: {RegistationDate} Owner: {Owner}";
        }
        #endregion
    }
}
