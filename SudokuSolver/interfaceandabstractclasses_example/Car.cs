using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.interfaceandabstractclasses_example
{
    abstract internal class Car
    {

        protected bool _on;

        public void TurnOnOff()
        {
            if (_on)
            {
                _on = !_on;
                Console.WriteLine(_on ? "The car is on" : "The car is off");
            }
        }

        //this means that - Drive method would need to be defined in each class
        //that derives from this abstract class
        public abstract void Drive();
    }
}
