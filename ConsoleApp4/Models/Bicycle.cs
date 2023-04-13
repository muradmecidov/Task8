using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal class Bicycle:Vehicle
    {
        public string Type;

        public override void DefineNatureHarmness()
        {
            Console.WriteLine("Ziyanı yoxdur");
        }




    }
}
