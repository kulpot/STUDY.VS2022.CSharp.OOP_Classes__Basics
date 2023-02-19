// https://www.youtube.com/watch?v=q_F4PyW8GTg&t=12376s


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *                  OBJECT ORIENTED PROGRAMMING
 *                  
 *                  Class
 *                  
 *    A class is a blue print of an Object
 *    It has actions/abilities - so called member functions or methods
 *    and it has properties - so called member variables
 *    Inheritance possible
 *    Can be used like a Datatype(e.g. String is a Class)
 *  
 *                  Object
 *    Example: Audi Car
 *    
 *    Properties: HP, Amount of Wheels, Lumen, Doors
 *    Abilities: Drive, Break, Open Window, Make Light
 *    Inheritance: e.g. A5 < Audi < Car
 *    
 */

namespace OOP_Classes__Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Create an object of my class
            // an instance of Human
            Human denis = new Human();
            // access public variable from outside, and even change it
            //denis.firstName = "Denis";
            // call methods of the class
            denis.IntroduceMyself();

            Human michael = new Human();
            //michael.firstName = "Mikel";
            michael.IntroduceMyself();

            Console.ReadKey();
            */
            /*
            Human sissy = new Human();
            sissy.firstName = "Sissy";
            sissy.lastName = "Wagner";
            sissy.IntroduceMyself();

            Human franzl = new Human();
            franzl.firstName = "Franzl";
            franzl.lastName = "Muller";
            franzl.IntroduceMyself();

            Console.ReadKey();
            */

            // Constructor
            //Human sissy = new Human("Sissy", "Wagner");
            //sissy.IntroduceMyself();
            Human denis = new Human("Denis", "Panjuta", "green", 29);
            denis.IntroduceMyself();

            //Human amalia = new Human("Amalia", "Panjuta", "blue", 1);
            Human amalia = new Human("Amalia", "Panjuta", "blue");
            amalia.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMyself();

            Human michael = new Human("Michael", "Miller");
            michael.IntroduceMyself();

            Human frank = new Human("Frank", "Walter", 25);
            frank.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
