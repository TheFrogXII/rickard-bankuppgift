using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bankuppgift
{
    class Program
    {
        static List<customer> customerList = new List<customer>();

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the bank of souls!"); //writes out choises for the bank
            Console.WriteLine("");
            Console.WriteLine("wish one of these options would you like to?");
            Console.WriteLine("");
            Console.WriteLine("1. Add a servant to my bank");
            Console.WriteLine("2. Remove one of my servants");
            Console.WriteLine("3. Show all my servants");
            Console.WriteLine("4. Show the currenct for my servants");
            Console.WriteLine("5. Make a Deposit for one of my servants");
            Console.WriteLine("6. Make a withdraw for one of my servants");
            Console.WriteLine("7. Avsluta programmet");
            Console.WriteLine("");
            Console.WriteLine("write the number you would like: ");

            int val = 0;

            try
            {
                val = int.Parse(Console.ReadLine());
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            while (val != 7)
            {
                switch (val)
                {
                    case 1:
                        AddCustomer(); //adds a user
                        break;
                    case 2:
                        RemoveCustomer(); //removes a user
                        break;
                    case 3:
                        foreach (customer info in customerList)
                        {
                            Console.WriteLine(info.CustomerInfo()); //shows all users
                            string.mydoc
                        
                        }

                        break;
                    case 4:
                        Console.WriteLine("Case 4");
                        break;
                    case 5:
                        Console.WriteLine("Case 5");
                        break;
                    case 6:
                        Console.WriteLine("Case 6");
                        break;
                    case 7:
                        Console.WriteLine("Case 7");
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }
                Console.WriteLine("write the number you would like: "); //takes in youre your choosen number
                val = int.Parse(Console.ReadLine());

            }

        }

        public static void AddCustomer() //adds a customer in the list
        {
            Console.WriteLine("write the name of the customer: ");
            string newCustomer = Console.ReadLine();
            customer customer = new customer();
            customer.Namn = newCustomer;
            customerList.Add(customer);

        }

        public static void RemoveCustomer() //removes a customer from the list
        {
            Console.WriteLine("write the name of the customer: ");
            string customertodelete = Console.ReadLine();
            customer objecttodelete = null;
            foreach (customer info in customerList)
            {
                if (info.Namn == customertodelete)
                    objecttodelete = info;
                Console.WriteLine(info.CustomerInfo());

            }
            customerList.Remove(objecttodelete);
        }
        public static void ShowCustomerBalance() //shows how much money the customer have
        {
            Console.WriteLine("write the name of the customer: ");
            string customertodelete = Console.ReadLine();
            customer objecttodelete = null;
            foreach (customer info in customerList)
            {
                if (info.Namn == customertodelete)
                    objecttodelete = info;
                Console.WriteLine(info.CustomerInfo());

            }
            customerList.Remove(objecttodelete);
        }

    }
}

