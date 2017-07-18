using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Tank t = new Tank();
            t.IsThereAnyWater();
            t.AreThereMoreThan12Cups();

            Button b = new Button();
            b.HaveYouPressedTheButton();

            Pot p = new Pot();
            p.IsPotRemoved();

            FilterHolder f = new FilterHolder();
            f.IsThereAnyFilterHolder();

            Console.WriteLine("Let's wait until your coffee is ready");

            System.Threading.Thread.Sleep(3500);
            Console.WriteLine("*******************");
            Console.WriteLine(b.coffeeIsReady());
            Console.WriteLine("*******************");

            System.Threading.Thread.Sleep(1000);

           //ReliefValve r = new ReliefValve();
           //r.ReliefValveState("opened");

           // System.Threading.Thread.Sleep(1000);

           // r.ReliefValveState("closed");

            Console.ReadKey();
    }
    }
}
