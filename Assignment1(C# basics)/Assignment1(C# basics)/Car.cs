
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C__basics_
{
     public abstract class Car: IVehicle
    {
        // Characteristics common to all vehicles
        public string Model { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }

        // Abstract method forces derived classes to implement 
        public abstract void StartEngine();

        // Virtual method allows derived classes to override
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Make: " + Make);
            Console.WriteLine("Color: " + Color);
        }
        // Call interface method
        public void TestDrive(int miles)
        {
            Console.WriteLine("Test drived it for"+miles+"miles");
        }
    }


}

