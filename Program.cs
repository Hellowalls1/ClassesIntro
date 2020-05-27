using System;

namespace ClassesIntro {
    class Program {
        static void Main (string[] args) {
            Car adamsCar = new Car (); //this is an object or rather the actrual car

            //these are getting get and set in Cars.cs
            //instance of car class
            adamsCar.Color = "Silver";
            adamsCar.Make = "Mazda";
            adamsCar.Model = "3";
            adamsCar.Year = 2010;

            //one expression 
            //instance of car class
            Car drewsCar = new Car () {
                Make = "Audi",
                Model = "A6",
                Color = "Black",
                Year = 2013
            };

            //everytime you access the description it will get it from the Cars.cs
            Console.WriteLine (adamsCar.Description);

            adamsCar.Year = 2009;

            Console.WriteLine (adamsCar.Description);

            adamsCar.Drive (20_000);

            Console.WriteLine (adamsCar.GetOdometer ());

        }
    }
}