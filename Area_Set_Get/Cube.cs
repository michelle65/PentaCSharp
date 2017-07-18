using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainApp1
{
    class Cube : Shape
    {
      
        private double _sideCube;
        private double _Area;
        private double _Side;

        public Cube()
        {
           
        }

        public Cube(double sideCube)
        {
            this._sideCube = sideCube;
            //pe contructor se trimite dimensiunea unei laturi
        }
        
       
        public override double Area
        {
            get
            { return _Area = (6*(_sideCube * _sideCube)); }

            set { _sideCube = value; }
        }
        public override double Side {
            get { return  _sideCube = Math.Sqrt(_Area / 6);}

            set { _Area = value; }
        }
    }
        
    }
