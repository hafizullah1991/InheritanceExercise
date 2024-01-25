using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
namespace Inheritance
{  
    internal class Bird: Animal
    {
     
         
        public bool Song { get; set; } = true;
        public string Wings { get; set; }
        public string Beak { get; set; }
        public int Toe{ get; set; }

    }
}
