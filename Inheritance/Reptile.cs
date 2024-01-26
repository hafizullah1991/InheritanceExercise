using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public string Species { get; set; }
        public bool IsColdBlood { get; set; } = true;
        public int NumberOfLegs { get; set; }
        public string Habitat { get; set; }

        public Reptile(string species, bool isCold, int numberOfLegs, string habitat)
        {
            Species= species;
            IsColdBlood= isCold;
            NumberOfLegs= numberOfLegs;
            Habitat= habitat;

        }
        public void Display()
        {
            Console.WriteLine($"Meet our reptile friend: {Species}");
            Console.WriteLine($"NumberOfLegs: {NumberOfLegs}");
            Console.WriteLine($"Is Cold-Blooded: {IsColdBlood} ");
            Console.WriteLine($"Habitat: {Habitat}");
        }
    }
}
