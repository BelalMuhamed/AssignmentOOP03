using AssignmentOOP03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP03
{
    internal class Rectangle : Irectangle
    {
        public int Area { get ; set; }

        public void DispalyShapeInfo()
        {
            Console.WriteLine($"Area of rectangle is {Area}"); ;
        }
    }
}
