using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hj
{
    class StringProvod : IProvod<string>
    {
        Random rnd = new();
        public string UserValue()
        {
            return Console.ReadLine();
        }
        public string RndValue()
        {
            string al = "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя0123456789";
            string a = "";
            for (int i = 0; i < rnd.Next(20); i++) //100 будет много)
            {
                a += al[rnd.Next(al.Length)];
            }
            return a;
        }

        
    }
}
