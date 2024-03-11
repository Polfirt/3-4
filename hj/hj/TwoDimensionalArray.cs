using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hj
{
    sealed class TwoDimensionalArray<T> : BaseArray<T>
    {
        private int b;
        private int c;
        

        private T[,] array;

        public TwoDimensionalArray(IProvod<T> values, bool userInput = false) : base(values, userInput) 
        {

        }

        public override void Initialize()
        {
            Console.WriteLine("Введите количество строк и столбцов для двумерного массива");
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            array = new T[b, c];

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"Введите значение элемента [{i},{j}]: ");
                    array[i, j] = provod.UserValue();
                }
            }
            Console.WriteLine();

        }
        public override void RandomInitialize()
        {
            b = rnd.Next(1, 101);
            c = rnd.Next(1, 101);

            array = new T[b, c];

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    array[i, j] = provod.RndValue();
                }
            }
        }

        public override void Print()
        {
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();

            }
        }

    }
}
