using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressPrompt
    {
        AddressBook book;

        public AddressPrompt()
        {
            book = new AddressBook();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!");
            string selection = "";
            AddressPrompt prompt = new AddressPrompt();

            while (!selection.ToUpper().Equals("Q"))
            {
                prompt.displayMenu();
                Console.WriteLine("\nSelect from above options:");
                selection = Console.ReadLine();
                prompt.performAction(selection);
            }
        }
        void displayMenu()
        {
            Console.WriteLine("\nADDRESS BOOK");
            Console.WriteLine("=========");
            Console.WriteLine("A - Add a Contact Details");
            Console.WriteLine("Q - Quit");
        }
        void performAction(string selection)
        {
            string firstName = "";
            string lastName = "";
            string address = "";
            string city = "";
            string state = "";
            int zip;
            int phone;
            string email = "";

            switch (selection.ToUpper())
            {
                case "A":
                    Console.WriteLine("To add a Contact");
                    Console.WriteLine("Enter First Name:");
                    firstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name:");
                    lastName = Console.ReadLine();
                    Console.WriteLine("Enter Address:");
                    address = Console.ReadLine();
                    Console.WriteLine("Enter City:");
                    city = Console.ReadLine();
                    Console.WriteLine("Enter State:");
                    state = Console.ReadLine();
                    Console.WriteLine("Enter Zip Code");
                    zip = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Phone Number:");
                    phone = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Email:");
                    email = Console.ReadLine();

                    if (book.add(firstName, lastName, address, city, state, zip, phone, email))
                    {
                        Console.WriteLine("Contact successfully added!");
                    }
                    else
                    {
                        Console.WriteLine("An address is already on file for {0}", firstName);
                    }
                    break;
            }
        }
    }
}
