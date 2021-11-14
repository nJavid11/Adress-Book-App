using System;
using System.Collections.Generic;
using System.Text;

namespace Adress_Book.Moduls
{
    public class Home
    {
        private string adress;

        public Home(string adress)
        {
            this.adress = adress;
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
    }
}
