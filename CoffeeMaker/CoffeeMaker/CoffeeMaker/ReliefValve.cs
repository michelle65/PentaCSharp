//using CoffeeMaker.CoffeeMaker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class ReliefValve :IReliefValve
    {

       public  void ReliefValveState(string answer)
        {
            //The relief valve can be opened() or closed()

            switch (answer)
            {
                case "opened":
                    Console.WriteLine("The ReliefValve is opened");
                    break;
                case "closed":
                    Console.WriteLine("The ReliefValve is closed");
                    
                    break;
            }

           
        }
    }
}
