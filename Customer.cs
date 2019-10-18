using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Customer
    {
        public int cust_size = 2;

        int[] cust_id = new int[2];
        string[] cust_names = new string[2];
        int[] account_balance = new int[2];
        bool flag = true;

        public void getDetails()
        {
            for (int i = 0; i < cust_size; i++)
            {
                Console.WriteLine("Enter Customer Number: ");
                cust_id[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Customer Name: ");
                cust_names[i] = Console.ReadLine();
            }
            for (int j = 0; j < cust_size; j++)
            {
                account_balance[j] = 500;
            }
        }

        public void transact()
        {
            int index = 0, option;

            while (flag)
            {
                Console.WriteLine("Enter Customer Number for Transaction");
                int ch_cust_id = int.Parse(Console.ReadLine());
                bool cust_search = false;

                for (int i = 0; i < cust_size; i++)
                {
                    if (cust_id[i] == ch_cust_id)
                    {
                        index = i;
                        cust_search = true;
                        break;
                    }
                }

                if (cust_search == true)
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
                            if (account_balance[index] <= 500)
                            {
                                Console.WriteLine("Cannot withdraw as balance is below 500");
                                flag = false;

                            }
                            else
                            {
                                Console.Write("Enter amount to withdraw: ");
                                int w_amt = int.Parse(Console.ReadLine());
                                account_balance[index] = account_balance[index] - w_amt;
                                Console.WriteLine();
                                Console.WriteLine("Updated Account Balance: " + account_balance[index]);
                            }
                            break;
                        case 2:
                            Console.Write("Enter amount to deposit: ");
                            int d_amt = int.Parse(Console.ReadLine());
                            account_balance[index] = account_balance[index] + d_amt;
                            Console.WriteLine("Updated Account Balance: " + account_balance[index]);

                            break;
                        case 3:
                            int balance = account_balance[index];
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


