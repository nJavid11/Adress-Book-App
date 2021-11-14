using System;
using System.Collections.Generic;
using System.Text;

namespace Adress_Book.Moduls
{
    public class Person
    {
        private int id;
        private string name;
        private string surname;
        private Phone phone;

        public Person(int id,String name, String surname, Phone phone)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.id = id;
        }
        public int Id
        {
            get { return this.id; }
            set { this.id =value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { name = value; }
        }
        public Phone Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}
