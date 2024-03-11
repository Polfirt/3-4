using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hj
{
    sealed class OneDimensionalArray<T> : BaseArray<T>
    {
        private int b;
        private T[] array;

        public OneDimensionalArray(IProvod<T> provod, bool userInput = false) : base(provod, userInput) 
        { 

        }

        public override void Initialize()
        {
            Console.WriteLine("Введите количество элементов для одномерного массива");
            b = int.Parse(Console.ReadLine());

            array = new T[b];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите значение элемента {i}: ");
                array[i] = provod.UserValue();
            }
            Console.WriteLine();

        }
        public override void RandomInitialize()
        {
            b = rnd.Next(1, 101);

            array = new T[b];

            for (int i = 0; i < b; i++)
            {
                array[i] = provod.RndValue();
            }
        }

        public override void Print()
        {
            Console.WriteLine("Одномерный массив:");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

        }
    }
}
