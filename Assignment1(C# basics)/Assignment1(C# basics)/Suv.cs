using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C__basics_
{
    //Class Suv inherits from Car
    internal class Suv : Car
    {
        //Additional characteristic specific to cars
        public int NumberofDoors { get; set; }
        public int NumberofSeats { get; set; }

        public override void StartEngine()
        {
            Console.WriteLine("Engine started!");
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Number of doors: " + NumberofDoors);
        }
    }
}
