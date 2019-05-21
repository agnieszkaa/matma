using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisekcji
{
    class Program
    {
    
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nWybierz metode:\n1: newton \n2: bisekcja\n");
                var choiceString = Console.ReadLine();
                var choice = Convert.ToInt32(choiceString);
                if(choice == 1)
                {
                    //newton
                }
                else
                {
                    Bisekcja.Execute();
                }

                Console.ReadKey();
            }
        }

       
    }
}
