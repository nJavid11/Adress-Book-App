using System;
using System.Collections.Generic;
using System.Text;

namespace Adress_Book.Operations.IOperations
{
    interface IAdressOperations
    {
        public bool New(Contact contact);
        public bool Delete(string name);
        public bool Update(int id, Contact contact);
        public string Find(int id);
        public Contact[] Read();

    }
}
