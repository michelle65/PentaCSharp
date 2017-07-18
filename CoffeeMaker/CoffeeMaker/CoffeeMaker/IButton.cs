using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    interface IButton
    {
        //if it is on or off
         string HaveYouPressedTheButton();
        string coffeeIsReady();

    }
}
