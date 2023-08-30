using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C__basics_
{
    //Class SportsCar inherits from Car 
    public class SportsCar : Car
    {
        //Additional characteristic specific to cars

        public int NumberofDoors { get; set; }
        public int NumberofSeats { get; set; }

       // Override abstract method from base class

        public override void StartEngine()
        {
            Console.WriteLine("Engine started!");
        }
        // Override virtual method from base class
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Number of doors: " + NumberofDoors);
        }
        //Overload TestDrive method
        public new void TestDrive(int miles)
        {
            Console.WriteLine("Test drived it for "+ miles +" miles.");
        }


    }
}
