using System;
using System.Collections.Generic;
using System.Text;

namespace Fruit__TAsk
{
    internal class Lemon<T>
    {
        private T Vitamins;
        public Lemon(T vitamin)
        {
            Vitamins = vitamin;
        }
        public override string ToString()
        {
            return $"Lemon Vitamins: {Vitamins}";
        }
    }
}
