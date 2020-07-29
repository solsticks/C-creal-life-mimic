using System;
using System.Collections.Generic;
using System.Text;

namespace objectAssignment
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Complexion { get; set; }

        public void Eat()
        {
            //Do something
        }

        public void Walk()
        {
            //Do something
        }

        public void Talk()
        {
            //Do something
        }

        public Person(string name, string gender, int age, string complexion )
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Complexion = complexion;
        }
    }
}
