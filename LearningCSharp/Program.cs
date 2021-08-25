using System;

namespace LearningCSharp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // HelloWorld();
            // Triangle();
            // Intro();
            // Info();
            // StringManipulation();
            // NumberManipulation();
            // Interactions();
            // Calculator();
            // MadLib();
            // LuckyNumbers();
            // SayHi("Mike", 20);
            // Console.WriteLine(Cube(5));
            // Gender();
            // Console.WriteLine(GetMax(20, 10, 40));
            // CalculatorM2();
            // Console.WriteLine(GetDay(5));
            // Countdown();
            // CountdownM2();
            // GuessingGame();
            // CountdownM3();
            // Console.WriteLine(GetPow(4, 3));
            // NumberGrid();
            // Division();

            // Classes & Object
            // Library();
            // Academy();
            // Cinema();
            // Album();

            // Static Methods & Classes
            // e.g
            // Console.WriteLine(Math.Sqrt(144));
            // UsefulTools.SayHi("Mike");

            // Inheritance
            // Restaurant();

            // Stacks
            // StackHi();
            // StackCount();

            // Queue
            // QueueHi();
            // QueueCount();

            // Linked List
            // LinkedListRundown();

            // Collection/Dictionary
            // DictionaryRundown();

            // Binary Search
            SearchBinary();

            Console.ReadLine();
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static void Triangle()
        {
            // Drawing Shape
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");
        }

        static void Intro()
        {
            // Variables
            string characterName = "John";
            int characterAge = 35;
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
        }

        static void Info()
        {
            // Data Types
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.3;
            bool isMale = true;

            Console.WriteLine("phrase : " + phrase);
            Console.WriteLine("grade : " + grade);
            Console.WriteLine("age : " + age);
            Console.WriteLine("gpa : " + gpa);
            Console.WriteLine("isMale :" + isMale);
        }

        static void StringManipulation()
        {
            // Working with Strings
            string phrase = "Giraffe Academy";
            Console.WriteLine("phrase : " + phrase);
            Console.WriteLine("phrase[0] : " + phrase[0]);
            Console.WriteLine("length : " + phrase.Length);
            Console.WriteLine("ToUpper : " + phrase.ToUpper());
            Console.WriteLine("ToLower : " + phrase.ToLower());
            Console.WriteLine("Contains(\"Academy\"): " + phrase.Contains("Academy"));
            Console.WriteLine("Contains(\"Academies\"): " + phrase.Contains("Academies"));
            Console.WriteLine("IndexOf(\"Academy\") : " + phrase.IndexOf("Academy"));
            Console.WriteLine("IndexOf(\"f\") : " + phrase.IndexOf("f"));
            Console.WriteLine("IndexOf(\"z\") : " + phrase.IndexOf("z"));
            Console.WriteLine("Substring(8) : " + phrase.Substring(8));
            Console.WriteLine("Substring(8, 3) : " + phrase.Substring(8, 3));
        }

        static void NumberManipulation()
        {
            int num = 6;

            Console.WriteLine("num : " + num);
            Console.WriteLine("Abs(-40) : " + Math.Abs(-40));
            Console.WriteLine("Power(3, 2) : " + Math.Pow(3, 2));
            Console.WriteLine("Power(3.8, 2) : " + Math.Pow(3.8, 2));
            Console.WriteLine("Sqrt(36) : " + Math.Sqrt(36));
            Console.WriteLine("Max(4, 90) : " + Math.Max(4, 90));
            Console.WriteLine("Min(4, 90) : " + Math.Min(4, 90));
            Console.WriteLine("Round(4.3) : " + Math.Round(4.3));
            Console.WriteLine("Round(4.6) : " + Math.Round(4.6));
            Console.WriteLine("(5 + 8) : " + (5 + 8));
            Console.WriteLine("(5 - 8) : " + (5 - 8));
            Console.WriteLine("(5 * 8) : " + (5 * 8));
            Console.WriteLine("(5 / 8) : " + (5 / 8));
            Console.WriteLine("(5 % 2) : " + (5 % 2));
        }

        static void Interactions()
        {
            string name;
            string age;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        static void Calculator()
        {
            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);
        }

        static void MadLib()
        {
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);
        }

        static void LuckyNumbers()
        {
            // array
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[3];
            friends[0] = "Jim";
            friends[1] = "Kelly";
            friends[2] = "Sam";

            for (int i = 0; i < luckyNumbers.Length; i++)
                Console.WriteLine(luckyNumbers[i]);

            luckyNumbers[1] = 900;
            for (int i = 0; i < luckyNumbers.Length; i++)
                Console.WriteLine(luckyNumbers[i]);

            for (int i = 0; i < friends.Length; i++)
                Console.WriteLine(friends[i]);
        }

        // Methods
        static void SayHi(String name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        // Return Methods
        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        // If statements
        static void Gender()
        {
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male.");
            } else if (isMale && !isTall) {
                Console.WriteLine("You are a short male.");
            } else if (!isMale && isTall) {
                Console.WriteLine("You are not a male but you are tall.");
            } else
            {
                Console.WriteLine("You are not male or not tall.");
            }
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            } else
            {
                result = num3;
            }

            return result;
        }

        static void CalculatorM2()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            } else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            } else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            } else
            {
                Console.WriteLine("Invadid Operator");
            }
        }

        // Switches
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }

        // Loop
        static void Countdown()
        {
            int index = 1;

            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
        }

        static void CountdownM2()
        {
            int index = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);
        }

        static void GuessingGame()
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");
            } else
            {
                Console.WriteLine("You Win!");
            }
        }

        // for loop
        static void CountdownM3()
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }
            // Console.WriteLine(Math.Pow(baseNum, powNum));

            return result;
        }

        // 2d array
        static void NumberGrid()
        {
            int[,] numberGrid =
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            Console.WriteLine(numberGrid[1, 1]);
        }

        // exception handling
        static void Division()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write(num1 / num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Division Has Ended.");
            }
        }

        static void Library()
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            Book book2 = new Book("Lord Of The Rings", "Tolkein", 700);

            Book book3 = new Book();

            book2.title = "Hobbit";

            Console.WriteLine(book2.title);
        }

        static void Academy()
        {
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
        }

        static void Cinema()
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            shrek.Rating = "R";

            Console.WriteLine(avengers.Rating);
            Console.WriteLine(shrek.Rating);
            // Ratings Only
            // G, PG, PG-13, R, NR
        }

        static void Album()
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);
            // Console.WriteLine(holiday.getSongCount());

            // Console.WriteLine(holiday.title);
            // Console.WriteLine(kashmir.title);
        }

        static void Restaurant()
        {
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecailDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakePasta();
            italianChef.MakeSpecailDish();
        }

        static void StackHi()
        {
            SimpleStack myStack = new SimpleStack();
            myStack.stackSimple();
        }

        static void StackCount()
        {
            GenericStack myStack = new GenericStack();
            myStack.stackGeneric();
        }

        static void QueueHi()
        {
            SimpleQueue myQ = new SimpleQueue();
            myQ.queueSimple();
        }

        static void QueueCount()
        {
            GenericQueue myQ = new GenericQueue();
            myQ.queueGeneric();
        }

        static void LinkedListRundown()
        {
            GenericLinkedList myLinkedList = new GenericLinkedList();
            myLinkedList.linkedListGeneric();
        }

        static void DictionaryRundown()
        {
            GenericCollection myCollection = new GenericCollection();
            myCollection.DictionaryGeneric();
        }

        static void SearchBinary()
        {
            BinarySearch mySearch = new BinarySearch();
            mySearch.binarySearch();
        }

    }
}
