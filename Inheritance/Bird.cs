using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
namespace Inheritance
{
    internal class Bird : Animal
    {


        public bool Song { get; set; } = true;
        public string Wings { get; set; }
        public string Beak { get; set; }
        public int Toe { get; set; }

        public void DirdDetails()
        {
            Console.WriteLine("Bird Details:");
            Console.WriteLine($" birds can Song: {Song}");
            Console.WriteLine($"birds has Wings: {Wings}");
            Console.WriteLine($"Beak: {Beak}");
            Console.WriteLine($" Number of Toes for birds: {Toe}");
        }
    }
}
