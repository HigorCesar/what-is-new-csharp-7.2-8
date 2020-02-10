using System;
using System.Collections.Generic;

namespace WhatIsNewInCSharp
{
    public class IndicesAndRanges
    {
        public readonly string[] Fruits = new[]
        {
            "Apple", "Banana", "Peach", "Apricot", "pear", "strawberry", "raspberry", "cherry", "lime", "lemon", "orange", "grapes"
        };

        public IEnumerable<string> GetFruitsPaged(int page, int size)
        {
            var startIndex = (page - 1) * size;
            var endIndex = startIndex + size;
            return Fruits[startIndex..endIndex];
        }

        public IEnumerable<string> GetRangeOfFruits(Range range) => Fruits[range];

        public IEnumerable<string> TopNFruits(int n) => Fruits[..n];
    }
}