using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpMasterclass
{
    // Lesson 06 - 00P


    // this class is a blueprint for a datatype
    // create a public variable lastName of type string
    // change the Introduce method so it tells the whole name
    // create two objects with full information about themself - firstName and lastName

    class Human
    {
        // member variable
        public string firstName;
        public string lastName;
        public int age;
        public string eyeColor;

        // default constructor
        public Human()
        {

        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, int age)
        {
            this.firstName = firstName;
            this.age = age;
        }

        public Human(string firstName, int age, string eyeColor)
        {
            this.firstName = firstName;
            this.age = age;
            this.eyeColor = eyeColor;
        }

        // constructor no age
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        // another constructor with parameters
        public Human(string first, string lastName, int age, string eyeColor)
        {
            // can either change parameter to adjust lower-level variable
            firstName = first;

            // or use `this` keyword
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor.ToLower();
        }

        // member method
        public void Introduce()
        {
            // LMAO
            Console.WriteLine(
                $"Hello!{(firstName != null || lastName != null ? $" My name is {firstName}{(lastName != null ? " " : "")}{lastName}." : "")}{(age > 0 ? $" I am {age} year{(age == 1 ? "" : "s")} old." : "")}{(eyeColor != null ? $" My eyes are {eyeColor}." : "")}"
                );
        }
    }
}
