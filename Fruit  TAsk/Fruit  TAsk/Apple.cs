using System;
using System.Collections.Generic;
using System.Text;

namespace Fruit__TAsk
{
    internal class Apple<T>
    {
        private T Vitamins;
        public Apple( T vitamin)
        {
            Vitamins = vitamin;
        }
        public override string ToString()
        {
            return $"Apple Vitamins: {Vitamins}";
        }
    }
}
