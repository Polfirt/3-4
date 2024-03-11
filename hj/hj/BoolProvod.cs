using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hj
{
    class BoolProvod : IProvod<bool>
    {
        Random rnd = new Random();
        public bool UserValue()
        {
            return bool.Parse(Console.ReadLine());
        }
        
        public bool RndValue()
        {
            bool[] bools = { true, false };
            return bools[rnd.Next(bools.Length)];
        }
 
    }
}
