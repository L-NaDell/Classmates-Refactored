using System;
using System.Collections.Generic;
using System.Text;

namespace ClassmatesRefactored
{
    class StudentInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Hometown { get; set; }
        public string FavoriteSong { get; set; }
        public string FavoriteFood { get; set; }
        public string CookieDough { get; set; }
        public string Color { get; set; }

        //    BF's~ Select an empty line. Click screwdriver(to the left). Select Generate Constructor. Select the Add Null Checks button for verification.   
        //public StudentInfo(string firstName, string lastName, string hometown, string favoriteSong, string favoriteFood, string cookieDough, string color)
        //{
        //    FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        //    LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        //    Hometown = hometown ?? throw new ArgumentNullException(nameof(hometown));
        //    FavoriteSong = favoriteSong ?? throw new ArgumentNullException(nameof(favoriteSong));
        //    FavoriteFood = favoriteFood ?? throw new ArgumentNullException(nameof(favoriteFood));
        //    CookieDough = cookieDough ?? throw new ArgumentNullException(nameof(cookieDough));
        //    Color = color ?? throw new ArgumentNullException(nameof(color));
        //}

        public StudentInfo(string firstName, string lastName, string hometown, string favoriteSong, string favoriteFood, string cookieDough, string color)
        {
            FirstName = firstName;
            LastName = lastName;
            Hometown = hometown;
            FavoriteSong = favoriteSong;
            FavoriteFood = favoriteFood;
            CookieDough = cookieDough;
            Color = color;

        }

        public void PrintName()
        {
            Console.WriteLine(FirstName);

        }
    }
}
