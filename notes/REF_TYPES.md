# Reference & Value Types 

## References
ex:
```c#
var b = new Book(); 
```
b (reference) --- (point sto place in memory) --> Book Object

## Values
```c#
var x = 3;
``` 
int `x` stores the "value" rather than a reference with pointer to memory.

## Examples
```c#
var book1 = new Book();
var book2 = new Book();
Assert.True(Object.ReferenceEquals(book1, book2))
```
__Everything derives from `Object` in C#__

### `struct` as value type
Not used nearly as common as classes. Advanced techniques can be used to establish value types.
```c#
namespace Foo {
    public struct Bar {
    
    }
}
```

### `string` is a reference type, but behaves like a value type
```c#
// x points to ref in memory
var x = "some string";

// but string methods return copies
var uppered = x.ToUpper();

// False
x == uppered;
```

