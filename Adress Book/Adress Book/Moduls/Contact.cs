using Adress_Book.Moduls;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adress_Book
{
    public class Contact
    {
        private Person person;
        private Adress adress;

        public Contact(Person person, Adress adress)
        {
            this.person = person;
            this.adress = adress;
        }
        public Person Person
        {
            get { return person; }
            set { person = value; }
        }
        public Adress Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string FullInfo() {

            return $"Id : {Person.Id}, Name :  {Person.Name}, Surname : {Person.Surname}, Phone number : {Person.Phone.Number}, Email : {Adress.Email}, Home adress : {Adress.Home.Adress}";

        }
    }
}
