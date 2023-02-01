using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            while(true)
            {
                Console.Write("Enter an integer number between 1 and 100: ");
                input = int.Parse(Console.ReadLine());

                if (input >= 1 && input <= 100)
                {
                    break;
                }
            }

           
            while (true)
            {
                Console.WriteLine("Specify the series tye: Even or Odd ");
                series = Console.ReadLine();

                if (series == "Even" || series == "Odd")
                {
                    break;
                }
            }


            if (series == "Odd")
            {
                Console.Write("You have selected " + series + " series. The number between 0 and " + input + "are:");
                for (int i = 1; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

            if (series == "Even")
            {
                Console.Write("You have selected " + series + " series. The number between 0 and " + input + "are:");
                for (int i = 0; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
