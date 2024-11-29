using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOOP
{
    class User
    {
        // data fields
        public string Name { get; set; }
        public int Age { get; set; }
        public double Bonus { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
            Bonus = 0.0;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a single User object
            /*
            User user1 = new User("John", 22);
            user1.Bonus = calculateBonus(user1.Age);

            greets(user1.Name);
            Console.WriteLine($"Your age is: {user1.Age}");
            Console.WriteLine($"Your bonus is: {user1.Bonus}");
            */

            // Create a multiple User objects using an array
            User[] users = new User[2];

            for (int i = 0; i < users.Length; i++)
            {
                users[i] = new User(askName(), askAge());
                users[i].Bonus = calculateBonus(users[i].Age);
            }

            for (int i = 0; i < users.Length; i++)
            {
                greets(users[i].Name);
                Console.WriteLine($"Your age is: {users[i].Age}");
                Console.WriteLine($"Your bonus is: {users[i].Bonus}");
            }
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

        static void greets(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }


}
