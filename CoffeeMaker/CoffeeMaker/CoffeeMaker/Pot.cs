using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class Pot : IPot
    {
        public string IsPotRemoved()
        {
            Console.WriteLine("Is the pot removed?");
            Console.WriteLine("---->yes/no");
            string answer =Console.ReadLine();
            answer = answer.ToLower();
            switch (answer)
            {
                case "yes":
                    Console.WriteLine("It stops bcs the pot is removed");
                    Environment.Exit(0);
                    break;
                case "no":
                    Console.WriteLine("You can continue");
                    break;
                
            }

            return answer;
        }
    }
    
}
