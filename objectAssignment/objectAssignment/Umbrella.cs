using System;
using System.Collections.Generic;
using System.Text;

namespace objectAssignment
{
    class Umbrella
    {
        public string Colour { get; set; }
        public bool isOpenNow = false;

        public  bool isClosed()
        {
            // perform an operation to know if the umbrella is open or closed.
            return isOpenNow;
        }

        public bool isOpen()
        {
            // performs an operation.
            return isOpenNow;
        }
    }
}
