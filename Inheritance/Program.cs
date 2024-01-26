using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common



            Bird bird1 = new Bird();
            bird1.Beak = "Yes";
            bird1.Song = true;
            bird1.Wings = "yes";
            bird1.Toe = 3;
            bird1.Weight = 2; 

            //Create an object of your Bird class
           
            
            Console.WriteLine($"The birrds has{bird1.Toe}  {bird1.Wings} {bird1.Song} {bird1.Weight} {bird1.Beak}");
            //Create an object of your Reptile class
            //  give values to your members using the object of your Reptile class
           

            Reptile Rep = new Reptile("Python", true, 4, "Rainforest");
           
            Console.WriteLine("======Calling method=============");

            Rep.Display();
            bird1.DirdDetails();





        }
    }
}
