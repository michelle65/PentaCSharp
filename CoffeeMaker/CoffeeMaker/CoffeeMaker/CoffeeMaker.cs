using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    class CoffeeMaker
    {
        public CoffeeMaker()
        {

        }
       
        public IFilterHolder FilterHolder { get; set; }
        public IFilterHolder Filter { get; set; }
       
        public ITank Tank { get; set; }
        public IButton Button { get; set; }



    }
}
