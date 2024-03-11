using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace hj
{
    abstract class BaseArray<T> : IBaseAr, IPrintable
    {
        protected IProvod<T> provod;

        protected static Random rnd = new Random();

        protected bool userInput = false;

        public BaseArray(IProvod<T> provod, bool userInput)
        {
            this.provod = provod;
            this.userInput = userInput;
            FillAr();
        }

        public void FillAr()
        {
            if (userInput)
            {
                Initialize();
            }
            else
            {
                RandomInitialize();
            }
        }
        
        public abstract void Initialize();
        public abstract void RandomInitialize();
        public abstract void Print();
    }
}

