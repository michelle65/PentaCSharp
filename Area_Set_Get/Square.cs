using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainApp1
{
    class Square : Shape
    {
       // private double _Area;

        private double _sideSquare;

       // private double _Side;
        private double _Area;

        public Square()
        { }

        public Square(double sideSquare)
        {
            this._sideSquare = sideSquare;
           
        }

        public override double Area
        {
            get
            { return _Area = (_sideSquare * _sideSquare); }

            set
            { _sideSquare = value; }
           // _sideSquare = Math.Sqrt(_Area) ;
        }
        
        public override double Side
        {
            get
            { return _sideSquare = Math.Sqrt(_Area ); }
            set{ _Area = value; }
        }
        

    }

        
}
