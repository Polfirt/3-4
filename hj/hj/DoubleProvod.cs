using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hj
{
    class DoubleProvod : IProvod<double>
    {
        Random rnd = new Random();
        public double UserValue()
        {
            return double.Parse(Console.ReadLine());
        }
        public double RndValue()
        {
            return rnd.NextDouble();
        }

        
    }
}
