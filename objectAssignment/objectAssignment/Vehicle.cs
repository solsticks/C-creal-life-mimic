using System;
using System.Collections.Generic;
using System.Text;

namespace objectAssignment
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public int NumOfTires { get; set; }
        public string Colour { get; set; }

        public void Start()
        {
            //this starts the start
        }

        public void Move()
        {
            // this moves the car
        }

        public void Accelerate()
        {
            // this increases the speed of the car
        }

        public void TurnOff()
        {
            // this turns of the vehicle.
        }
    }
}
