using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassmatesRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = GetStudentInfos();
            string again = "y";

            Console.WriteLine("Welcome to our C# class!\n");

            while (again == "y")
            {
                Console.WriteLine();
                foreach (StudentInfo student in students.OrderBy(student => student.FirstName))
                {
                    student.PrintName();
                }
                try
                {
                    Console.WriteLine("Would you like to (1) find out information about a student or (2) add another student?");

                    int response = int.Parse(Console.ReadLine());

                    switch (response)
                    {
                        case 1:
                            GetInfo(students);
                            break;
                        case 2:
                            AddStudent(students);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Sorry, I didn't catch that. Please try again.", ex);
                }
                Console.WriteLine("Is there something else you would like to do? (y/n)");
                again = Console.ReadLine().ToLower();
            }
            Console.WriteLine("\n Goodbye! :)");
        }
        //Get info for new student and add them to the list.
        public static void AddStudent(List<StudentInfo> students)
        {
            string firstName = GetUserInput("Student's first name: ");
            string lastName = GetUserInput("Last name: ");
            string hometown = GetUserInput("Hometown: ");
            string favoriteFood = GetUserInput("Favorite food: ");
            string favoriteSong = GetUserInput("Favorite song: ");
            string cookieDough = GetUserInput("How do they like their cookie dough? ");
            string color = GetUserInput("Favorite color: ");

            students.Add(
                new StudentInfo(firstName, lastName, hometown, favoriteFood, favoriteSong, cookieDough, color)
            );
        }

        //verify info
        private static string GetUserInput(string message)
        {
            string input;
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter vailid input.");
                }
            } while (string.IsNullOrEmpty(input));

            return input;
        }

        public static void GetInfo(List<StudentInfo> students)
        {
            string moreInfo = "y";
            string reqStudent = GetUserInput("What student whould you like to know about?").Trim();
            var student = students.Find(student => student.FirstName == reqStudent);

            if (student != null)
            {
                do
                {
                    string info = GetUserInput($"What would you like to know about {student.FirstName} {student.LastName}? (hometown, favorite food, favorite song, cookie dough, color)").ToLower().Trim();

                    switch (info)
                    {
                        case "hometown":
                            Console.WriteLine($"{student.FirstName} is from {student.Hometown}.");
                            break;

                        case "favorite food":
                            Console.WriteLine($"One of {student.FirstName}'s favorite foods is {student.FavoriteFood}!");
                            break;

                        case "favorite song":
                            Console.WriteLine($"{student.FirstName} likes to listen to {student.FavoriteSong}.");
                            break;

                        case "cookie dough":
                            Console.WriteLine($"{student.FirstName} prefers cookie dough to be {student.CookieDough}.");
                            break;

                        case "color":
                            Console.WriteLine($"{student.FirstName}'s favorite color is {student.Color}!");
                            break;
                    }

                    Console.WriteLine($"Would you like more information about {student.FirstName}? (y/n)");
                    moreInfo = Console.ReadLine().Trim().ToLower();
                } while (moreInfo == "y");
            }
            else
            {
                Console.WriteLine("Sorry that user does not exist");
            }
        }

        //Student info...lots and lots of student info
        public static List<StudentInfo> GetStudentInfos()
        {
            List<StudentInfo> students = new List<StudentInfo>
            {
                new StudentInfo
                (
                    "Akii",
                    "Christian",
                    "San Francisco, CA",
                    "Eye of the Tiger by Survivor",
                    "pizza",
                    "made into cookies",
                    "yellow"
                ),
                new StudentInfo
                (
                   "Alex",
                    "Crang",
                   "New York, NY",
                   "Sound The Alarm by Thievery Corporation",
                   "taco's",
                   "in ice cream",
                   "green"
                ),
                new StudentInfo
                (
                   "Barthelemy",
                   "Martinon",
                   "Seattle, WA",
                   "ambient instramental music",
                   "salmon",
                   "in ice cream",
                   "pink"
                ),
                new StudentInfo
                (
                   "Brian",
                   "Stewart",
                   "Chicago, IL",
                   "Tell Me by RL Grime & What So Not",
                   "steak",
                   "in ice cream",
                   "blue"
                ),
                new StudentInfo
                (
                   "Duncan",
                   "MacLachlan",
                   "Austin, TX",
                   "Stachybotrys by DjoHn",
                   "burgers",
                   "made into cookies",
                   "teal"
                ),
                new StudentInfo
                (
                   "Jean",
                   "Thomas",
                   "Detroit, MI",
                   "Lose Yourself by Eminem",
                   "bacon",
                   "made into cookies",
                   "brown"
                ),
                new StudentInfo
                (
                   "Kristen",
                   "Harrell",
                   "Las Vegas, NV",
                   "Don't Stop Believin' by Journey",
                   "pie",
                   "made into cookies",
                   "black"
                ),
                new StudentInfo
                (
                   "Lauren",
                   "Jensen",
                   "Miami, FL",
                   "I Can’t Stop by Flux Pavilion",
                   "cake",
                   "in ice cream",
                   "red"
                ),
                new StudentInfo
                (
                   "Lindsay",
                   "NaDell",
                   "Ann Arbor, MI",
                   "Imaginary Parties by Superfruit",
                   "tomatoes",
                   "made into cookies",
                   "purple"
                ),
                new StudentInfo
                (
                   "Nick",
                   "Hickman",
                   "Indianapolis, ID",
                   "Tubthumping by Chumbawamba",
                   "fruit",
                   "in ice cream",
                   "orange"
                ),
                new StudentInfo
                (
                   "Pin",
                   "Vue",
                   "Columbus, OH",
                   "Sandstorm by Darude",
                   "scallops",
                   "in ice cream",
                   "salmon"
                ),
                new StudentInfo
                (
                   "Robert",
                   "Bizon",
                   "Nashville, TN",
                   "Spicy By The Glass by Terravita",
                  "curry",
                   "in ice cream",
                   "navy"
                )
            };
            return students;
        }
    }
}