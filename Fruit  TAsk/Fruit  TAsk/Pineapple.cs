using System;
using System.Collections.Generic;
using System.Text;

namespace Fruit__TAsk
{
    internal class Pineapple<T>
    {
        private T Vitamins;
        public Pineapple(T vitamin)
        {
            Vitamins = vitamin;
        }
        public override string ToString()
        {
            return $"Pineapple Vitamins: {Vitamins}";
        }
    }
}
