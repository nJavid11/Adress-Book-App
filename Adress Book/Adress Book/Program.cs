using Adress_Book.Operations;
using System;
using System.Threading;

namespace Adress_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Adress Book!\n");
            AdressOperations adressOp = new AdressOperations();

            byte choise = 100;
            do
            {
                Console.WriteLine("*** OPERATIONS ***");
                Console.WriteLine("1. New Contact\n" +
                                  "2. Delete Contact\n" +
                                  "3. Update Contact\n" +
                                  "4. Find Contact\n" +
                                  "5. List of All Contacts\n" +
                                  "0. Exit");
                Console.Write("Choose an operation : ");
                choise = byte.Parse(Console.ReadLine());
                Console.WriteLine();

                if (choise >= 0 && choise < 6)
                {
                    switch (choise)
                    {

                        case 1:
                            Console.WriteLine("*** NEW CONTACT ***");
                            Console.WriteLine("You have to enter the contact details");
                            Contact contact = GetDetails();

                            if (adressOp.New(contact))
                                Console.WriteLine($"Contact with {contact.Person.Id} ID have been added succesfully!\n");
                            else
                                Console.WriteLine("Adding operation have been unsuccessful, try again!\n");
                            break;
                        case 2:
                            Console.WriteLine("*** DELETE CONTACT ***");
                            if (adressOp.Read() == null)
                            {
                                Console.WriteLine("There is no contact in the list to delete!");
                                Console.WriteLine("Add some using \"1\" operation!\n");
                                break;
                            }
                            Console.WriteLine("You have to enter the person name");
                            Console.Write("Name : ");
                            string nameDel = Console.ReadLine();
                            if (adressOp.Delete(nameDel))
                                Console.WriteLine($"Contact with the Person Name of {nameDel} have been deleted succesfully!\n");
                            else
                                Console.WriteLine("Deleting operation have been unsuccessful, try again!\n");
                            break;
                        case 3:
                            Console.WriteLine("*** UPDATE THE CONTACT ***");
                            if (adressOp.Read() == null)
                            {
                                Console.WriteLine("There is no contact in the list to update!");
                                Console.WriteLine("Add some using \"1\" operation!\n");
                                break;
                            }
                            Console.Write("ID for updating : ");
                            int idUp = Convert.ToInt32(Console.ReadLine());
                            foreach (var item in adressOp.Read())
                            {
                                if (item.Person.Id == idUp)
                                {
                                    Console.WriteLine("You have to enter the contact details");
                                    Contact contactUpdate = GetDetails();

                                    if (adressOp.Update(idUp, contactUpdate))
                                        Console.WriteLine($"Contact with {idUp} ID have been updated succesfully!\n");
                                    else
                                        Console.WriteLine("Updating operation have been unsuccessful, try again!\n");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"There no Contact with {idUp} ID!\n");
                                }
                            }
                            break;
                        case 4:
                            Console.WriteLine("*** FIND THE CONTACT ***");
                            if (adressOp.Read() == null)
                            {
                                Console.WriteLine("There is no contact in the list to find!");
                                Console.WriteLine("Add some using \"1\" operation!\n");
                                break;
                            }
                            Console.Write("Please, enter the ID : ");
                            int id = int.Parse(Console.ReadLine());
                            string fullInfo = adressOp.Find(id);
                            Console.WriteLine(fullInfo + "\n");
                            break;
                        case 5:
                            //try
                            //{
                            Console.WriteLine("*** LIST OF All CONTACTS ***");
                            if (adressOp.Read() == null)
                            {
                                Console.WriteLine("There is no contact in the list");
                                Console.WriteLine("Add some using \"1\" operation!\n");
                                break;
                            }
                            foreach (var item in adressOp.Read())
                            {
                                Console.WriteLine(item.FullInfo());
                            }
                            //}
                            //catch (Exception)
                            //{

                            //Console.WriteLine("There is no contact in the list!");
                            //Console.WriteLine("Add some using \"1\" operation!\n");
                            //}
                            break;
                        case 0:
                            Console.WriteLine("Application will be closed in 3 seconds!");
                            Console.WriteLine("3");
                            Thread.Sleep(1000);
                            Console.WriteLine("2");
                            Thread.Sleep(1000);
                            Console.WriteLine("1");
                            Thread.Sleep(1000);
                            Console.WriteLine("Closed");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Such an operation does not exist.");
                    Console.WriteLine("Enter a valid operation!");
                    choise = 100;
                }
            } while (choise != 0);


        }
        private static Contact GetDetails()
        {
            Console.Write("Name : ");
            string name = Console.ReadLine();

            Console.Write("Surname : ");
            string surname = Console.ReadLine();

            Console.Write("Phone number : ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Id : ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Email : ");
            string email = Console.ReadLine();

            Console.Write("home adress : ");
            string homeAdress = Console.ReadLine();

            Contact contact = new Contact(new Moduls.Person(id, name, surname, new Moduls.Phone(phoneNumber)), new Moduls.Adress(email, new Moduls.Home(homeAdress)));

            return contact;
        }
    }
}