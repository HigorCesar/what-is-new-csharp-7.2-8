using System.Threading;

namespace WhatIsNewInCSharp
{
    public class Foo
    {
        public string Identifier { get; set; }
        public string Name { get; set; }
    }

    class NullCoalescingOperator
    {
        private Foo GetFooFromCache(string identifier)
        {
            return null;
        }

        private Foo GetFooExpensiveOperation(string identifier)
        {
            Thread.Sleep(200);
            return new Foo
            {
                Identifier = identifier
            };
        }

        public string GetFooName(string identifier)
        {
            var foo = GetFooFromCache(identifier);
            foo ??= GetFooExpensiveOperation(identifier);

            return foo.Name;
        }

        public string GetFooNameV2(string identifier) => (GetFooFromCache(identifier) ?? GetFooExpensiveOperation(identifier)).Name;
    }
}