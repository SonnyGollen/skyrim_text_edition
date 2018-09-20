using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim___Text_Edition.Story.Cities;

namespace Skyrim___Text_Edition
{
    class Program
    {
        static void Main()
        {
            //Set console window size
            Console.SetWindowSize(125,30);

            //Introduction to the game
            //new Introduction();
            //Console.Clear();

            //Act 1 - Unbound
            new Helgen().Act1_Unbound();
        }
    }
}
