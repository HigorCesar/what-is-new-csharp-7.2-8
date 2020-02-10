using System;
using System.IO;

namespace WhatIsNewInCSharp
{
    class SomethingDisposable : IDisposable
    {
        public string HelloWorld(string name) => $"Hello World {name}";

        public void Dispose()
        {
        }
    }

    class SomethingWithDisposeMethod
    {
        public string HelloWorld(string name) => $"Hello World {name}";

        public void Dispose()
        {
        }
    }

    class UsingDeclaration
    {
        public void Main()
        {
            using var instanceWhichMustBeDisposed = new SomethingDisposable();
            instanceWhichMustBeDisposed.HelloWorld("Higor");

            using var memStream = new MemoryStream();
            using var streamWriter = new StreamWriter(memStream);
            streamWriter.WriteLine(instanceWhichMustBeDisposed.HelloWorld("Higor"));
            streamWriter.Flush();
        }
    }
}