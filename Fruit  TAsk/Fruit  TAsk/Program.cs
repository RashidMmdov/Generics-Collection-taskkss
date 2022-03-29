using System;

namespace Fruit__TAsk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple<string> apple = new Apple<string>("E, B1, B2, Ca, Na, P, Fe");
            Pineapple<string> pineapple = new Pineapple<string>("A, B5, C, K, PP, B9");
            Lemon<string> lemon = new Lemon<string>("B5, C, A, E, B9, B1, B3");
            Console.WriteLine("Meyvelerin Vitaminleri:");
            Console.WriteLine(apple);
            Console.WriteLine(pineapple);
            Console.WriteLine(lemon);
            Console.WriteLine("\n----------------\n");
            BasketList<string> basket = new BasketList<string>();

            basket.Add("Apple");
            basket.Add("Pineapple");
            basket.Add("Lemon");
            basket.Add("Banana");
            basket.Add("Melon");
            basket.Add("Watermelon");
            Console.WriteLine("Fruit  list:");
            Console.WriteLine($"Fruit list count: {basket.getCount}");
            Console.WriteLine("Fruit list elements:");
            foreach ( var  item in basket.getFruits())
            {
                Console.WriteLine(item);
            }
        }
    }
}
