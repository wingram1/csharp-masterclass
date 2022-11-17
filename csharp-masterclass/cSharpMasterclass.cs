using System;

namespace cSharpNotes
{
    internal class cSharpMasterclass
    {
        // Entry point of our program
        static void Main(string[] args)
        {
            /*  
            s02_DataTypesVariables();
            s03_FunctionsMethods();

            */

            s04_MakingDecisions();
        }

        // access modifier => (static) => return type => method => name (parameter 1, parameter 2)
        public static void s02_DataTypesVariables()
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
        public static void s03_FunctionsMethods()
        {
            WriteSomething();

            string message = "Hello method!";
            WriteSomethingSpecific(message);

            Console.WriteLine($"Addition result: {Add(50, 25)}");

            Console.WriteLine($"Multiplication result: {Multiply(40, 12)}");

            Console.WriteLine($"Division result: {Divide(104, 13)}");

            //////// Friends Challenge ////////
            string friend1 = "Ming";
            string friend2 = "Seth";
            string friend3 = "Jamie";

            Console.WriteLine(GreetFriend(friend1, friend2, friend3));


            //////// Coding Exercise 1 /////////
            string inputString = "Yabba dabba doo! ";
            Console.WriteLine(ToLowerAndUpper(inputString));
            CharCount(inputString);




            ///////// User Input //////////
            Console.WriteLine("Write something: ");
            string userInput = Console.ReadLine();
            Console.WriteLine($"You wrote: {userInput}");

            Console.WriteLine($"Your result is: {Calculate()}");

            Operators();

            // access modifier => (static) => return type => method name (parameter 1, parameter 2)
            static void WriteSomething()
            {
                Console.WriteLine("I am called from a method");

            }

            static void WriteSomethingSpecific(string myText)
            {
                Console.WriteLine($"Your text: {myText}");
            }

            static int Add(int param1, int param2)
            {
                Console.WriteLine($"\nPerforming operation {param1} + {param2}...");

                int result = param1 + param2;

                return result;
            }

            static int Multiply(int param1, int param2)
            {
                Console.WriteLine($"\nPerforming operation {param1} * {param2}...");

                int result = param1 * param2;

                return result;
            }

            // need to perform necessary type conversion on params
            static double Divide(double param1, double param2)
            {
                Console.WriteLine($"\nPerforming operation {param1} / {param2}...");

                double result = param1 / param2;

                return result;
            }

            static string GreetFriend(string myFriend1, string myFriend2, string myFriend3)
            {
                return $"Hello {myFriend1}, {myFriend2}, and {myFriend3}: my friends!";
            }

            static string ToLowerAndUpper(string input)
            {
                string lower = input.ToLower();
                string upper = input.ToUpper();

                return String.Join("", lower, upper);
            }

            static void CharCount(string input)
            {
                Console.WriteLine($"The amount of characters is {input.Length}.");
            }

            static string Calculate()
            {

                try
                {
                    Console.WriteLine("Enter first number to be divided: ");
                    int num1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number to be divided: ");
                    int num2 = Int32.Parse(Console.ReadLine());

                    return ($"Your calculation result is: {(num1 / num2).ToString()}");
                }
                // wrong type error
                catch (FormatException)
                {
                    return ("Format exception, please enter correct type next time");
                }
                // too large for type error
                catch (OverflowException)
                {
                    return ("Overflow exception, number was too long or too short for Int32");
                }
                // catch null value error
                catch (ArgumentNullException)
                {
                    return ("ArgumentNullException, the value was empty (null)");
                }
                catch (DivideByZeroException)
                {
                    return ("DivideByZeroException - you can't divide by zero, dummy.");
                }
                // catch-all error
                catch (Exception)
                {
                    return ("General Exception");
                }
                // always called at the end of try/catch
                finally
                {
                    Console.WriteLine("Have a nice day!");
                }



            }

            static void Operators()
            {
                int num1 = 5;
                int num2 = 3;
                int num3;

                // unary operators
                num3 = -num1;
                Console.WriteLine("num3 is {0}", num3);

                bool isOvercast = true;
                Console.WriteLine("Is it sunny? {0}", !isOvercast);


                // increment operators
                int num = 0;
                num++;

                // pre increment
                Console.WriteLine("increment: num++ = {0}\n happens after WriteLine", num++);
                Console.WriteLine("pre increment: ++num = {0}\n happens before WriteLine", ++num);

                // decrement / predecrement
                Console.WriteLine("decrement: num-- = {0}", num--);
                Console.WriteLine("pre decrement: --num = {0}", --num);

                // mathematical operators
                Console.WriteLine($"result of {num1} + {num2} is {num1 + num2}");
                Console.WriteLine($"result of {num1} - {num2} is {num1 - num2}");
                Console.WriteLine($"result of {num1} * {num2} is {num1 * num2}");
                Console.WriteLine($"result of {num1} / {num2} is {num1 / num2}");
                Console.WriteLine($"//////modular operator//////\nresult of {num1} % {num2} is {num1 % num2}; returns remainder of division");

                // relational and type operators
                bool isGreater;
                isGreater = 2 > 1;
                Console.WriteLine($"2 > 1 returns {isGreater}");

                bool isEqual;
                isEqual = 1 == 1;
                Console.WriteLine($"1 == 1 returns {isEqual}");

                bool isInequal;
                isInequal = 1 != 2;
                Console.WriteLine($"1 != 2 returns {isInequal}");

                bool isLesser;
                isLesser = 1 < 2;
                Console.WriteLine($"1 < 2 returns {isLesser}");

                // conditional (aka logical) operators
                bool isLesserAndSunny;
                isLesserAndSunny = isLesser && !isOvercast;
                Console.WriteLine($"isLesser && !isOvercast returns {isLesserAndSunny} - needs both conditions to be true");

                bool isGreaterOrOvercast;
                isGreaterOrOvercast = isGreater || !isOvercast;
                Console.WriteLine($"isLesser || !isOvercast returns {isGreaterOrOvercast} - only needs one to be true");
            }
        }

        public static void s04_MakingDecisions()
        {
            /////////////   IF/ELSE STATEMENTS //////////////
            if(1 == 2)
            {
                Console.WriteLine("1==2");
            }
            else if (2 == 2)
            {
                Console.WriteLine("1==2 not true, so 2==2");
            }
            else
            {
                Console.WriteLine("No correct statements");
            }


            ///////////// temp exercise /////////////
            Console.WriteLine("What is the temperature?");
            string tempString = Console.ReadLine();
            int temp;

            // can do this (try/catch method)
            try
            {
                temp = int.Parse(tempString);

                if (temp < 60)
                {
                    Console.WriteLine("Take a coat");
                }
                else if (temp > 80)
                {
                    Console.WriteLine("Wear shorts and a t-shirt");
                }
                else
                {
                    Console.WriteLine("Wear whatever's comfortable. You can't go wrong!");
                }
            }
            catch
            {
                Console.WriteLine("Error! Input not of type int. Temp set to 0.");
                temp = 0;
            }

            // can also do this (TryParse) - returns boolean result
            string numberAsString = "42";
            int parsedValue;

            if (int.TryParse(numberAsString, out parsedValue))
            {
                Console.WriteLine($"Parsing successful - number is {parsedValue}");
            }
            else
            {
                Console.WriteLine("Parsing failed.");
            }

            /////////////Coding Challenge - Odd or Even/////////////
            
            static void CheckIfOddOrEven(int number)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }

            int myOdd1 = 9;
            int myOdd2 = 83;
            int myEven1 = 70;
            int myEven2 = 2;

            // should print odd/odd/even/even
            CheckIfOddOrEven(myOdd1);
            CheckIfOddOrEven(myOdd2);
            CheckIfOddOrEven(myEven1);
            CheckIfOddOrEven(myEven2);

            ////////////////////////////////////////////////////////
            
            static void NestedCheck(int number)
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine("Divisible by 3.");
                }
                else if (number % 7 == 0)
                {
                    Console.WriteLine("Divisible by 7.");
                }
                else
                {
                    if (number % 2 != 0)
                    {
                        Console.WriteLine("Odd number.");
                    }
                    else
                    {
                        Console.WriteLine("Even number.");
                    }
                }
            }

            NestedCheck(myOdd1);
            NestedCheck(myOdd2);
            NestedCheck(myEven1);
            NestedCheck(myEven2);

            ////////////// Challenge - If Statements ////////////////
            string username;
            string password;

            void Register()
            {
                Console.WriteLine("===========REGISTRATION===========\nEnter your username:");
                username = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                password = Console.ReadLine();

            }

            void Login()
            {
                Console.WriteLine("Login:\nEnter your username:");
                string usernameInput = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                string passwordInput = Console.ReadLine();

                if (username != usernameInput || password != passwordInput)
                {
                    Console.WriteLine("Invalid credentials. Restart program.");
                }
                else
                {
                    Console.WriteLine($"Welcome {username}");
                }
            }

            // Register();
            // Login();

            int highscore = 0;
            string highscorePlayer = "";

            void highscoreCheck(int newScore, string playerName)
            {
                if (newScore > highscore)
                {
                    highscore = newScore;
                    highscorePlayer = playerName;
                    Console.WriteLine("New highscore is " + highscore + ", set by " + highscorePlayer + ".");
                }   
                else
                {
                    Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer + ".");
                }
            }

            highscoreCheck(15, "Bobby");
            highscoreCheck(14, "Susie");
            highscoreCheck(5000, "h4ck3r");

            //////////// TERNARY OPERATORS //////////////

            int temperature = -5;
            string stateOfMatter;

            stateOfMatter = temperature <= 0 ? "solid" : "liquid";
            Console.WriteLine($"temp is {stateOfMatter}");

            temperature = 105;
            stateOfMatter = temperature <= 0 ? "solid" : temperature >= 100 ? "gas" : "liquid";
            Console.WriteLine($"temp is {stateOfMatter}");


            // challenge
            static void tempCheck(int temp)
            {
                string message = temp <= 15 ? 
                    "it is too cold here" : 
                    temp > 28 ? 
                        "it is hot here" : 
                        "it is ok";

                Console.WriteLine(message);
            }

            tempCheck(10);
            tempCheck(123);
            tempCheck(20);
        }

        public static void s05_Loops()
        {
            // for
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
            }

            // while
            int counter = 0;
            while(counter < 10)
            {
                counter++;
                Console.WriteLine(counter);
            };

            // do while
            do
            {
                Console.WriteLine(counter);

            } while (counter > 0);

            
            // for each
        }
    }
}
