﻿namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to the automatic check-in at Jurassic Park Bank");
            Console.WriteLine("John Hammond and everyone working at Jurassic Park, hopes that your visit is everything you expect and more");
            Console.WriteLine("May I please have your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Ah welcome, {userName}! We are delighted to have you staying with us.");
            Console.WriteLine("I have your reservations right here, and one final question.");
            Console.WriteLine("Will you be wanting to take the walking tour, or the tour that you will be riding? ");
            Console.WriteLine("Please state 'walking' or 'riding'");
            string userTourPick = Console.ReadLine();

            ITour tour = TourFactory.GetTour(userTourPick);
            tour.Tour();
            


        }
    }
}





//Create a console app that utilizes factory pattern by taking a user’s input of how many tires are on a vehicle and, based on their input, creates that type of vehicle.
//Complete this using an interface.
//You must have at least 2 subclasses.
//For instance, if I type 4 into the console, the program would create a car or truck, or if someone types 2 it would create a motorcycle.

//Feel free to use something other than vehicles if you want to be creative, but the other constraints still apply!


//Create an Interface named IVehicle that has a stubbed out public void Drive method.
//Create 2 new public classes that will conform to IVehicle.
//Example) Car, Motorcycle, BigRig
//Note: These classes must conform to IVehicle and implement the Drive() method - which will just Console.WriteLine(“Building a new Car!”)

//Now we will make our static VehicleFactory class.
//It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter
//Call this functionality in the Main method.