using System;
using System.Collections.Generic;
using System.Text;

namespace objectAssignment
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Complexion { get; set; }

        public Human(string name = "", string gender = "", string complexion = "", int age = 4)
        {
            this.Name = name;
            this.Gender = gender;
            this.Complexion = Complexion;
            this.Age = age;
        }
    }
}
