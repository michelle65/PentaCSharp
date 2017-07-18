using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value of the Side: ");
            Double side = Double.Parse(Console.ReadLine());

            Cube cub1 = new Cube(side);
           // Double b = Double.Parse(Console.ReadLine());
            Square sq1 = new Square(side);

            Console.WriteLine("Area of the cube" +cub1.Area);
            Console.WriteLine("Area of the square" +sq1.Area);

            Console.WriteLine("==================================");

            Console.WriteLine("Value of the Area: ");
            Double area = Double.Parse(Console.ReadLine());

            Cube cub2 = new Cube();
            cub2.Side =area;
            Console.WriteLine("Side of the cube "+cub2.Side);

            Square sq2 = new Square();
           sq2.Side = area;
            Console.WriteLine("Side of the square " + sq2.Side);
            Console.ReadKey();

        }
    }
}
