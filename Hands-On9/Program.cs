using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Hands_On9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which application would you like to review?\n\t1. Logger\n\t2. Animal factory");
            string menuSelection = Console.ReadLine();
            if (menuSelection == '1')
            {
                Log();

            }
        }
    }
}
