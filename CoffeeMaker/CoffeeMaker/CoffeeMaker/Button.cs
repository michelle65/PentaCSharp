using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    class Button : IButton
    {
        public string coffeeIsReady()
        {
            return "Your coffee is ready\n Have a nice day!";
        }

        public string HaveYouPressedTheButton()
        {
            Console.WriteLine("Have you pressed the button?");
            Console.WriteLine("---->yes/no");
            string ok = Console.ReadLine();
            ok = ok.ToLower();
            switch (ok)
            {
                case "yes":
                    Console.WriteLine("You can continue");
                    break;
                case "no":
                    Console.WriteLine("You have to press the button first");
                    Environment.Exit(0);
                    break;
                
            }

            return ok;
        }
    }
}
