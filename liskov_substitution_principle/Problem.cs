using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    public class Vehical
    {
        public int GetNumberOfWheels() { return 2; }
        public bool HasEngine() { return true; }
    }
    //this will work as expected as Bike has engine and number of wheels 
    public class Car:Vehical {
        public int GetNumberOfWheels() {
            return 4;
        }
        public bool HasEngine() { return true; }
    }

    //this will break as BikeCycle does not have engine
    //We will not able replace object of class Bicyle with Vehical
    public class  Bicycle:Vehical
    {
        public int GetNumberOfWheels() {
            return 2;
        }
        public bool HasEngine() { throw new InvalidOperationException("Bicycle does not has engine"); }
    }
}
