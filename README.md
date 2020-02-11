# What is new/interesting in C# 7.2 and 8.0

Simple and small exploration of new features available in the latests C# releases.

## Enabling C# Latest versions

C# 8 can be used with the .NET Framework and other targets older than .NET Core 3.0/.NET Standard 2.1 in Visual Studio 2019 (or older versions of Visual Studio if you  [install a Nuget package](https://stackoverflow.com/a/58190585/397817).

The language version must be set to  `8.0`  in the csproj file.

## Nullable reference types

C# 8.0 introduces **nullable reference types** and **non-nullable reference types** that enable you to make important statements about the properties for reference type variables.  

Samples in NullableReferenceType.cs  
[more](https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references)

### Where it is useful

The ability to declare more properties about reference types brings more typesafety and type soundness to your code.
I consider this feature of high valuable to express input and output of functions, providing a more accurate information to API client.

## Using declaration

A **using declaration** is a variable declaration preceded by the `using` keyword. It tells the compiler that the variable being declared should be disposed at the end of the enclosing scope.
Using declaration is a declarative way to handle disposable objects instead of the classic imperative of the using statement.

Samples in UsingDeclaration.cs  
[more](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#using-declarations)

## Switch expressions

Often, a [`switch`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch) statement produces a value in each of its `case` blocks. **Switch expressions** enable you to use more concise expression syntax.

Samples in SwitchExpressions.cs  
[more](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#switch-expressions)

## Indices and Ranges

Ranges and indices provide a succinct syntax for accessing single elements or ranges in a sequence.
This feature should be a good replacement if you are already working with indices, therefore handling _Out of range exceptions_. In the examples there are scenarios like paging which can be solved by using indices and ranges but I would continue with the combination of skip + take in order to avoid the _Out of range_ validations.

Samples in IndicesAndRanges.cs  
[more](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#indices-and-ranges)

## Null-Coalescing assignement

C# 8.0 introduces the null-coalescing assignment operator `??=`. You can use the `??=` operator to assign the value of its right-hand operand to its left-hand operand only if the left-hand operand evaluates to `null`.

Samples in NullCoalescingOperator.cs  
[more](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#null-coalescing-assignment)
