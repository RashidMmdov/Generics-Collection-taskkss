using System;
using System.Collections.Generic;
using System.Text;

namespace Fruit__TAsk
{
    internal class BasketList<T>
    {
        public T[] Fruits;
        public int Count;
        public int getCount { get => Fruits.Length; }
        public BasketList()
        {
            
                Fruits = new T[0];
            }
            public T[] getFruits()
            {
                return Fruits;
            }
            public void Add(T fruit)
            {
                Array.Resize(ref Fruits, Fruits.Length + 1);
                Fruits[Fruits.Length - 1] = fruit;
            }
        
    }
}
