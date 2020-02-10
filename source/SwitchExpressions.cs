namespace WhatIsNewInCSharp
{
    public class SwitchExpressions
    {
        enum DataScope
        {
            PrivateLease,
            Business,
            All,
            PublicPages,
            ShortLease
        }

        enum Scope
        {
            Business,
            PrivateLease,
            ShortLease,
            Undefined
        }

        //Classic Switch
        Scope ClassicFromDataScopeToScope(DataScope dataScope)
        {
            switch (dataScope)
            {
                case DataScope.Business:
                    return Scope.Business;

                case DataScope.PrivateLease:
                    return Scope.PrivateLease;

                case DataScope.ShortLease:
                    return Scope.ShortLease;

                default:
                    return Scope.Undefined;
            }
        }

        Scope FromDataScopeToScope(DataScope dataScope) =>
            dataScope switch
            {
                DataScope.Business => Scope.Business,
                DataScope.PrivateLease => Scope.PrivateLease,
                DataScope.ShortLease => Scope.ShortLease,
                _ => Scope.Undefined
            };
    }
}