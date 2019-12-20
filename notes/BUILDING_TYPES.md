# Building Types

## Method overloading

Consider the signature, which consists of:
- Method name
- Formal parameters

C# compiler does _not_ look at:
- return type

when determining signature for overloading.

This method is overloaded because the signatures vary
ex:
```c#
interface foo {
  public void AddGrade(char letter) // ✅
  public void AddGrade(char letter, int grade) // ✅
}
```

This one, results in a compiler error:
```c#
interface foo {
  public void AddGrade(char letter) // ✅
  public char AddGrade(char letter) // ❌
}
```

## Defining properties

### Auto properties

```c#
class Foo {
  public Foo(){
    category = "Geography"; ✅ you can set readonly fields in constructor
    CATEGORY = "Math"; // ❌ can't override a const
  }

  public string Bar
  {
    private set;
    get;
  }
  
  readonly string category = "science";
  public const string CATEGORY = "Social Studies";
}
```

`const` as a local variable or class member.
It differs from `readonly` in that a `readonly` property can be modified or set in the constructor whereas const cannot.




