using GA_Travelling_Salesman.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GA_Travelling_Salesman
{
    public sealed class GlobalRandom
    {
        private static readonly Random instance = new Random();
        private GlobalRandom() { }
        public static Random Instance { get => instance; }
    }
}
