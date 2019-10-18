using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Customer
    {
        public int customer_size = 10;

        int[] customer_id = new int[10];
        string[] customer_names = new string[10];
        int[] acc_balance = new int[10];
        bool flag = true;

        public void getDetails()
        {
            for (int i = 0; i < customer_size; i++)
            {
                Console.WriteLine("Enter Customer Number: ");
                customer_id[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Customer Name: ");
                customer_names[i] = Console.ReadLine();
            }
            for (int j = 0; j < customer_size; j++)
            {
                acc_balance[j] = 500;
            }
        }

        public void transact()
        {
            int index = 0, option;

            while (flag)
            {
                Console.WriteLine("Enter Customer Number for Transaction");
                int ch_customer_id = int.Parse(Console.ReadLine());
                bool customer_search = false;

                for (int i = 0; i < customer_size; i++)
                {
                    if (customer_id[i] == ch_customer_id)
                    {
                        index = i;
                        customer_search = true;
                        break;
                    }
                }

                if (customer_search == true)
                {
                    Console.WriteLine("Customer ID FOUND");
                    Console.WriteLine("Choose One Option:");
                    Console.WriteLine("1. Withdrawl");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Account Balance");
                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            if (acc_balance[index] <= 500)
                            {
                                Console.WriteLine("Cannot withdraw as balance is below 500");
                                flag = false;

                            }
                            else
                            {
                                Console.Write("Enter amount to withdraw: ");
                                int w_amt = int.Parse(Console.ReadLine());
                                acc_balance[index] = acc_balance[index] - w_amt;
                                Console.WriteLine();
                                Console.WriteLine("Updated Account Balance: " + acc_balance[index]);
                            }
                            break;
                        case 2:
                            Console.Write("Enter amount to deposit: ");
                            int d_amt = int.Parse(Console.ReadLine());
                            acc_balance[index] = acc_balance[index] + d_amt;
                            Console.WriteLine("Updated Account Balance: " + acc_balance[index]);

                            break;
                        case 3:
                            int balance = acc_balance[index];
                            Console.WriteLine("Account Balance: " + balance);
                            break;

                        default:
                            Console.WriteLine("Invalid Input");
                            flag = false;
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Customer ID NOT FOUND");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.getDetails();
            customer.transact();
            Console.ReadLine();
        }
    }
}


