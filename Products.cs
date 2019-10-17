using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Of_Products
{
    class Products
    {
        public void Menu()
        { 
            string choice;
            Console.WriteLine("The rates are as follows :");
            Console.WriteLine("1) Side-Table - Rs 2000 ");
            Console.WriteLine("2) Dining-Table - Rs 15000");
            Console.WriteLine("3) Plastic Chairs - Rs 350");
            Console.WriteLine("4) Wooden Chairs - Rs 800");
            Console.WriteLine("5) L-shaped Sofa - Rs 23000 ");
            Console.WriteLine("6) Sofa-cum-Bed - Rs 40000");
            Console.WriteLine("7) Arm-Rest Chairs - Rs 12000 ");
            Console.WriteLine("8) Single Beds - Rs 6000 ");
            Console.WriteLine("9) Queen Size Beds - Rs 16000 ");
            Console.WriteLine("10) King Size Beds - Rs 24000 ");
            Console.WriteLine("11) Double Beds - Rs 11000 ");
            Console.WriteLine("12) Storage Beds - Rs 30000");
            Console.WriteLine("13) Shoe Racks - Rs 1000 ");
            Console.WriteLine("14) Cupboards - Rs 13000");

            Console.WriteLine(" Select the product of your choice:");

            choice = Console.ReadLine();
            selection(choice);
        }

        public void selection (string choice)
        {
            int amount,bill;
            switch(choice)
            {
                case "Side-Table":
                    Console.WriteLine("Number of Products required: ");
                    amount = int.Parse(Console.ReadLine());
                    bill= amount * 2000;
                    Console.WriteLine("The bill is: " + bill);
                    break;

                case "Dining-Table ":
                    Console.WriteLine("Number of Products required: ");
                    amount = int.Parse(Console.ReadLine());
                    bill = amount * 15000;
                    Console.WriteLine("The bill is: " + bill);
                    break;

                case "Plastic Chairs":
                    Console.WriteLine("Number of Products required: ");
                    amount = int.Parse(Console.ReadLine());
                    bill = amount * 350;
                    Console.WriteLine("The bill is: " + bill);
                    break;

                case "Wooden Chairs":
                    Console.WriteLine("Number of Products required: ");
                    amount = int.Parse(Console.ReadLine());
                    bill = amount * 800;
                    Console.WriteLine("The bill is: " + bill);
                    break;

                case "L-shaped Sofa":
                    Console.WriteLine("Number of Products required: ");
                    amount = int.Parse(Console.ReadLine());
                    bill = amount * 23000;
                    Console.WriteLine("The bill is: " + bill);
                    break;

                case "Sofa-cum-Bed":
                    Console.WriteLine("Number of Products required: ");
                    amount = int.Parse(Console.ReadLine());
                    bill = amount * 40000;
                    Console.WriteLine("The bill is: " + bill);
                    break;

                case "Arm-Rest Chairs":
                    Console.WriteLine("Number of Products required: ");
                    amount = int.Parse(Console.ReadLine());
                    bill = amount * 12000;
                    Console.WriteLine("The bill is: " + bill);
                    break;

                case "Single Beds":
                    Console.WriteLine("Number of Products required: ");
                    amount = int.Parse(Console.ReadLine());
                    bill = amount * 6000;
                    Console.WriteLine("The bill is: " + bill);
                    break;

                case "Queen Size Beds":
                    Console.WriteLine("Number of Products required: ");
                    amount = int.Parse(Console.ReadLine());
                    bill = amount * 16000;
                    Console.WriteLine("The bill is: " + bill);
                    break;

                case "King Size Beds":
                    Console.WriteLine("Number of Products required: ");
                    amount = int.Parse(Console.ReadLine());
                    bill = amount * 24000;
                    Console.WriteLine("The bill is: " + bill);
                    break;

                case "Double Beds":
                    Console.WriteLine("Number of Products required: ");
                    amount = int.Parse(Console.ReadLine());
                    bill = amount * 11000;
                    Console.WriteLine("The bill is: " + bill);
                    break;

                case "Storage Beds":
                    Console.WriteLine("Number of Products required: ");
                    amount = int.Parse(Console.ReadLine());
                    bill = amount * 30000;
                    Console.WriteLine("The bill is: " + bill);
                    break;

                case "Shoe Racks":
                    Console.WriteLine("Number of Products required: ");
                    amount = int.Parse(Console.ReadLine());
                    bill = amount * 1000;
                    Console.WriteLine("The bill is: " + bill);
                    break;

                case "Cupboards":
                    Console.WriteLine("Number of Products required: ");
                    amount = int.Parse(Console.ReadLine());
                    bill = amount * 13000;
                    Console.WriteLine("The bill is: " + bill);
                    break;

                default:
                    Console.WriteLine("Invalid or incorrect Product");
                    break;


            }

        }

        
    }
}
