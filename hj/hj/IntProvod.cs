using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hj
{
    class IntProvod : IProvod<int>
    {
        Random rnd = new Random();
        public int UserValue()
        {
            return int.Parse(Console.ReadLine());
        }
        public int RndValue()
        {
            return rnd.Next(20); //100 будет много)
        }

        
    }
}
