using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpMasterclass
{
    // this class is a blueprint for a datatype
    // create a public variable lastName of type string
    // change the Introduce method so it tells the whole name
    // create two objects with full information about themself - firstName and lastName
    class Human
    {
        // member variable
        public string firstName;
        public string lastName;

        // member method
        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {firstName} {lastName}");
        }
    }
}
