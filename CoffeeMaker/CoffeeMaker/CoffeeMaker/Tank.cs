using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    class Tank : ITank
    {
        public string AreThereMoreThan12Cups()
        {
            Console.WriteLine("Area there more than 12 cups of coffee");
            Console.WriteLine("---->yes/no");
           string  answer = Console.ReadLine();
            answer = answer.ToLower();
            switch (answer)
            {
                
                case "yes":
                    Console.WriteLine("You cannot continue.You have more than 12 cups");
                    Environment.Exit(0);
                    break;
                case "no":
                    Console.WriteLine("You can continue");
                    break;
            }

            return answer;
        }

        public string IsThereAnyWater( )
        {
            Console.WriteLine("Is there any water in the tank? ");
            Console.WriteLine("---->yes/no");
            string answer = Console.ReadLine();
             answer = answer.ToLower();
            //string answer = "";
            switch (answer)
            {
                case "yes":
                    Console.WriteLine("We have water in the tank. ");
                    break;
                case "no":
                    Console.WriteLine("You cannot continue");
                    Environment.Exit(0);
                    break;
            }

            return answer;
        }
    }
}
