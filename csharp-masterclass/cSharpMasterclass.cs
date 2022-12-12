using System;

namespace cSharpMasterclass
{
    internal class cSharpNotes
    {
        // Entry point of our program
        static void Main(string[] args)
        {
            /*  
            s02_DataTypesVariables();
            s03_FunctionsMethods();
            s04_MakingDecisions();
            s05_Loops();
            s06_OOP();
            */

            s07_Arrays();
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
            //for(int counter = 0; counter < 10; counter++)
            //{
              //  Console.WriteLine(counter);
            //}

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
                counter--;
            } while (counter > 0);


            /////// Challenge - Loops 1 - Average ///////

            void getScoreAverage()
            {
                bool done = false;
                int sum = 0;
                int num = 0;

                while (done == false)
                {
                    Console.WriteLine("Enter a score: ");
                    int score = -1;

                    try { 
                        score = Int32.Parse(Console.ReadLine()); 
                    }
                    catch
                    {
                        Console.WriteLine("Input not of type Int32.");
                        continue;
                    }

                    if (score < 0 || score > 20)
                    {
                        Console.WriteLine("You must enter a number between 0 and 20!");
                    }
                    else
                    {
                        sum += score;
                        num++;

                        Console.WriteLine($"Current average: {sum / num}");
                        Console.WriteLine("Are you done? y/n");
                        done = Console.ReadKey().Key == ConsoleKey.Y ? true : false;
                    }
                }

                Console.WriteLine($"Final average: {sum/num}");

            }

            getScoreAverage();
            
        }

        public static void s06_OOP()
        {
            Human bob = new Human("Bob");
            Human joe = new Human("Joe", 45);
            Human simon = new Human("Simon", 45, "red");
            Human immortal = new Human("Immortal,", "The", "all-seeing");
            Human william = new Human("William", "Ingram", 26, "brown");
            Human sissy = new Human("Sissy", "Wagner", 1, "Blue");
            Human basicHuman = new Human();

            sissy.Introduce();
            william.Introduce();
            basicHuman.Introduce();
            bob.Introduce();
            joe.Introduce();
            simon.Introduce();
            immortal.Introduce();

            // default dimensions set to 0
            // length/width/height are private so can't change from here
            Box box = new Box();
            box.DisplayInfo();

            // use custom setter method to change private properties
            box.Length = 3;
            box.Height = -4;
            box.Width = 5;

            box.DisplayInfo();

            Console.WriteLine($"Volume is {box.Volume}, front surface is {box.FrontSurface}");

            Members lucy = new Members();
            lucy.Introducing(true);
            lucy.Introducing(false);
        }

        public static void s07_Arrays()
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine($"grades at index 0 : {grades[0]}");

            // assign value
            grades[0] = 10;

            Console.WriteLine($"Changed grade at index 0: {grades[0]}");

            // way #2 of initializing
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            // way #3 of initializing
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine($"Length of gradesOfMathStudentsA: {gradesOfMathStudentsA.Length}");
            Console.WriteLine($"Length of gradesOfMathStudentsB: {gradesOfMathStudentsB.Length}");


            int[] nums = new int[10];

            Console.WriteLine(nums);

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            for(int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine($"Element {j}: {nums[j]}");
            }

            // can also use forEach loop
            int counter = 0;
            foreach(int k in nums)
            {
               Console.WriteLine($"{counter}: {k}");
               counter++;
            }

            string[] friends = {"Ming", "Seth", "Andrew", "Sunil", "Nick"};

            foreach (string l in friends)
            {
                Console.WriteLine($"Hello, {l}!");
            }

            static void GetOdd(int[] Array)
            {
                foreach(int i in Array)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            static void GetEven(int[] Array)
            {
                foreach (int i in Array)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            static void Run()
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                GetOdd(array);
                GetEven(array);
            }

            Run();

            static void InputTypeCheck()
            {
                string input = Console.ReadLine();

                Console.WriteLine($"You entered: {input}");

                if (Int32.TryParse(input, out int j))
                {
                    Console.WriteLine("It is of type int");
                }
                else
                {
                    switch(input)
                    {
                        case "true":
                            Console.WriteLine("It is of type bool");
                            break;
                        case "false":
                            Console.WriteLine($"It is of type bool");
                            break;
                        default:
                            Console.WriteLine($"It is of type int");
                            break;
                    }
                }
            }

            //InputTypeCheck();


            // 2D Array
            string[,] matrix;

            // 3D array
            int[,,] threeD;

            int[,] array2D = new int[,] 
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            // target center value, have to put both indices
            Console.WriteLine($"Central value is {array2D[1,1]}");
            Console.WriteLine($"Bottom-left value is {array2D[2,0]}");

            int[,,] array3D = new int[,,]
            {
                {
                    {1, 2, 3},
                    {4, 5, 6},
                    {7, 8, 9}
                },
                {
                    {6, 7, 8},
                    {8, 9, 10},
                    {11, 12, 13}
                },
                {
                    {14, 15, 16},
                    {17, 18, 19},
                    {20, 21, 22},
                }
            };

            // specify 2D array length
            string[,] array2DString = new string[3, 2]
            {
                {"one", "two"},
                {"three", "four"},
                {"five", "six"}
            };

            // change "four" to "chicken
            array2DString[1, 1] = "chicken";

            // get dimensions of array (1, 2, 3);
            int dimensions = array2DString.Rank;
            Console.WriteLine(dimensions);





            ////////////////// tic tac toe challenge //////////////////
            
            string[,] board = new string[3, 3]
            {
                { " ", " ", " "},
                { " ", " ", " "},
                { " ", " ", " "},
            };

            static void WriteBoard(string[,] Board)
            {
                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine($" {Board[i, 0]} | {Board[i, 1]} | {Board[i, 2]} ");
                    if (i < 2)
                    {
                        Console.WriteLine("-----------");
                    }
                }
            }

            static bool CheckIfComplete(string[,] Board)
            {
                // left to right diag
                if (Board[0,0] == Board[1,1] && Board[0,0] == Board[2,2] && Board[0, 0] != " ")
                {
                    return true;
                }
                // right to left diag
                if (Board[0,2] == Board[1,1] && Board[0,2] == Board[2,0] && Board[0,2] != " ")
                {
                    return true;
                }
         
                for (int i = 0; i < 3; i++)
                {
                    // check cols
                    if (Board[0,i] == Board[1,i] && Board[0,i] == Board[2,i] && Board[0,i] != " ")
                    {
                        return true;
                    }
                    // check rows
                    if (Board[i,0] == Board[i,1] && Board[i,0] == Board[i, 2] && Board[i,0] != " ")
                    {
                        return true;
                    }
                    
                }

                return false;
            }

            // show empty board
            WriteBoard(board);

            bool player1Currently = true;

            // play game
            while (CheckIfComplete(board) == false) {
                int player = player1Currently ? 1 : 2;

                Console.WriteLine($"Player {player}: Enter Row 1, 2, or 3");
                char input1 = Console.ReadLine()[0];

                Console.WriteLine($"Player {player}: Enter Column 1, 2, or 3");
                char input2 = Console.ReadLine()[0];

                int row = -1;
                int col = -1;

                // error handling
                switch (input1)
                {
                    case '1':
                        row = 0;
                        break;
                    case '2':
                        row = 1;
                        break;
                    case '3':
                        row = 2;
                        break;
                    default:
                        break;
                }

                switch (input2)
                {
                    case '1':
                        col = 0;
                        break;
                    case '2':
                        col = 1;
                        break;
                    case '3':
                        col = 2;
                        break;
                    default:
                        break;
                }

                if (row > -1 && col > -1)
                {
                    if (board[row,col] == " ")
                    {
                        board[row,col] = player1Currently ? "X" : "O";

                        // switch players
                        player1Currently = !player1Currently;

                        // write board to console
                        WriteBoard(board);
                    }
                    else
                    {
                        Console.WriteLine("Error! There is already a mark here!");
                    }
                }
                else
                {
                    Console.WriteLine("Error! Must input 1, 2, or 3");
                }
            }

            Console.WriteLine("Game complete!");
        }
    }
}
