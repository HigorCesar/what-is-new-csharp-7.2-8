using System;

namespace WhatIsNewInCSharp
{
    interface ILoggerOne
    {
        public void Log() => Console.WriteLine("ILoggerOne");

        public static void LogS() => Console.WriteLine("Static logging");
    }

    interface ILoggerTwo
    {
        public void Log() => Console.WriteLine($"ILoggerTwo");

        public void Log(bool critical) => Console.WriteLine($"ILoggerTwo-critical{critical}");
    }

    public class ConcreteLogger : ILoggerOne, ILoggerTwo
    {
    }
}