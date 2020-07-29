using System;
using System.Collections.Generic;
using System.Text;

namespace objectAssignment
{
    class House
    {
        public string Type { get; set; }
        public string Colour { get; set; }
        public int NumOfRooms { get; set; }
        public int NumOfLivingRooms { get; set; }

        public House(string type, string colour, int numOfRooms, int numOfLivingRooms)
        {
            this.Type = type;
            this.Colour = colour;
            this.NumOfRooms = numOfRooms;
            this.NumOfLivingRooms = numOfLivingRooms;
        }
    }
}
