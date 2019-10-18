using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Shapes
    {
        int basel, height, side,ch;
        double radius;

        public void Input()
        {
            Console.WriteLine("Select the shape to find area: ");
            Console.WriteLine("1-Triangle, 2-Circle, 3-Square");
            ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Give dimensions of triangle ");
                    height = int.Parse( Console.ReadLine());
                    basel = int.Parse(Console.ReadLine());
                    area(height, basel);
                    break;
                case 2:
                    Console.WriteLine("Give dimensions of circle ");
                    radius = double.Parse(Console.ReadLine());
                    area(radius);
                    break;
                case 3:
                    Console.WriteLine("Give dimensions of Square ");
                    side = int.Parse(Console.ReadLine());
                    area(side);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;


            }
        }

        public void area( int heightl, int basel)
        {
            double area;
            area = 0.5 * heightl * basel;
            Console.WriteLine("area = " + area);
             
        }

        public void area (int side)
        {
            int area;
            area = side* side;
            Console.WriteLine("area= " + area);
        }

        public void area (double radius)
        {
            double area;
            area = Math.PI * radius * radius;
            Console.WriteLine("area= " + area);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shapes shape = new Shapes();
            shape.Input();
        }
    }
}
