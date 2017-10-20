using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSVirtualAcademyForStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i < 10; i++)
            {
                Console.WriteLine(i);
                if(i == 7)
                {
                    Console.WriteLine("Found 7!");
                    break;
                    //break stops the iteration
                }
            }

            Console.ReadLine();

            for (int myValue = 0; myValue < 12; myValue++)
            {
                //type "for" then tabtab.
                //change "i" then tab; it will update the rest of the line
                //gotta change "length" to whatever
            }

            Console.ReadLine();

            //something new: you can set break points by clicking on the side bar
            //AND you can open a settings menu on it to set conditions
            //it's good for if you, say, don't want to watch the debugger
            //run through the loop seven times
        }
    }
}
