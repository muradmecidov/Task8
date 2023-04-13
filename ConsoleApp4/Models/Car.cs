using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal class Car:Vehicle
    {
        public int DoorCount;
        public bool IsElctricCar;

        public override void DefineNatureHarmness()
        {
            if (IsElctricCar) { Console.WriteLine("Ziyanı azdır"); }
            else { Console.WriteLine("ziyanı çoxdur"); }
            
        }

    }
}
