using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hj
{
    interface IProvod<T>
    {
        T RndValue();
        T UserValue();
    }
}
