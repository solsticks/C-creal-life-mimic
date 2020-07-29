using System;
using System.Collections.Generic;
using System.Text;

namespace objectAssignment
{
    class Computer
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public string ScreenSize { get; set; }

        public void Boot()
        {
            // performs operations to boot
        }

        public void ShutDown()
        {
            // performs operations to shut down
        }


        public Computer(string type, string model, string colour, string screenSize)
        {
            this.Type = type;
            this.Model = model;
            this.Colour = colour;
            this.ScreenSize = screenSize;
        }
    }
}
