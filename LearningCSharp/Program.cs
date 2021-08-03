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
            //SayHi("Mike", 20);
            Console.WriteLine(Cube(5));

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
            Console.WriteLine("grade : " +  grade);
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
            Console.WriteLine(num1  + num2);
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
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42 };
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
    }
}
