using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * TOPIC 1: Input, Output, Data Type, User Input, Type Casting 
             */

            /*
            
            Console.WriteLine("Hello World");

            string name = "John";

            Console.WriteLine("I'm " + name);

            Console.WriteLine("What's your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello " + userName);

            Console.WriteLine("How old are you? ");

            string userAgeStr = Console.ReadLine();

            //int userAgeInt = int.Parse(userAgeStr);
            int userAgeInt = Convert.ToInt32(userAgeStr);

            int birthYear = 2024 - userAgeInt;

            //Console.WriteLine("You were born in " + birthYear);
            Console.WriteLine($"You were born in {2024 - userAgeInt}");

            //Console.WriteLine("Your age is " + userAgeInt);
            Console.WriteLine($"Your age is {userAgeInt}");

            */


            /*
             * TOPIC 2: Conditions and If Statements
             */

            /*
            Console.WriteLine("What's your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you? ");
            int userAge = int.Parse(Console.ReadLine());

            double bonus = 0.0;

            if(userAge >= 10 && userAge < 18)
            {
                bonus = 0.2;
            } 
            else if (userAge >= 18 && userAge < 25)
            {
                bonus = 0.1;
            }
            else if(userAge >= 25 && userAge < 55)
            {
                bonus = 0;
            }
            else
            {
                bonus = 1.0;
            }

            Console.WriteLine($"User '{userName}' has bonus of {bonus} ");
            */

            /*
             * TOPIC 3: Switch statement
             */

            /*
             * To Do App
             * 1. Add a task
             * 2. Edit a task
             * 3. Complete a task
             * 4. Display all tasks
             * 5. Exit
             */

            /*  
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n\n***To Do App***\r\n" +
                "1. Add a task\r\n" +
                "2. Edit a task\r\n" +
                "3. Complete a task\r\n" +
                "4. Display all tasks\r\n" +
                "5. Exit\r\n\r\n" +
                "Please enter your choice [1-5]: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Add a task");
                        break;
                    case "2":
                        Console.WriteLine("Edit a task");
                        break;
                    case "3":
                        Console.WriteLine("Complete a task");
                        break;
                    case "4":
                        Console.WriteLine("Display all tasks");
                        break;
                    case "5":
                        Console.WriteLine("Exit");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }
            }
            */

            /*
             * TOPIC 4: Array
             */

            /*
            int[] numbers = new int[4];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            string[] names = { "John", "Jane", "Bob" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            */

            /*
             * TOPIC 5: Methods
             */

            //greetsWorld();
            //greets("John");
            //int userAge = askAge();
            //Console.WriteLine($"Your age is: {userAge}");

            /*
            string[] userNames = new string[5];
            int[] userAges = new int[5];

            double[] bonuses = new double[5];

            for (int i = 0; i < userNames.Length; i++)
            {
                userNames[i] = askName();
                userAges[i] = askAge();
            }

            for (int i = 0; i < bonuses.Length; i++)
            {
                bonuses[i] = calculateBonus(userAges[i]);
            }

            for (int i = 0;  i < userNames.Length; i++)
            {
                greets(userNames[i]);
                Console.WriteLine($"Your age is: {userAges[i]}");
                Console.WriteLine($"Your bonus is: {bonuses[i]}");
            }
            */

        }

        static double calculateBonus(int userAge)
        {
            double bonus = 0.0;
            
            if (userAge >= 10 && userAge < 18)
            {
                bonus = 0.2;
            }
            else if (userAge >= 18 && userAge < 25)
            {
                bonus = 0.1;
            }
            else if (userAge >= 25 && userAge < 55)
            {
                bonus = 0;
            }
            else
            {
                bonus = 1.0;
            }

            return bonus;
        }

        static string askName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int askAge()
        {
            Console.WriteLine("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());
            return age;
        }

        static void greetsWorld()
        {
            Console.WriteLine("Hello World");
        }

        static void greets(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        
    }
}
