using System;
using System.Collections.Generic;
using System.Text;

namespace Adress_Book.Moduls
{
    public class Phone
    {
        private string number;

        public Phone(string number)
        {
            this.number = number;
        }
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
