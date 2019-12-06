# Control Flow

## Looping
- [for](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for)
- [foreach](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach-in)
- [do](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do)
- [while](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while)

### Jumping w/ `break` and `continue` (and `goto` but no one really uses it anyways 🤷‍♂️)
- `break` will break out of the loop entirely
- `continue` will skip over that particular iteration but then will keep iterating over the rest of the iterable.

## [Switch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch)
Switch statements work like you would expect in any other language.

One thing of note is the ability to do "Pattern matching." This seems useful for writing expressive cases while declaring a variable.
```c#
switch (foo.bar) 
{
  case x when x > 5:
    return "This is cool";
  case x when x < 5 => "So is this...";
}
```

## [Exceptions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/)
Using `try` `catch` blocks also seems to work as you would expect.

You can catch by exception type and also include `finally` to always execute some block of code, regardless of whether one or more exceptions was thrown.

ie.
```c#
try {
  double.Parse(foo)
} 
catch(ArgumentException ex) 
{
  Console.WriteLine(ex.Message);
  throw;
} 
catch (Exception ex)
{
  // some generic exception handling
} 
finally {
  // some code I want to do at the end
  Console.WriteLine("Done!");
}

```


