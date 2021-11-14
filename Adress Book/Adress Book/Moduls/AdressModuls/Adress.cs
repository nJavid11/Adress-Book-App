using System;
using System.Collections.Generic;
using System.Text;

namespace Adress_Book.Moduls
{
    public class Adress
    {
        private string email;
        private Home home;

        public Adress(string email, Home home)
        {
            this.email = email;
            this.home = home;
        }
        public string Email
        {
            get { return email; }
            set { email = value; }

        }

        public Home Home
        {
            get { return home; }
            set { home = value; }

        }
    }
}
