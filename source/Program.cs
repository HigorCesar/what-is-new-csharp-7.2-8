using System;
using System.Linq;

namespace WhatIsNewInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //IndicesAndRanges
            var indicesAndRanges = new IndicesAndRanges();

            Console.WriteLine("Top 3 fruits");
            foreach (var fruit in indicesAndRanges.TopNFruits(20))
                Console.WriteLine(fruit);

            Console.WriteLine("Paged fruits");
            foreach (var fruit in indicesAndRanges.GetFruitsPaged(10, 3))
                Console.WriteLine(fruit);

            Console.WriteLine("Range of fruits");
            foreach (var fruit in indicesAndRanges.GetRangeOfFruits(^2..)) //last two items
                Console.WriteLine(fruit);

            //Take is safer as it will not throw exceptions if the asked range is bigger than the actual one
            Console.WriteLine("Top 20 fruits");
            foreach (var fruit in indicesAndRanges.Fruits.Take(20))
                Console.WriteLine(fruit);
        }
    }
}