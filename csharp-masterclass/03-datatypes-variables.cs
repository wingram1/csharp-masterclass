using System;

namespace cSharpNotes
{
    internal class dataTypesAndVariables
    {
        // Entry point of our program
        static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float

            float parsedFloat = float.Parse(stringForFloat);
            Console.WriteLine(parsedFloat);


            string stringForInt = "12345"; // datatype should be int

            int parsedInt = Int32.Parse(stringForInt);
            Console.WriteLine(parsedInt);





            /////////STRING MANIPULATION/////////
            int age = 26;
            string name = "William";
            string job = "Developer";

            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello, my name is " + name + ". I am " + age + " years old.");
            Console.WriteLine("Muahaha \n you have yes powers here :(");

            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}. I am a {1}-year-old {2}.", name, age, job);

            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}. I am a {age}-year-old {job}.");

            // verbatim string stores any extra characters in a string
            // good for file paths since \n means line break normally
            Console.WriteLine("Verbatim String");
            Console.WriteLine(@"Muahaha \n you have no powers here :)", job);

            string firstName = "William";
            string lastName = "Ingram";
            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine(fullName);

            ///////// DATATYPES AND VARIABLES CHALLENGE ///////////
            
            byte myByte = 255;
            sbyte mySByte = 127;
            int myInt = 2147483647;
            uint myUInt = 4293967295;
            short myShort = 32767;
            ushort myUShort = 65535;
            long myLong = 9223372036854775807;
            ulong myULong = 18446744073709551615;
            float myFloat = 12094.12479214f;
            double myDouble = 1.2147987102739810924310924712;
            char myChar = 'a';
            bool myBool = true;
            string myString = "abcdefg";
            decimal myDecimal = 12345.6789m;
            
            Console.WriteLine(myByte.ToString(), mySByte, myInt, myUInt, myShort, myUShort, myLong, myULong, myFloat, myDouble, myChar, myBool, myString, myDecimal);


            string control = "I control text";
            string number = "42";

            Console.WriteLine(control);
            Console.WriteLine(Int32.Parse(number));

            // create a constant of type string with your birthday as its value
            const string birthday = "06.30.96";
            Console.WriteLine($"My birthday is always going to be {birthday}");

            // produces error
            /* birthday = "07.01.96"; */
        }
    }
}
