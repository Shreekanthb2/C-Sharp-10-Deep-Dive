using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_10_Deep_Dive.Source
{
    internal class LambdaExpressions
    {

        public void PrintData()
        {
            // Lambda Expression Improvements 
            var getUserInputs = Console.ReadLine;
            var tellUser = (string s) => Console.WriteLine(s);
            var waitForEnter = Console.ReadLine;

            tellUser("Please Enter Name");
            var name = getUserInputs();
            tellUser($"Your name is {name}");
            waitForEnter();

        }
    }
}
