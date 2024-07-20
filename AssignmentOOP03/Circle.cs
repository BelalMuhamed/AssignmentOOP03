using AssignmentOOP03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP03
{
    internal class Circle : ICircle
    {
        public int Area { get ; set ; }

        public void DispalyShapeInfo()
        {
            Console.WriteLine($"Arae of the circle is {Area}" ); ;
        }
    }
}
