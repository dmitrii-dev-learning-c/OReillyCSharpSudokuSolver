using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.linq_example
{
    internal class LINQExampleClass
    {

        internal void RunLINQExample()
        {
            Hobbie[] hobbies = { new Hobbie(1, "Walking"), new Hobbie(2, "Swimming"), new Hobbie(3, "Gym") };

            //Where is a LINQ method - we are grabbing the element from hobbies that is equal to "Walking":
            // it returns back a list
            var hobbie = hobbies.Where(h => h.Name.Equals("Walking")).Select(h => h.Name);

            //this would return the same thing as the statement above
            //Syntax: choose the collection and element | condition | number of items to retrieve
            var anotherHobbie = from h in hobbies where h.Name.Equals("Walking") select h;


            //retrieves every hobbie except the first one:
            var everyHobbieExceptFirstOne = hobbies.Skip(1);

            //skip first one and only take the count of 1 - which is swimming (NOT INDEX)
            var swimmingHobbie = hobbies.Skip(1).Take(1);
        }
        

    }


    //Dummy class to play around with:
    class Hobbie
    {
        public Hobbie(int id, string name) 
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
