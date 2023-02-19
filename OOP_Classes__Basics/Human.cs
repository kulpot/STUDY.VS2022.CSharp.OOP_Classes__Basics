using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Classes__Basics
{   

    // create a public variable lastName of type string.
    // change the IntroduceMyself method, so it tells the whole name.
    // create two objects with full information about themself - firstName and lastName

    // Constructor Challenge
    // add two more member variables to "Human". eyeColor and age.
    // adjust the constructor, so it requires all of the four values to be used, when creating an object of Human.
    // create two objects of type Human.

    // this class is a blueprint for a datatype
    internal class Human
    {
        //Member Variable
        //string firstName; // this line is not public so its protected and cant be access outside from this class.
        //public string firstName = "Michael"; // every single human create will be named Michael except if given a name inside the PROGRAM.CS (e.g.michael.firstName = "Mikel";)
        //private string firstName = "Michael"; // inaccessible variable "firstName" because the access modifier is private
        //public string firstName;
        //public string lastName;
        private string firstName; // constructor this.firstName
        private string lastName;  // constructor this.lastName
        private string eyeColor;
        private int age;

        ////        MULTIPLE CONSTRUCTOR
        ///// multiple constructor is for programs with database with missing parameters like "age"


        // default constructor parameter
        public Human()
        {
            Console.WriteLine("Constructor called. Object created" );
        }

        // no lastName, eyeColor, age parameter constructor
        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        // no eyeColor, age parameter constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //  no age parameter constructor
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        // no eyeColor parameter constructor
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }


        //              CONSTRUCTOR
        // PARAMETERIZED CONSTRUCTOR
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }



        // member method
        public void IntroduceMyself()
        {
            /*
            if(age == 1)
                Console.WriteLine("Hi, I'm {0} {1} and I'm {2} year old. My eyecolor is {3}", firstName, lastName, age, eyeColor);
            else
                Console.WriteLine("Hi, I'm {0} {1} and I'm {2} years old. My eyecolor is {3}", firstName, lastName, age, eyeColor);
            */

            /////for programs with database with missing parameters like "age"
            if (age != 0 && lastName != null && eyeColor != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1} and I'm {2} year old. My eyecolor is {3}", firstName, lastName, age, eyeColor);
            else if (age != 0 && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1} and I'm {2} year old.", firstName, lastName, age);
            }
            else if (eyeColor != null && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}. My eyecolor is {2}", firstName, lastName, eyeColor);
            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} ", firstName);
            }
        }
    }
}
