using Adress_Book.MyExtension;
using Adress_Book.Operations.IOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adress_Book.Operations
{
    class AdressOperations : IAdressOperations
    {

        private Contact[] contactArr;

        public AdressOperations()
        {
            contactArr = new Contact[0];
        }
        public bool New(Contact contact)
        {
            Array.Resize(ref contactArr, contactArr.Length + 1);
            contactArr[contactArr.Length - 1] = contact;
            return true;

        }
        public bool Delete(string name)
        {
            if (Array.Find(contactArr, c => c.Person.Name == name) != null)
            {
                contactArr = Array.FindAll(contactArr, c => c.Person.Name != name);
                return true;
            }
            else
            {
                Console.WriteLine($"There is no Contact with {name} name!");
                return false;
            }

        }
        public bool Update(int id, Contact contact)
        {
            for (int i = 0; i < contactArr.Length; i++)
            {
                if (contactArr[i].Person.Id == id)
                {
                    contactArr[i]=contact;
                }
            }
                //Contact foundContact = Array.Find(contactArr, c => c.Person.Id == id);
                //foundContact = contact;
                return true;
            
        }

        public string Find(int id)
        {
            //try
            //{
            Contact foundContact = Array.Find(contactArr, c => c.Person.Id == id);
            if (foundContact == null)
            {
                return $"There no Contact with {id} ID!";
            }
            return foundContact.FullInfo();
            //}
            //catch (NullReferenceException e)
            //{

            //    return $"There no Contact with {id} ID!";
            //}

        }

        public Contact[] Read()
        {

            if (contactArr.IsNullOrEmpty<Contact>())
            {
                return null;
            }

            return this.contactArr;
        }
    }
}
