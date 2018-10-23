using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankuppgift
{
    class Program

    {
        static void Main(string[] args)
        {
            List<Customer> list = new List<Customer>();
            Console.WriteLine("Welcome to the bank of souls!");
            ShowMenu();
            int choise = 0;
            while (choise != 7)
            {
                Console.WriteLine ("make your choice mortal: ");
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                  
                    try
                    (
                    Console.WriteLine ("make a choice mortal.")
                    int tal = int.Parse(Console.ReadLine())
                    
                    )
                    catch (Exeption e) {}                                 

                {
                    case 1:
                        Customer C1 = new Customer();
                        Console.Write("Tell me your name: ");
                        C1.name = Console.ReadLine();
                        list.Add(C1);
                        break;

                    case 2:
                        Console.Clear();
                        ShowAllCustomer(list);
                        int delet = 1;
                        delet = Convert.ToInt32(Console.ReadLine());
                        list.RemoveAt(delet);
                       
                        Console.Clear();
                        break;
                   



                    case 3;
                        foreach (Customer info in list)
                        {
                            info.showCustomer();
                        }

                        break;
                    case 4;
                        Console.WriteLine("The balance of this servant is ");
                        break;
                    default:
                        Console.WriteLine("Default case ");
                        break;

                }
            }




        }
        static void ShowMenu()
        {
            Console.WriteLine("What brings you hear today?");
            Console.WriteLine("1. Add a new servant to my bank");
            Console.WriteLine("2. Who are you removing from my service?");
            Console.WriteLine("3. Show my servants");
            Console.WriteLine("4. Show one of my servants balance");
            Console.WriteLine("5. Make a deposit for one of my servants");
            Console.WriteLine("6. Make a withdraw for one of my servants");
            Console.WriteLine("7. You are bound to never leave this bank, try and you shall fail");

        }
        private static void ShowAllCustomer(List<Customer> list)
        {
            foreach (var customer in list)
            {
                customer.showCustomer();
            }
        }
    }
}
