using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    class FilterHolder :IFilterHolder
    {

        public string IsThereAnyFilterHolder()
        {
            Console.WriteLine("Is there any Filter holder?");
            Console.WriteLine("---->yes/no");
            string answer = Console.ReadLine();
            answer = answer.ToLower();
            //string answer = "";
            switch (answer)
            {
                case "yes":
                    Console.WriteLine("You can continue");
                    break;
                case "no":
                    Console.WriteLine("You have to put the filterholder in order to continue");
                    Environment.Exit(0);
                    break;
            }

            return answer;
        }

       
    }
}
