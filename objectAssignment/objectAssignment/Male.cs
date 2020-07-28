using System;
using System.Collections.Generic;
using System.Text;

namespace objectAssignment
{
    class Male : Human
    {
        public string BeardsColour { get; set; }


        public Male(string beardsColour)
        {
            this.BeardsColour = beardsColour;
        }
    }
}
