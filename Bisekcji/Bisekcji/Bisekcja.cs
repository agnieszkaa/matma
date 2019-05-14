﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisekcji
{
    public class Bisekcja
    {
        private static double dokladnosc;
        private static int choice;
        private static double repeatAmount;
        private static int i;

        public static void Execute()
        {
            Console.Write("\nWybierz wielomian:\n 1:(x-3)(x+5)=0 \n2:(x - 7) * (x - 2) * (x + 6)=0");
            choice = readValue();
            Console.Write("\nPodaj dół przedziału");
            int a = readValue();
            Console.Write("\nPodaj góre przedziału");
            int b = readValue();
            Console.Write("\nUstaw dokładność");
            string input = Console.ReadLine();

            dokladnosc = Convert.ToDouble(input);
            repeatAmount = Math.Log((b - a) / dokladnosc, 2) - 1;
            double pierwiastek = Factorial(a, b);
            Console.Write("\npierwiastek: {0}", pierwiastek);

            i = 0;
            Console.Write("\nkoniec");
        }

        static double Factorial(double a, double b)
        {
            double x0 = (a + b) / 2;
            var wbez = Math.Abs(b - a);
            if (wbez < dokladnosc || repeatAmount < i)
            {
                return x0;
            }
            i++;
            if (f(x0) == 0)
            {
                return x0;
            }
            else if (f(a) * f(x0) <= 0)
            {
                Console.Write("\n{0}", x0);

                return Factorial(a, x0);
            }
            else if (f(b) * f(x0) <= 0)
            {
                Console.Write("\n{0}", x0);
                return Factorial(x0, b);
            }
            else
            {
                Console.Write("\n zadnego przedzialu z roznica");
                return x0;
            }
        }

        private static double f(double x)
        {
            if (choice == 1)
            {
                //return (9 * Math.Pow(x, 4)) - (6 * Math.Pow(x, 3)) + (Math.Pow(x, 2));
                return (x - 3) * (x + 5);
            }
            else if (choice == 2)
            {
                // return (3 * Math.Pow(x, 4)) + (3 * Math.Pow(x, 2)) + 2;
                return (x - 7) * (x - 2) * (x + 6);
            }
            else
            {
                throw new Exception();
            }
        }

        private static int readValue()
        {
            string input = Console.ReadLine();
            return Convert.ToInt32(input);
        }
    }
}