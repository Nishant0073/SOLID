using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soltion
{
    //Solution to this problem is use more class and normilize function in those base class
    public class Vehical
    {
        public int GetNummberOfWheels() { return 0; }
    }
    public class EngineVehical : Vehical { 
        public bool HasEngine()
        {
            return true;
        }
    }
    public class WithoutEngineVehical : Vehical { };

    //This follows LSP
    public class Car: EngineVehical
    {
        public int GetNummberOfWheels() { return 4; }
        public bool HasEngine()
        {
            return true;
        }
        public int NumberOfGears() { return 4; } 
    }
    //This is following LSP as we can replace object of Bicyle with the WithoutEngineVehical 
    public class Bicycle: WithoutEngineVehical { 
        public int GetNummberOfWheels() { return 4; }
    }
}
