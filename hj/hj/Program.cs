using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hj
{
    class Program
    {
        static void Main()
        {
            IPrintable[] print = new IPrintable[8];

            IntProvod bint = new();
            StringProvod bstring = new();
            DoubleProvod bdouble = new();
            BoolProvod bbool = new();
            

            Console.WriteLine("Если хотите ввести все сами, введите 'true', если же Вам в падлу, то пишите 'false'.");
            bool userInput = bool.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Массив типа int");
            OneDimensionalArray<int> intone = new(bint, userInput);
            print[0] = intone;
            Console.WriteLine("Массив типа string");
            OneDimensionalArray<string> stringone = new(bstring, userInput);
            print[1] = stringone;
            Console.WriteLine("Массив типа double");
            OneDimensionalArray<double> doubleone = new(bdouble, userInput);
            print[2] = doubleone;
            Console.WriteLine("Массив типа bool");
            OneDimensionalArray<bool> boolone = new(bbool, userInput);
            print[3] = boolone;

            Console.WriteLine();

            TwoDimensionalArray<int> inttwo = new(bint, userInput);
            print[4] = inttwo;
            TwoDimensionalArray<string> stringtwo = new(bstring, userInput);
            print[5] = stringtwo;
            TwoDimensionalArray<double> doubletwo = new(bdouble, userInput);
            print[6] = doubletwo;
            TwoDimensionalArray<bool> booltwo = new(bbool, userInput);
            print[7] = booltwo;

            Console.WriteLine();

            for (int i = 0; i < print.Length; i++)
            {
                Console.WriteLine($"Массив {print[i].GetType()}:");

                print[i].Print();
                Console.WriteLine();
            }
        }
    }
}
