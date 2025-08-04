using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.interfaceandabstractclasses_example
{
    internal class Ferrari: Car
    {
        override
        public void Drive()
        {
            if (_on)
            {
                Console.WriteLine("Car is driving");
            }
            else
            {
                Console.WriteLine("Start the car first!");
            }
        }

       
    }
}
