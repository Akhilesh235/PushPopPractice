using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushPopPractice
{
    internal class Element
    {
        public int Value
        {
            get; set;
        }

        public void displayValue()
        {
            Console.WriteLine("I am inside the assembly" + Value) ;
        }
    }
}
